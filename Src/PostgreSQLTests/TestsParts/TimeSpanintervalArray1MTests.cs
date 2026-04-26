

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
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 35, milliseconds: 298),
new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 10, milliseconds: 93),
new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 51, milliseconds: 830),
new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 8, milliseconds: 736),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 8,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 15, milliseconds: 536),
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 46, milliseconds: 609),
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 7, milliseconds: 624),
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 15, milliseconds: 477),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 4,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 22, milliseconds: 919),
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 3, milliseconds: 397),
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 18, milliseconds: 300),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 39, milliseconds: 740),
new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 0, milliseconds: 175),
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 55, milliseconds: 269),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 16,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 30, seconds: 34, milliseconds: 17),
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 14, milliseconds: 385),
new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 20, milliseconds: 635),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 11, milliseconds: 693),
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 43, milliseconds: 461),
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 43, milliseconds: 107),
},
},
            new TimeSpanintervalArray1M
{
    Id = 22,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 18, milliseconds: 580),
new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 57, milliseconds: 627),
new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 44, milliseconds: 116),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 6,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 44, milliseconds: 163),
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 25, milliseconds: 859),
new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 42, milliseconds: 469),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 42, milliseconds: 521),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 50, milliseconds: 89),
new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 22, milliseconds: 594),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 25,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 41, milliseconds: 497),
new TimeSpan(days: 0, hours: 0, minutes: 7, seconds: 48, milliseconds: 573),
new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 29, milliseconds: 652),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 31,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 14, milliseconds: 603),
new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 39, milliseconds: 499),
new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 51, milliseconds: 424),
new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 14, milliseconds: 882),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 11,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 19, milliseconds: 709),
new TimeSpan(days: 0, hours: 6, minutes: 28, seconds: 54, milliseconds: 335),
new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 54, milliseconds: 710),
new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 45, milliseconds: 720),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 24, milliseconds: 719),
new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 25, milliseconds: 459),
new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 5, milliseconds: 354),
new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 6, milliseconds: 600),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 39,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 25, milliseconds: 845),
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 2, milliseconds: 206),
new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 11, milliseconds: 130),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 40,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 32, milliseconds: 940),
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 17, milliseconds: 732),
new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 15, milliseconds: 785),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 38, milliseconds: 15),
new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 23, milliseconds: 380),
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 20, milliseconds: 652),
new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 39, milliseconds: 639),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 36, seconds: 50, milliseconds: 323),
new TimeSpan(days: 0, hours: 3, minutes: 38, seconds: 5, milliseconds: 877),
new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 30, milliseconds: 545),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 12, milliseconds: 991),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 37, milliseconds: 328),
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 55, milliseconds: 504),
new TimeSpan(days: 0, hours: 18, minutes: 28, seconds: 1, milliseconds: 387),
new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 56, milliseconds: 974),
},
},
            new TimeSpanintervalArray1M
{
    Id = 47,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 47, milliseconds: 533),
new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 27, milliseconds: 42),
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 8, milliseconds: 35),
new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 56, milliseconds: 131),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 35, milliseconds: 69),
new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 58, milliseconds: 656),
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 2, milliseconds: 97),
},
},
            new TimeSpanintervalArray1M
{
    Id = 56,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 26, milliseconds: 840),
new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 8, milliseconds: 955),
new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 17, milliseconds: 882),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 19,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 3, milliseconds: 633),
new TimeSpan(days: 0, hours: 2, minutes: 22, seconds: 41, milliseconds: 893),
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 57, milliseconds: 167),
new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 19, milliseconds: 637),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 43, milliseconds: 214),
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 12, milliseconds: 822),
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 51, milliseconds: 736),
},
},
            new TimeSpanintervalArray1M
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 28, milliseconds: 726),
new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 49, milliseconds: 12),
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 32, milliseconds: 161),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 64,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 18, milliseconds: 508),
new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 13, milliseconds: 93),
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 10, milliseconds: 942),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 23, milliseconds: 389),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 33, milliseconds: 526),
new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 35, milliseconds: 301),
new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 42, milliseconds: 332),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 39, milliseconds: 895),
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 20, milliseconds: 493),
new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 32, milliseconds: 277),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 38, milliseconds: 453),
new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 54, milliseconds: 773),
new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 834),
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 17, milliseconds: 388),
},
},
            new TimeSpanintervalArray1M
{
    Id = 73,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 33, milliseconds: 673),
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 35, milliseconds: 801),
new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 52, milliseconds: 337),
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 1, milliseconds: 259),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 29, milliseconds: 899),
new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 22, milliseconds: 624),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 27, milliseconds: 485),
},
},
            new TimeSpanintervalArray1M
{
    Id = 74,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 20, milliseconds: 49),
new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 10, milliseconds: 939),
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 0, milliseconds: 732),
new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 3, milliseconds: 881),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 22, milliseconds: 759),
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 9, milliseconds: 915),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 24, milliseconds: 692),
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 17, milliseconds: 935),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 19, milliseconds: 828),
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 6, milliseconds: 751),
new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 3, milliseconds: 624),
new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 38, milliseconds: 634),
},
},
            new TimeSpanintervalArray1M
{
    Id = 78,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 2, milliseconds: 223),
new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 1, milliseconds: 103),
new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 26, milliseconds: 451),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 86,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 35, seconds: 24, milliseconds: 499),
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 39, milliseconds: 961),
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 21, milliseconds: 529),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 33,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 30, milliseconds: 486),
new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 32, milliseconds: 640),
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 34, milliseconds: 700),
new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 55, milliseconds: 181),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 55, milliseconds: 430),
new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 5, milliseconds: 408),
new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 3, milliseconds: 564),
},
},
            new TimeSpanintervalArray1M
{
    Id = 88,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 53, milliseconds: 185),
new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 23, milliseconds: 108),
new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 11, milliseconds: 256),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 96,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 33, milliseconds: 556),
new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 46, milliseconds: 283),
new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 21, milliseconds: 686),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 42,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 27, milliseconds: 777),
new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 36, milliseconds: 552),
new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 50, milliseconds: 567),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 44, milliseconds: 690),
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 24, milliseconds: 918),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 8, milliseconds: 547),
new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 4, milliseconds: 392),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 102,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 42, milliseconds: 164),
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 20, milliseconds: 127),
new TimeSpan(days: 0, hours: 15, minutes: 58, seconds: 47, milliseconds: 204),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 108,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 52, milliseconds: 777),
new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 5, milliseconds: 672),
new TimeSpan(days: 0, hours: 18, minutes: 34, seconds: 8, milliseconds: 907),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 45, milliseconds: 383),
new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 8, milliseconds: 509),
new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 44, milliseconds: 22),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 44, milliseconds: 90),
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 45, milliseconds: 234),
new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 50, milliseconds: 32),
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 58, milliseconds: 811),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 115,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 2, milliseconds: 28),
new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 29, milliseconds: 530),
new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 15, milliseconds: 960),
new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 56, milliseconds: 658),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 117,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 7, milliseconds: 605),
new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 57, milliseconds: 57),
new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 36, milliseconds: 892),
new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 20, milliseconds: 105),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 53,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 9, milliseconds: 255),
new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 30, milliseconds: 762),
new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 18, milliseconds: 748),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 34, milliseconds: 803),
new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 58, milliseconds: 204),
new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 9, milliseconds: 74),
new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 7, milliseconds: 432),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 42, milliseconds: 704),
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 38, milliseconds: 818),
new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 5, milliseconds: 100),
},
},
            new TimeSpanintervalArray1M
{
    Id = 124,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 38, milliseconds: 52),
new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 39, milliseconds: 69),
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 12, milliseconds: 202),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 56, milliseconds: 171),
new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 20, milliseconds: 273),
new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 13, milliseconds: 439),
},
},
            new TimeSpanintervalArray1M
{
    Id = 126,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 33, milliseconds: 420),
new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 12, milliseconds: 432),
new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 41, milliseconds: 888),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 54, milliseconds: 91),
new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 9, milliseconds: 75),
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 55, milliseconds: 271),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 17, milliseconds: 669),
new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 52, milliseconds: 86),
new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 11, milliseconds: 62),
},
},
            new TimeSpanintervalArray1M
{
    Id = 128,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 0, milliseconds: 545),
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 8, milliseconds: 698),
new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 31, milliseconds: 81),
new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 6, milliseconds: 846),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 3, milliseconds: 917),
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 55, milliseconds: 899),
new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 33, milliseconds: 700),
new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 13, milliseconds: 914),
},
},
            new TimeSpanintervalArray1M
{
    Id = 137,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 25, milliseconds: 989),
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 3, milliseconds: 303),
new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 14, milliseconds: 587),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 10, milliseconds: 223),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 0, milliseconds: 208),
new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 13, milliseconds: 946),
new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 13, milliseconds: 805),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 143,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 38, milliseconds: 621),
new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 39, milliseconds: 41),
new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 2, milliseconds: 441),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 52, milliseconds: 381),
new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 51, milliseconds: 111),
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 46, milliseconds: 424),
},
},
            new TimeSpanintervalArray1M
{
    Id = 152,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 11, milliseconds: 128),
new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 123),
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 30, milliseconds: 545),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 68,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 57, milliseconds: 693),
new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 53, milliseconds: 151),
new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 40, milliseconds: 737),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 36, milliseconds: 98),
new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 55, milliseconds: 956),
new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 26, milliseconds: 339),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 153,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 43, milliseconds: 733),
new TimeSpan(days: 0, hours: 9, minutes: 3, seconds: 33, milliseconds: 904),
new TimeSpan(days: 0, hours: 22, minutes: 16, seconds: 45, milliseconds: 958),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 35, milliseconds: 91),
new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 17, milliseconds: 769),
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 47, milliseconds: 759),
},
},
            new TimeSpanintervalArray1M
{
    Id = 160,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 7, milliseconds: 621),
new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 26, milliseconds: 510),
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 55, milliseconds: 103),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 49, milliseconds: 714),
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 46, milliseconds: 834),
new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 38, milliseconds: 137),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 37, milliseconds: 328),
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 55, milliseconds: 504),
new TimeSpan(days: 0, hours: 18, minutes: 28, seconds: 1, milliseconds: 387),
new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 56, milliseconds: 974),
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
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 35, milliseconds: 69),
new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 58, milliseconds: 656),
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 2, milliseconds: 97),
}));
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 43, milliseconds: 214),
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 12, milliseconds: 822),
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 51, milliseconds: 736),
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
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 38, milliseconds: 453),
new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 54, milliseconds: 773),
new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 3, milliseconds: 834),
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 17, milliseconds: 388),
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
                parametr1.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 78;
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 58, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 124, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[2], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[3], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[4], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[5], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[6], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[23],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[24],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[25],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[26],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[27],_testData[29], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[6], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
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

