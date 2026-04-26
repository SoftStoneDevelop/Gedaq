

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
    Id = 5,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 46, milliseconds: 58),
new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 12, milliseconds: 867),
new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 9, milliseconds: 168),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 11, milliseconds: 548),
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 27, milliseconds: 830),
new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 36, milliseconds: 225),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 33, milliseconds: 648),
},
},
            new TimeSpanintervalArray1M
{
    Id = 8,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 47, milliseconds: 408),
new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 35, milliseconds: 784),
new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 32, milliseconds: 579),
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 54, milliseconds: 922),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 8,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 54, milliseconds: 442),
new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 5, milliseconds: 663),
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 10, milliseconds: 790),
new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 37, milliseconds: 255),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 14, milliseconds: 627),
new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 16, milliseconds: 337),
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 58, milliseconds: 619),
new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 9, milliseconds: 1),
},
},
            new TimeSpanintervalArray1M
{
    Id = 14,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 37, milliseconds: 388),
new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 8, milliseconds: 202),
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 43, milliseconds: 455),
new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 33, milliseconds: 478),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 58, milliseconds: 791),
new TimeSpan(days: 0, hours: 11, minutes: 28, seconds: 45, milliseconds: 941),
new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 2, milliseconds: 107),
},
},
            new TimeSpanintervalArray1M
{
    Id = 15,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 23, milliseconds: 594),
new TimeSpan(days: 0, hours: 3, minutes: 10, seconds: 5, milliseconds: 35),
new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 6, milliseconds: 917),
new TimeSpan(days: 0, hours: 16, minutes: 19, seconds: 44, milliseconds: 773),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 10,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 38, milliseconds: 698),
new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 4, milliseconds: 652),
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 1, milliseconds: 131),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 49, milliseconds: 162),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 42, milliseconds: 57),
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 53, milliseconds: 273),
new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 52, milliseconds: 468),
},
},
            new TimeSpanintervalArray1M
{
    Id = 20,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 2, milliseconds: 562),
new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 47, milliseconds: 804),
new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 27, milliseconds: 938),
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 20, milliseconds: 325),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 27,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 0, milliseconds: 186),
new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 15, milliseconds: 955),
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 21, milliseconds: 845),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 13,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 27, milliseconds: 927),
new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 12, milliseconds: 423),
new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 50, milliseconds: 979),
new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 44, milliseconds: 715),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 54, milliseconds: 900),
new TimeSpan(days: 0, hours: 6, minutes: 32, seconds: 13, milliseconds: 954),
new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 1, milliseconds: 349),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 33, milliseconds: 408),
},
},
            new TimeSpanintervalArray1M
{
    Id = 31,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 29, milliseconds: 804),
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 0, milliseconds: 373),
new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 11, milliseconds: 777),
new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 37, milliseconds: 428),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 34,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 20, milliseconds: 231),
new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 51, milliseconds: 928),
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 18, milliseconds: 840),
new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 39, milliseconds: 164),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 29, milliseconds: 230),
new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 14, milliseconds: 407),
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 54, milliseconds: 490),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 4, milliseconds: 969),
new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 45, milliseconds: 159),
new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 9, milliseconds: 359),
},
},
            new TimeSpanintervalArray1M
{
    Id = 35,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 12, milliseconds: 11),
new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 53, milliseconds: 273),
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 504),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 27, milliseconds: 629),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 49, milliseconds: 668),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 13, milliseconds: 130),
new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 31, milliseconds: 448),
},
},
            new TimeSpanintervalArray1M
{
    Id = 41,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 36, milliseconds: 133),
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 815),
new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 35, milliseconds: 439),
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 52, milliseconds: 631),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 18,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 18, milliseconds: 656),
new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 23, milliseconds: 247),
new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 37, milliseconds: 759),
new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 37, milliseconds: 355),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 31, milliseconds: 110),
new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 2, milliseconds: 871),
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 228),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 47,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 52, milliseconds: 775),
new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 50, milliseconds: 895),
new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 46, milliseconds: 686),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 26, milliseconds: 169),
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 11, milliseconds: 449),
new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 439),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 15, milliseconds: 685),
},
},
            new TimeSpanintervalArray1M
{
    Id = 53,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 34, milliseconds: 513),
new TimeSpan(days: 0, hours: 12, minutes: 49, seconds: 5, milliseconds: 133),
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 20, milliseconds: 911),
new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 32, milliseconds: 129),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 55, milliseconds: 313),
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 53, milliseconds: 450),
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 47, milliseconds: 740),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 51, milliseconds: 655),
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 52, milliseconds: 546),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 2, milliseconds: 19),
},
},
            new TimeSpanintervalArray1M
{
    Id = 62,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 25, milliseconds: 713),
new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 18, milliseconds: 641),
new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 26, milliseconds: 388),
new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 24, milliseconds: 8),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 28, milliseconds: 127),
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 34, milliseconds: 835),
new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 42, milliseconds: 644),
},
},
            new TimeSpanintervalArray1M
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 38, milliseconds: 844),
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 16, milliseconds: 762),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 41, milliseconds: 861),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 32,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 58, milliseconds: 285),
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 35, milliseconds: 798),
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 50, milliseconds: 707),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 74,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 48, milliseconds: 783),
new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 32, milliseconds: 366),
new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 49, milliseconds: 534),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 81,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 5, milliseconds: 474),
new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 25, milliseconds: 59),
new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 17, milliseconds: 681),
new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 31, milliseconds: 700),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 13, milliseconds: 169),
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 25, milliseconds: 894),
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 30, milliseconds: 256),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 40, milliseconds: 803),
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 5, milliseconds: 692),
new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 29, milliseconds: 85),
new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 48, milliseconds: 941),
},
},
            new TimeSpanintervalArray1M
{
    Id = 83,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 56, milliseconds: 886),
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 24, milliseconds: 557),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 1, milliseconds: 697),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 86,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 52, milliseconds: 397),
new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 3, milliseconds: 102),
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 16, milliseconds: 48),
new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 37, milliseconds: 896),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 43,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 43, milliseconds: 68),
new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 38, milliseconds: 372),
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 21, milliseconds: 93),
new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 45, milliseconds: 503),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 8, milliseconds: 842),
new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 19, milliseconds: 990),
new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 38, milliseconds: 805),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 89,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 32, milliseconds: 961),
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 32, milliseconds: 76),
new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 48, milliseconds: 226),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 0, milliseconds: 23),
new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 46, milliseconds: 240),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 11, milliseconds: 456),
},
},
            new TimeSpanintervalArray1M
{
    Id = 97,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 26, seconds: 31, milliseconds: 113),
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 17, milliseconds: 550),
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 47, milliseconds: 552),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 45,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 28, milliseconds: 825),
new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 13, milliseconds: 360),
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 49, milliseconds: 970),
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 17, milliseconds: 560),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 21, milliseconds: 367),
new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 30, milliseconds: 799),
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 24, milliseconds: 99),
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 47, milliseconds: 901),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 101,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 56, milliseconds: 10),
new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 38, milliseconds: 669),
new TimeSpan(days: 0, hours: 4, minutes: 54, seconds: 56, milliseconds: 166),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 104,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 36, milliseconds: 994),
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 38, milliseconds: 165),
new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 49, milliseconds: 500),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 46,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 20, milliseconds: 291),
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 24, milliseconds: 420),
new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 4, milliseconds: 489),
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 5, milliseconds: 863),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 52, milliseconds: 48),
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 28, milliseconds: 905),
new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 2, milliseconds: 138),
new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 37, milliseconds: 235),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 107,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 10, milliseconds: 643),
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 1, milliseconds: 270),
new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 43, milliseconds: 174),
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 47, milliseconds: 502),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 112,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 41, milliseconds: 908),
new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 37, milliseconds: 983),
new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 31, milliseconds: 862),
new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 18, milliseconds: 516),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 44, milliseconds: 406),
new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 26, milliseconds: 554),
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 28, milliseconds: 642),
new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 52, milliseconds: 742),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 48, milliseconds: 836),
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 37, milliseconds: 220),
new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 25, milliseconds: 388),
new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 38, milliseconds: 471),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 7, milliseconds: 761),
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 53, milliseconds: 229),
new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 28, milliseconds: 756),
},
},
            new TimeSpanintervalArray1M
{
    Id = 117,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 42, milliseconds: 303),
new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 5, milliseconds: 410),
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 2, milliseconds: 753),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 124,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 36, milliseconds: 447),
new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 52, milliseconds: 137),
new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 10, milliseconds: 371),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 45, milliseconds: 846),
new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 56, milliseconds: 5),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 22, milliseconds: 446),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 47, milliseconds: 496),
new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 36, milliseconds: 693),
new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 0, milliseconds: 456),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 128,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 12, milliseconds: 931),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 12, milliseconds: 481),
new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 18, milliseconds: 316),
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 33, milliseconds: 233),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 131,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 26, milliseconds: 954),
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 52, milliseconds: 565),
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 57, milliseconds: 604),
new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 37, milliseconds: 427),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 67,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 42, milliseconds: 55),
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 28, milliseconds: 928),
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 15, milliseconds: 728),
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 11, milliseconds: 203),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 45, milliseconds: 450),
new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 33, milliseconds: 959),
new TimeSpan(days: 0, hours: 15, minutes: 6, seconds: 11, milliseconds: 411),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 26, milliseconds: 621),
new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 44, milliseconds: 394),
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 28, milliseconds: 76),
},
},
            new TimeSpanintervalArray1M
{
    Id = 133,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 28, milliseconds: 93),
new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 46, milliseconds: 76),
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 39, milliseconds: 22),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 138,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 2, milliseconds: 743),
new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 45, milliseconds: 764),
new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 20, milliseconds: 740),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 76,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 13, milliseconds: 910),
new TimeSpan(days: 0, hours: 22, minutes: 57, seconds: 37, milliseconds: 964),
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 13, milliseconds: 403),
new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 51, milliseconds: 949),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 24, milliseconds: 186),
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 32, milliseconds: 500),
new TimeSpan(days: 0, hours: 21, minutes: 22, seconds: 41, milliseconds: 282),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 40, milliseconds: 992),
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
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 54, milliseconds: 900),
new TimeSpan(days: 0, hours: 6, minutes: 32, seconds: 13, milliseconds: 954),
new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 1, milliseconds: 349),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 33, milliseconds: 408),
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
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 4, milliseconds: 969),
new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 45, milliseconds: 159),
new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 9, milliseconds: 359),
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
new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 27, milliseconds: 629),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 49, milliseconds: 668),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 13, milliseconds: 130),
new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 31, milliseconds: 448),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 26, milliseconds: 169),
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 11, milliseconds: 449),
new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 22, milliseconds: 439),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 15, milliseconds: 685),
}));
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 51, milliseconds: 655),
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 52, milliseconds: 546),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 2, milliseconds: 19),
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
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
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[2], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[3], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 128, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[3], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
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
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 86, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 83, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
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

