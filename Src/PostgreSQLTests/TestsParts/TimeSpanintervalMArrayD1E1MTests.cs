

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
    internal partial interface ITimeSpanMArrayintervalMArrayD1
    {
    }
    
    internal partial class TimeSpanMArrayintervalMArrayD1 : ITimeSpanMArrayintervalMArrayD1
    {


#region TestData

        private readonly TimeSpanintervalMArrayD1E1M[] _testData = new TimeSpanintervalMArrayD1E1M[]
        {
            new TimeSpanintervalMArrayD1E1M
{
    Id = 6,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 36, seconds: 22, milliseconds: 36),
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 1, milliseconds: 618),
new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 34, milliseconds: 434),
new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 22, milliseconds: 417),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 48, milliseconds: 220),
new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 30, milliseconds: 564),
new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 15, milliseconds: 621),
new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 32, milliseconds: 915),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 15,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 51, milliseconds: 700),
new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 53, milliseconds: 754),
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 52, milliseconds: 539),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 7,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 14, milliseconds: 677),
new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 49, milliseconds: 921),
new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 43, milliseconds: 280),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 24,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 32, milliseconds: 475),
new TimeSpan(days: 0, hours: 21, minutes: 55, seconds: 3, milliseconds: 763),
new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 50, milliseconds: 581),
new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 6, milliseconds: 353),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 29,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 26, milliseconds: 252),
new TimeSpan(days: 0, hours: 4, minutes: 22, seconds: 19, milliseconds: 254),
new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 30, milliseconds: 958),
new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 12, milliseconds: 850),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 16,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 51, milliseconds: 883),
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 54, milliseconds: 119),
new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 58, milliseconds: 46),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 58, milliseconds: 495),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 1, milliseconds: 330),
new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 13, milliseconds: 989),
new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 10, milliseconds: 14),
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 5, milliseconds: 39),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 3, milliseconds: 134),
new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 55, milliseconds: 993),
new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 33, milliseconds: 267),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 38,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 40, milliseconds: 404),
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 2, milliseconds: 857),
new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 10, milliseconds: 664),
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 10, milliseconds: 594),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 42,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 28, milliseconds: 464),
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 56, milliseconds: 604),
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 721),
new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 49, milliseconds: 628),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 17,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 42, milliseconds: 270),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 32, milliseconds: 952),
new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 7, milliseconds: 515),
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 48, milliseconds: 199),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 51, milliseconds: 434),
new TimeSpan(days: 0, hours: 15, minutes: 6, seconds: 36, milliseconds: 351),
new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 21, milliseconds: 89),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 45,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 46, milliseconds: 252),
new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 36, milliseconds: 678),
new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 16, milliseconds: 586),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 25, milliseconds: 788),
new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 36, milliseconds: 867),
new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 47, milliseconds: 781),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 52,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 1, milliseconds: 992),
new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 0, milliseconds: 907),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 5, milliseconds: 861),
new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 52, milliseconds: 188),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 20,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 27, milliseconds: 865),
new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 53, milliseconds: 702),
new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 39, milliseconds: 640),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 48, milliseconds: 67),
new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 58, milliseconds: 567),
new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 23, milliseconds: 504),
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 46, milliseconds: 871),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 44, milliseconds: 790),
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 52, milliseconds: 924),
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 53, milliseconds: 579),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 57,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 21, milliseconds: 784),
new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 22, milliseconds: 898),
new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 29, milliseconds: 706),
new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 30, milliseconds: 750),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 25, milliseconds: 920),
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 4, milliseconds: 721),
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 41, milliseconds: 525),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 65,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 40, milliseconds: 720),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 51, milliseconds: 77),
new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 35, milliseconds: 65),
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 38, milliseconds: 126),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 56, milliseconds: 537),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 8, milliseconds: 601),
new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 28, milliseconds: 404),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 26, milliseconds: 222),
new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 11, milliseconds: 127),
new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 56, milliseconds: 800),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 4, milliseconds: 791),
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 18, milliseconds: 764),
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 21, milliseconds: 912),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 29, milliseconds: 289),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 26, milliseconds: 456),
new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 10, milliseconds: 154),
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 4, milliseconds: 69),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 72,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 58, milliseconds: 617),
new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 11, milliseconds: 103),
new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 2, milliseconds: 289),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 32,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 30, seconds: 39, milliseconds: 163),
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 58, milliseconds: 578),
new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 0, milliseconds: 430),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 57, milliseconds: 148),
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 52, milliseconds: 865),
new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 37, milliseconds: 163),
new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 39, milliseconds: 433),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 76,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 54, milliseconds: 929),
new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 4, milliseconds: 669),
new TimeSpan(days: 0, hours: 12, minutes: 11, seconds: 10, milliseconds: 368),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 80,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 32, milliseconds: 11),
new TimeSpan(days: 0, hours: 0, minutes: 7, seconds: 53, milliseconds: 84),
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 20, milliseconds: 364),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 39,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 51, milliseconds: 342),
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 43, milliseconds: 319),
new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 21, milliseconds: 648),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 5, milliseconds: 249),
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 58, milliseconds: 581),
new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 45, milliseconds: 818),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 32, milliseconds: 837),
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 40, milliseconds: 808),
new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 50, milliseconds: 41),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 89,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 25, milliseconds: 657),
new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 55, milliseconds: 10),
new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 51, milliseconds: 551),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 96,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 6, milliseconds: 916),
new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 13, milliseconds: 756),
new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 36, milliseconds: 643),
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 35, milliseconds: 875),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 42,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 11, seconds: 40, milliseconds: 801),
new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 10, milliseconds: 307),
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 20, milliseconds: 69),
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 2, milliseconds: 365),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 49, milliseconds: 886),
new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 54, milliseconds: 656),
new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 6, milliseconds: 998),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 101,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 27, milliseconds: 708),
new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 53, milliseconds: 900),
new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 30, milliseconds: 889),
new TimeSpan(days: 0, hours: 18, minutes: 34, seconds: 15, milliseconds: 548),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 39, milliseconds: 186),
new TimeSpan(days: 0, hours: 21, minutes: 11, seconds: 57, milliseconds: 500),
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 58, milliseconds: 300),
new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 0, milliseconds: 863),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 109,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 52, milliseconds: 977),
new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 54, milliseconds: 884),
new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 26, milliseconds: 384),
new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 27, milliseconds: 535),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 43,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 13, milliseconds: 219),
new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 33, milliseconds: 238),
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 3, milliseconds: 174),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 29, milliseconds: 778),
new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 27, milliseconds: 928),
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 50, milliseconds: 465),
new TimeSpan(days: 0, hours: 8, minutes: 44, seconds: 30, milliseconds: 303),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 111,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 41, milliseconds: 343),
new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 32, milliseconds: 69),
new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 38, milliseconds: 196),
new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 44, milliseconds: 899),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 119,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 18, milliseconds: 24),
new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 55, milliseconds: 404),
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 20, milliseconds: 284),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 15, milliseconds: 994),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 45,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 2, milliseconds: 305),
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 1, milliseconds: 741),
new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 53, milliseconds: 592),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 16, milliseconds: 627),
new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 51, milliseconds: 291),
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 22, milliseconds: 518),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 127,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 20, milliseconds: 523),
new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 10, milliseconds: 93),
new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 34, milliseconds: 390),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 132,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 49, seconds: 38, milliseconds: 311),
new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 42, milliseconds: 611),
new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 12, milliseconds: 268),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 48,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 29, milliseconds: 343),
new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 4, milliseconds: 332),
new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 43, milliseconds: 651),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 141,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 41, milliseconds: 232),
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 52, milliseconds: 158),
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 36, milliseconds: 680),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 142,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 55, milliseconds: 98),
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 5, milliseconds: 614),
new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 32, milliseconds: 803),
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 49, milliseconds: 173),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 55,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 29, milliseconds: 494),
new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 54, milliseconds: 787),
new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 43, milliseconds: 474),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 11, milliseconds: 190),
new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 37, milliseconds: 202),
new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 50, milliseconds: 856),
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 28, milliseconds: 94),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 143,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 17, milliseconds: 148),
new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 36, milliseconds: 308),
new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 29, milliseconds: 683),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 145,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 27, milliseconds: 103),
new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 46, milliseconds: 540),
new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 31, milliseconds: 458),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 62,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 57, milliseconds: 576),
new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 54, milliseconds: 908),
new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 45, milliseconds: 260),
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 4, milliseconds: 155),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 23, milliseconds: 363),
new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 6, milliseconds: 619),
new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 2, milliseconds: 919),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 4, milliseconds: 818),
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 21, milliseconds: 685),
new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 58, milliseconds: 137),
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 17, milliseconds: 774),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 152,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 1, milliseconds: 245),
new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 33, milliseconds: 338),
new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 25, milliseconds: 563),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 47, milliseconds: 389),
new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 6, milliseconds: 36),
new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 11, milliseconds: 199),
new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 10, milliseconds: 5),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 156,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 19, milliseconds: 45),
new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 41, milliseconds: 186),
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 0, milliseconds: 517),
new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 43, milliseconds: 618),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 40, milliseconds: 643),
new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 53, milliseconds: 259),
new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 41, milliseconds: 538),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 7, seconds: 31, milliseconds: 381),
new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 13, milliseconds: 79),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 1, milliseconds: 941),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 157,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 57, milliseconds: 994),
new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 9, milliseconds: 583),
new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 56, milliseconds: 451),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 47, milliseconds: 487),
new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 45, milliseconds: 936),
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 22, milliseconds: 845),
new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 44, milliseconds: 107),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 159,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 48, milliseconds: 507),
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 37, milliseconds: 930),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 14, milliseconds: 134),
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 49, milliseconds: 722),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 75,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 6, milliseconds: 664),
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 53, milliseconds: 549),
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 31, milliseconds: 409),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 165,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 25, milliseconds: 78),
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 1, milliseconds: 354),
new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 1, milliseconds: 788),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 8, milliseconds: 592),
new TimeSpan(days: 0, hours: 8, minutes: 11, seconds: 55, milliseconds: 156),
new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 29, milliseconds: 693),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 167,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 18, milliseconds: 280),
new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 1, milliseconds: 110),
new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 17, milliseconds: 330),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 81,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 15, milliseconds: 699),
new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 26, milliseconds: 139),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 20, milliseconds: 380),
new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 38, milliseconds: 323),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 176,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 36, milliseconds: 152),
new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 7, milliseconds: 700),
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 29, milliseconds: 462),
new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 5, milliseconds: 368),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 51, milliseconds: 745),
new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 31, milliseconds: 939),
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 49, milliseconds: 604),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 180,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 54, milliseconds: 749),
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 36, milliseconds: 606),
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 26, milliseconds: 92),
},
    ModelInner = new TimeSpanintervalMArrayD11MI
{
    Id = 84,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 47, milliseconds: 985),
new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 7, milliseconds: 597),
new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 57, milliseconds: 840),
new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 1, milliseconds: 362),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 20, milliseconds: 939),
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 34, milliseconds: 675),
new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 45, milliseconds: 258),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 43, milliseconds: 600),
new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 41, milliseconds: 440),
new TimeSpan(days: 0, hours: 1, minutes: 5, seconds: 52, milliseconds: 327),
},
},
            new TimeSpanintervalMArrayD1E1M
{
    Id = 181,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 14, milliseconds: 16),
new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 20, milliseconds: 292),
new TimeSpan(days: 0, hours: 22, minutes: 57, seconds: 43, milliseconds: 770),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmarrayd11mi(
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
INSERT INTO public.timespanintervalmarrayd11mi(
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
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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

                changedRows =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmarrayd11mi_id
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)), 
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
                methodParametrName: "timespanintervalmarrayd11mi_id", 
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
                changedRows =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmarrayd11mi_id
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
    timespanintervalmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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

                    nullable =  ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 25, milliseconds: 788),
new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 36, milliseconds: 867),
new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 47, milliseconds: 781),
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

                    nullable = await ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 44, milliseconds: 790),
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 52, milliseconds: 924),
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 53, milliseconds: 579),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmarrayd11mi_id
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
    timespanintervalmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                methodParametrName: "timespanintervalmarrayd11mi_id", 
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
                nullable =  ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 25, milliseconds: 920),
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 4, milliseconds: 721),
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 41, milliseconds: 525),
}));
                nullable =  ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 29, milliseconds: 289),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 26, milliseconds: 456),
new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 10, milliseconds: 154),
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 4, milliseconds: 69),
}));
                nullable = await ((ITimeSpanMArrayintervalMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMArrayD1E1M> models = null;

                models =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMArrayD1E1M> models = null;

                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M), typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
LEFT JOIN public.timespanintervalmarrayd11mi mi ON mi.id = m.timespanintervalmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M), typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
LEFT JOIN public.timespanintervalmarrayd11mi mi ON mi.id = m.timespanintervalmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M), typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
LEFT JOIN public.timespanintervalmarrayd11mi mi ON mi.id = m.timespanintervalmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M), typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 80, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
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
FROM public.timespanintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 24, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.timespanintervalmarrayd1e1m m
LEFT JOIN public.timespanintervalmarrayd11mi mi ON mi.id = m.timespanintervalmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 127, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        TimeSpanintervalMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanMArrayintervalMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanMArrayintervalMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((ITimeSpanMArrayintervalMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                TimeSpanintervalMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                TimeSpanintervalMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_timespanintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMArrayD11MIWA),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMArrayD11MI),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalMArrayD1E1M),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
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
FROM public.binary_timespanintervalmarrayd1e1m m
LEFT JOIN public.binary_timespanintervalmarrayd11mi mi ON mi.id = m.timespanintervalmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models =  ((ITimeSpanMArrayintervalMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA), typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmarrayd11mi
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
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalmarrayd11mi
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
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA), typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmarrayd11mi
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
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalmarrayd11mi
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
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MI), typeof(TimeSpanintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models1 = new List<TimeSpanintervalMArrayD11MI>();
                var models2 = new List<TimeSpanintervalMArrayD11MI>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMArrayD11MI>();
                var models2 = new List<TimeSpanintervalMArrayD11MI>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA), typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                await ((ITimeSpanMArrayintervalMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMArrayD11MIWA>();
                var models2 = new List<TimeSpanintervalMArrayD11MIWA>();
                ((ITimeSpanMArrayintervalMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMArrayD1))]
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
                var models = await ((ITimeSpanMArrayintervalMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

