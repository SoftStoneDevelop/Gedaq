

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
    Id = 3,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 22, milliseconds: 634),
new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 30, milliseconds: 185),
new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 15, milliseconds: 462),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 6,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 37, milliseconds: 27),
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 9, milliseconds: 83),
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 12, milliseconds: 508),
new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 7, milliseconds: 910),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 1,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 10, milliseconds: 718),
new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 16, milliseconds: 94),
new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 16, milliseconds: 691),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 7,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 0, milliseconds: 728),
new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 10, milliseconds: 899),
new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 0, milliseconds: 862),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 15, milliseconds: 937),
new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 13, milliseconds: 161),
new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 32, milliseconds: 692),
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 43, milliseconds: 302),
},
},
            new TimeSpanintervalArray1M
{
    Id = 8,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 17, milliseconds: 647),
new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 1, milliseconds: 671),
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 11, milliseconds: 810),
new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 3, milliseconds: 601),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 4,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 33, milliseconds: 9),
new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 34, milliseconds: 758),
new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 12, milliseconds: 113),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 55, milliseconds: 214),
new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 45, milliseconds: 989),
new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 26, milliseconds: 222),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 49, milliseconds: 208),
},
},
            new TimeSpanintervalArray1M
{
    Id = 16,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 43, milliseconds: 706),
new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 34, milliseconds: 968),
new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 41, milliseconds: 863),
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 32, milliseconds: 770),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 20,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 36, milliseconds: 921),
new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 18, milliseconds: 649),
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 17, milliseconds: 21),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 39, milliseconds: 282),
new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 48, milliseconds: 225),
new TimeSpan(days: 0, hours: 12, minutes: 49, seconds: 22, milliseconds: 4),
new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 44, milliseconds: 316),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 58, milliseconds: 393),
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 51, milliseconds: 210),
new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 45, milliseconds: 769),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 28,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 6, milliseconds: 819),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 12, milliseconds: 848),
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 42, milliseconds: 213),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 31,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 45, milliseconds: 240),
new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 45, milliseconds: 191),
new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 5, milliseconds: 805),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 11,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 56, milliseconds: 518),
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 12, milliseconds: 220),
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 55, milliseconds: 40),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 16, milliseconds: 639),
new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 34, milliseconds: 257),
new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 57, milliseconds: 666),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 36,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 28, milliseconds: 787),
new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 51, milliseconds: 763),
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 19, milliseconds: 524),
new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 48, milliseconds: 895),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 37,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 22, milliseconds: 773),
new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 2, milliseconds: 607),
new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 29, milliseconds: 195),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 53, milliseconds: 802),
new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 22, milliseconds: 590),
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 35, milliseconds: 200),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 31, milliseconds: 693),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 40, milliseconds: 850),
new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 9, milliseconds: 720),
},
},
            new TimeSpanintervalArray1M
{
    Id = 41,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 58, milliseconds: 666),
new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 8, milliseconds: 101),
new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 43, milliseconds: 120),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 7, milliseconds: 780),
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 55, milliseconds: 269),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 55, milliseconds: 936),
},
},
            new TimeSpanintervalArray1M
{
    Id = 49,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 26, milliseconds: 976),
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 46, milliseconds: 613),
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 2, milliseconds: 62),
new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 29, milliseconds: 94),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 28, milliseconds: 948),
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 10, milliseconds: 738),
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 10, milliseconds: 408),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 21, milliseconds: 414),
new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 34, milliseconds: 239),
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 7, milliseconds: 943),
},
},
            new TimeSpanintervalArray1M
{
    Id = 51,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 44, milliseconds: 147),
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 5, milliseconds: 463),
new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 20, milliseconds: 279),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 23, milliseconds: 528),
new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 49, milliseconds: 351),
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 18, milliseconds: 18),
},
},
            new TimeSpanintervalArray1M
{
    Id = 57,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 28, seconds: 43, milliseconds: 120),
new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 14, milliseconds: 486),
new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 10, milliseconds: 298),
new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 10, milliseconds: 808),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 25,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 20, milliseconds: 840),
new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 3, milliseconds: 727),
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 20, milliseconds: 319),
new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 28, milliseconds: 74),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 33, milliseconds: 450),
new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 34, milliseconds: 330),
new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 16, milliseconds: 708),
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 14, milliseconds: 516),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 40, milliseconds: 994),
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 22, milliseconds: 243),
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 17, milliseconds: 856),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 23, milliseconds: 379),
new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 16, milliseconds: 691),
new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 3, milliseconds: 554),
},
},
            new TimeSpanintervalArray1M
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 7, seconds: 39, milliseconds: 613),
new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 54, milliseconds: 733),
new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 44, milliseconds: 860),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 40, milliseconds: 728),
new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 17, milliseconds: 132),
new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 24, milliseconds: 961),
new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 1, milliseconds: 715),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 40, milliseconds: 185),
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 3, milliseconds: 830),
new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 26, milliseconds: 984),
new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 24, milliseconds: 407),
},
},
            new TimeSpanintervalArray1M
{
    Id = 76,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 38, milliseconds: 558),
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 46, milliseconds: 263),
new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 9, milliseconds: 77),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 80,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 19, milliseconds: 237),
new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 53, milliseconds: 950),
new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 2, milliseconds: 987),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 33,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 26, milliseconds: 657),
new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 22, milliseconds: 894),
new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 55, milliseconds: 942),
new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 46, milliseconds: 994),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 84,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 56, milliseconds: 254),
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 10, milliseconds: 412),
new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 38, milliseconds: 619),
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 52, milliseconds: 588),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 37, seconds: 20, milliseconds: 783),
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 11, milliseconds: 184),
new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 52, milliseconds: 733),
},
},
            new TimeSpanintervalArray1M
{
    Id = 87,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 7, milliseconds: 109),
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 4, milliseconds: 540),
new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 44, milliseconds: 825),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 40,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 57, milliseconds: 161),
new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 32, milliseconds: 431),
new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 4, milliseconds: 312),
new TimeSpan(days: 0, hours: 3, minutes: 30, seconds: 53, milliseconds: 457),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 94,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 28, milliseconds: 597),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 8, milliseconds: 336),
new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 22, milliseconds: 904),
new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 40, milliseconds: 687),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 50, seconds: 41, milliseconds: 366),
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 3, milliseconds: 436),
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 38, milliseconds: 546),
},
},
            new TimeSpanintervalArray1M
{
    Id = 99,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 31, milliseconds: 826),
new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 55, milliseconds: 850),
new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 20, milliseconds: 127),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 47,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 51, milliseconds: 686),
new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 20, milliseconds: 607),
new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 51, milliseconds: 416),
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 20, milliseconds: 555),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 107,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 6, milliseconds: 485),
new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 12, milliseconds: 570),
new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 41, milliseconds: 364),
new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 52, milliseconds: 833),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 115,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 35, milliseconds: 84),
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 34, milliseconds: 761),
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 47, milliseconds: 617),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 51,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 36, milliseconds: 275),
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 47, milliseconds: 678),
new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 53, milliseconds: 733),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 123,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 35, milliseconds: 792),
new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 41, milliseconds: 828),
new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 21, milliseconds: 916),
new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 33, milliseconds: 105),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 127,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 11, milliseconds: 412),
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 22, milliseconds: 884),
new TimeSpan(days: 0, hours: 21, minutes: 15, seconds: 22, milliseconds: 569),
new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 53, milliseconds: 953),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 53,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 50, milliseconds: 866),
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 35, milliseconds: 498),
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 28, milliseconds: 95),
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 34, milliseconds: 166),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 22, seconds: 58, milliseconds: 524),
new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 57, milliseconds: 289),
new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 12, milliseconds: 975),
},
},
            new TimeSpanintervalArray1M
{
    Id = 128,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 0, milliseconds: 94),
new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 26, milliseconds: 883),
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 55, milliseconds: 8),
new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 43, milliseconds: 350),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 134,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 57, seconds: 55, milliseconds: 940),
new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 56, milliseconds: 115),
new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 49, milliseconds: 354),
new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 33, milliseconds: 409),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 61,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 39, milliseconds: 126),
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 0, milliseconds: 192),
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 27, milliseconds: 880),
new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 57, milliseconds: 175),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 3, milliseconds: 918),
new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 12, milliseconds: 336),
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 14, milliseconds: 664),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 137,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 2, milliseconds: 255),
new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 40, milliseconds: 553),
new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 49, milliseconds: 432),
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 53, milliseconds: 979),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 3, milliseconds: 44),
new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 45, milliseconds: 874),
new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 54, milliseconds: 953),
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 5, milliseconds: 526),
},
},
            new TimeSpanintervalArray1M
{
    Id = 138,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 6, milliseconds: 268),
new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 17, milliseconds: 170),
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 19, milliseconds: 311),
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 52, milliseconds: 555),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 28, milliseconds: 723),
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 30, milliseconds: 767),
new TimeSpan(days: 0, hours: 21, minutes: 38, seconds: 52, milliseconds: 928),
new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 10, milliseconds: 328),
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
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 31, milliseconds: 693),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 40, milliseconds: 850),
new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 9, milliseconds: 720),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 7, milliseconds: 780),
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 55, milliseconds: 269),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 55, milliseconds: 936),
}));
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 21, milliseconds: 414),
new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 34, milliseconds: 239),
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 7, milliseconds: 943),
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
                parametr1.Value = 6;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 67;
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(24));

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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 67, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 115, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 8, 51))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[29], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeSpanArrayintervalArray)this).ExportModelInner(connection).ToList();
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

