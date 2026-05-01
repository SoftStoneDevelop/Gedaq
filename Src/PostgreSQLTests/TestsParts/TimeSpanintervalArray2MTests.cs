

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
    internal partial interface ITimeSpanListintervalArray
    {
    }
    
    internal partial class TimeSpanListintervalArray : ITimeSpanListintervalArray
    {


#region TestData

        private readonly TimeSpanintervalArray2M[] _testData = new TimeSpanintervalArray2M[]
        {
            new TimeSpanintervalArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 3, milliseconds: 670),

new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 55, milliseconds: 115),

new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 1, milliseconds: 585),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 40, milliseconds: 752),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 35, milliseconds: 570),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 8, milliseconds: 935),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 43, milliseconds: 102),

},
},
            new TimeSpanintervalArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 50, milliseconds: 401),

new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 57, milliseconds: 294),

new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 11, milliseconds: 130),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 28, milliseconds: 497),

new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 0, milliseconds: 4),

new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 55, milliseconds: 413),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 11, milliseconds: 443),

new TimeSpan(days: 0, hours: 4, minutes: 30, seconds: 8, milliseconds: 52),

new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 7, milliseconds: 273),

new TimeSpan(days: 0, hours: 15, minutes: 18, seconds: 31, milliseconds: 179),

},
},
            new TimeSpanintervalArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 1, milliseconds: 814),

new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 4, milliseconds: 634),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 11, milliseconds: 507),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 53, milliseconds: 152),

new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 43, milliseconds: 454),

new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 39, milliseconds: 664),

},
},
            new TimeSpanintervalArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 25, milliseconds: 451),

new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 39, milliseconds: 310),

new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 46, milliseconds: 33),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 51, milliseconds: 505),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 47, milliseconds: 211),

new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 4, milliseconds: 140),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 43, milliseconds: 930),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 18, milliseconds: 703),

new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 47, milliseconds: 701),

new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 20, milliseconds: 869),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 23, milliseconds: 6),

new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 39, milliseconds: 356),

new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 46, milliseconds: 208),

},
},
            new TimeSpanintervalArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 58, milliseconds: 133),

new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 20, milliseconds: 470),

new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 47, milliseconds: 857),

new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 9, milliseconds: 868),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 10, milliseconds: 138),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 7, milliseconds: 170),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 30, milliseconds: 402),

},
},
            new TimeSpanintervalArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 6, milliseconds: 468),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 14, milliseconds: 774),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 48, milliseconds: 229),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 39, milliseconds: 35),

new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 33, milliseconds: 154),

new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 44, milliseconds: 767),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 15, milliseconds: 311),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 19, milliseconds: 674),

new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 9, milliseconds: 895),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 2, milliseconds: 567),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 31, milliseconds: 74),

new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 42, milliseconds: 80),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 50, milliseconds: 913),

new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 18, milliseconds: 22),

},
},
            new TimeSpanintervalArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 30, milliseconds: 267),

new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 28, milliseconds: 364),

new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 12, milliseconds: 562),

new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 46, milliseconds: 388),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 43, milliseconds: 431),

new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 29, milliseconds: 248),

new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 19, milliseconds: 277),

},
},
            new TimeSpanintervalArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 2, milliseconds: 825),

new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 36, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 38, seconds: 51, milliseconds: 501),

new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 58, milliseconds: 402),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 26, milliseconds: 372),

new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 35, milliseconds: 993),

new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 17, milliseconds: 998),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 42, milliseconds: 973),

new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 30, milliseconds: 994),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 0, milliseconds: 347),

},
},
            new TimeSpanintervalArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 6, milliseconds: 53),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 0, milliseconds: 612),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 27, milliseconds: 97),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 37, milliseconds: 26),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 29, milliseconds: 29),

new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 3, milliseconds: 912),

new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 0, milliseconds: 165),

},
},
            new TimeSpanintervalArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 30, milliseconds: 739),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 15, milliseconds: 336),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 624),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 17, milliseconds: 475),

new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 10, milliseconds: 711),

new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 55, milliseconds: 570),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 4, milliseconds: 563),

new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 11, milliseconds: 145),

new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 6, milliseconds: 110),

},
},
            new TimeSpanintervalArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 40, milliseconds: 875),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 16, milliseconds: 205),

new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 47, milliseconds: 563),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 47, milliseconds: 234),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 55, milliseconds: 801),

new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 9, milliseconds: 628),

},
},
            new TimeSpanintervalArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 56, milliseconds: 691),

new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 41, milliseconds: 96),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 45, milliseconds: 199),

new TimeSpan(days: 0, hours: 20, minutes: 53, seconds: 20, milliseconds: 400),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 55, seconds: 18, milliseconds: 913),

new TimeSpan(days: 0, hours: 19, minutes: 49, seconds: 45, milliseconds: 869),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 1, milliseconds: 624),

new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 38, milliseconds: 478),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 38, milliseconds: 849),

new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 22, milliseconds: 823),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 37, milliseconds: 155),

},
},
            new TimeSpanintervalArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 36, seconds: 50, milliseconds: 548),

new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 16, milliseconds: 554),

new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 30, milliseconds: 266),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 18, seconds: 19, milliseconds: 697),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 27, milliseconds: 324),

new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 47, milliseconds: 495),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 6, milliseconds: 321),

new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 45, milliseconds: 817),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 44, milliseconds: 303),

new TimeSpan(days: 0, hours: 14, minutes: 38, seconds: 27, milliseconds: 615),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 49, milliseconds: 300),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 15, milliseconds: 459),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 35, milliseconds: 366),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 51, milliseconds: 966),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 22, milliseconds: 188),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 45, milliseconds: 544),

new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 44, milliseconds: 168),

},
},
            new TimeSpanintervalArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 58, milliseconds: 755),

new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 16, milliseconds: 552),

new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 6, milliseconds: 262),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 55, milliseconds: 972),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 41, milliseconds: 871),

new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 10, milliseconds: 462),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 10, milliseconds: 148),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 52, milliseconds: 833),

new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 36, milliseconds: 444),

new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 31, milliseconds: 953),

new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 57, milliseconds: 809),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 18, milliseconds: 885),

new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 30, milliseconds: 794),

new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 58, milliseconds: 182),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 51, milliseconds: 151),

new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 24, milliseconds: 843),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 21, milliseconds: 795),

},
},
            new TimeSpanintervalArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 39, milliseconds: 456),

new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 37, milliseconds: 424),

new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 29, milliseconds: 76),

new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 57, milliseconds: 972),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 40, milliseconds: 66),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 6, milliseconds: 95),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 37, milliseconds: 762),

new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 28, milliseconds: 254),

},
},
            new TimeSpanintervalArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 5, milliseconds: 833),

new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 8, milliseconds: 646),

new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 12, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 44, milliseconds: 235),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 23, milliseconds: 796),

new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 48, milliseconds: 227),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 16, milliseconds: 666),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 13, milliseconds: 456),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 0, milliseconds: 698),

new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 33, milliseconds: 476),

new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 25, milliseconds: 569),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 55, milliseconds: 359),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 22, milliseconds: 6),

new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 58, milliseconds: 962),

new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 32, milliseconds: 12),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 5, milliseconds: 896),

},
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 15, milliseconds: 184),

new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 49, milliseconds: 10),

new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 36, milliseconds: 411),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 39, milliseconds: 89),

new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 5, milliseconds: 210),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 38, milliseconds: 320),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 48, milliseconds: 968),

new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 38, milliseconds: 407),

new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 35, milliseconds: 413),

new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 42, milliseconds: 767),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 34, seconds: 34, milliseconds: 722),

new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 28, milliseconds: 359),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 47, milliseconds: 516),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 0, milliseconds: 186),

new TimeSpan(days: 0, hours: 16, minutes: 19, seconds: 37, milliseconds: 20),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 52, milliseconds: 21),

new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 36, milliseconds: 947),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 15, milliseconds: 213),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 45, milliseconds: 607),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 54, milliseconds: 558),

new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 7, milliseconds: 848),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 18, milliseconds: 857),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 47, milliseconds: 729),

new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 47, milliseconds: 723),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 14, milliseconds: 977),

new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 53, milliseconds: 746),

new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 36, milliseconds: 113),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 33, milliseconds: 321),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 5, milliseconds: 896),

new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 14, milliseconds: 331),

},
},
            new TimeSpanintervalArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 37, milliseconds: 871),

new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 56, milliseconds: 609),

new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 30, milliseconds: 442),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 41, milliseconds: 530),

new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 25, milliseconds: 86),

new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 36, milliseconds: 858),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 9, milliseconds: 898),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 53, milliseconds: 521),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 56, milliseconds: 868),

new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 23, milliseconds: 422),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 45, milliseconds: 153),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 22, milliseconds: 459),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 18, milliseconds: 589),

new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 45, milliseconds: 642),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 28, seconds: 42, milliseconds: 311),

new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 52, milliseconds: 818),

new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 15, milliseconds: 409),

},
},
            new TimeSpanintervalArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 22, milliseconds: 933),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 35, milliseconds: 485),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 53, milliseconds: 513),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 58, milliseconds: 219),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 32, milliseconds: 314),

new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 36, milliseconds: 88),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 54, milliseconds: 10),

new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 32, milliseconds: 886),

new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 41, milliseconds: 934),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 0, milliseconds: 512),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 32, milliseconds: 671),

new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 15, milliseconds: 151),

},
},
            new TimeSpanintervalArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 14, milliseconds: 547),

new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 6, milliseconds: 203),

new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 22, milliseconds: 272),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 44, milliseconds: 604),

new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 20, milliseconds: 522),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 32, milliseconds: 797),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 47, milliseconds: 349),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 8, milliseconds: 903),

new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 11, milliseconds: 295),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 18, milliseconds: 713),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 48, seconds: 9, milliseconds: 40),

new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 41, milliseconds: 473),

new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 4, milliseconds: 261),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 19, milliseconds: 517),

new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 5, milliseconds: 719),

new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 7, milliseconds: 64),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 34, milliseconds: 325),

},
},
            new TimeSpanintervalArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 25, milliseconds: 753),

new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 9, milliseconds: 205),

new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 26, milliseconds: 514),

new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 35, milliseconds: 574),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 34, milliseconds: 864),

new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 44, milliseconds: 906),

new TimeSpan(days: 0, hours: 11, minutes: 28, seconds: 56, milliseconds: 19),

},
},
            new TimeSpanintervalArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 36, milliseconds: 735),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 35, milliseconds: 23),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 520),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 26, milliseconds: 826),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 51, milliseconds: 466),

new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 57, milliseconds: 203),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 27, milliseconds: 504),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 5, seconds: 0, milliseconds: 306),

new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 0, milliseconds: 745),

new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 58, milliseconds: 635),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 17, milliseconds: 425),

},
},
            new TimeSpanintervalArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 29, milliseconds: 951),

new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 54, milliseconds: 344),

new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 13, milliseconds: 78),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 1, milliseconds: 945),

new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 0, milliseconds: 792),

new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 55, milliseconds: 294),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 55, milliseconds: 453),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 22, milliseconds: 931),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 17, milliseconds: 452),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 21, milliseconds: 176),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 46, milliseconds: 634),

new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 49, milliseconds: 997),

new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 14, milliseconds: 5),

},
},
            new TimeSpanintervalArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 292),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 58, milliseconds: 478),

new TimeSpan(days: 0, hours: 15, minutes: 45, seconds: 36, milliseconds: 472),

new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 16, milliseconds: 459),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 44, milliseconds: 934),

new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 3, milliseconds: 47),

new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 4, milliseconds: 803),

},
},
            new TimeSpanintervalArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 5, milliseconds: 617),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 13, milliseconds: 85),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 47, milliseconds: 145),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 38, milliseconds: 858),

new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 26, milliseconds: 831),

new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 16, milliseconds: 355),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 39, milliseconds: 782),

new TimeSpan(days: 0, hours: 19, minutes: 3, seconds: 54, milliseconds: 648),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 22, milliseconds: 896),

},
},
            new TimeSpanintervalArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 8, milliseconds: 30),

new TimeSpan(days: 0, hours: 14, minutes: 24, seconds: 46, milliseconds: 597),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 20, milliseconds: 328),

new TimeSpan(days: 0, hours: 16, minutes: 19, seconds: 3, milliseconds: 543),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 55, milliseconds: 455),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 5, milliseconds: 713),

new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 2, milliseconds: 399),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2mi(
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2mi(
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
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
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

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanListintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanListintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2m(
	id,
    value,
    nullablevalue,
    timespanintervalarray2mi_id
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
            asPartInterface: typeof(ITimeSpanListintervalArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray2mi_id", 
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
                changedRows =  ((ITimeSpanListintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanListintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2m(
	id,
    value,
    nullablevalue,
    timespanintervalarray2mi_id
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
    timespanintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2m(
	id,
    value,
    nullablevalue,
    timespanintervalarray2mi_id
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
    timespanintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray2M> models = null;

                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray2M> models = null;

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M), typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                ((ITimeSpanListintervalArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await ((ITimeSpanListintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M), typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                ((ITimeSpanListintervalArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await ((ITimeSpanListintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M), typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                await((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[28],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[29],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[30],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[31],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[32],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M), typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                await((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 140, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray2M>();
                var models2 = new List<FlatTimeSpanintervalArray2M>();
                ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 135, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[28],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[29],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[30],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[31],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[32],_testData[34], false);
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
FROM public.timespanintervalarray2m m
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
FROM public.timespanintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray2M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray2M>();
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await((ITimeSpanListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((ITimeSpanListintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 85, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[5], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[25],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[26],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[27],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[28],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                TimeSpanintervalArray2M.AssertModel(models[0],_testData[17], false);
                TimeSpanintervalArray2M.AssertModel(models[1],_testData[18], false);
                TimeSpanintervalArray2M.AssertModel(models[2],_testData[19], false);
                TimeSpanintervalArray2M.AssertModel(models[3],_testData[20], false);
                TimeSpanintervalArray2M.AssertModel(models[4],_testData[21], false);
                TimeSpanintervalArray2M.AssertModel(models[5],_testData[22], false);
                TimeSpanintervalArray2M.AssertModel(models[6],_testData[23], false);
                TimeSpanintervalArray2M.AssertModel(models[7],_testData[24], false);
                TimeSpanintervalArray2M.AssertModel(models[8],_testData[25], false);
                TimeSpanintervalArray2M.AssertModel(models[9],_testData[26], false);
                TimeSpanintervalArray2M.AssertModel(models[10],_testData[27], false);
                TimeSpanintervalArray2M.AssertModel(models[11],_testData[28], false);
                TimeSpanintervalArray2M.AssertModel(models[12],_testData[29], false);
                TimeSpanintervalArray2M.AssertModel(models[13],_testData[30], false);
                TimeSpanintervalArray2M.AssertModel(models[14],_testData[31], false);
                TimeSpanintervalArray2M.AssertModel(models[15],_testData[32], false);
                TimeSpanintervalArray2M.AssertModel(models[16],_testData[33], false);
                TimeSpanintervalArray2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                TimeSpanintervalArray2M.AssertModel(models[0],_testData[1], false);
                TimeSpanintervalArray2M.AssertModel(models[1],_testData[2], false);
                TimeSpanintervalArray2M.AssertModel(models[2],_testData[3], false);
                TimeSpanintervalArray2M.AssertModel(models[3],_testData[4], false);
                TimeSpanintervalArray2M.AssertModel(models[4],_testData[5], false);
                TimeSpanintervalArray2M.AssertModel(models[5],_testData[6], false);
                TimeSpanintervalArray2M.AssertModel(models[6],_testData[7], false);
                TimeSpanintervalArray2M.AssertModel(models[7],_testData[8], false);
                TimeSpanintervalArray2M.AssertModel(models[8],_testData[9], false);
                TimeSpanintervalArray2M.AssertModel(models[9],_testData[10], false);
                TimeSpanintervalArray2M.AssertModel(models[10],_testData[11], false);
                TimeSpanintervalArray2M.AssertModel(models[11],_testData[12], false);
                TimeSpanintervalArray2M.AssertModel(models[12],_testData[13], false);
                TimeSpanintervalArray2M.AssertModel(models[13],_testData[14], false);
                TimeSpanintervalArray2M.AssertModel(models[14],_testData[15], false);
                TimeSpanintervalArray2M.AssertModel(models[15],_testData[16], false);
                TimeSpanintervalArray2M.AssertModel(models[16],_testData[17], false);
                TimeSpanintervalArray2M.AssertModel(models[17],_testData[18], false);
                TimeSpanintervalArray2M.AssertModel(models[18],_testData[19], false);
                TimeSpanintervalArray2M.AssertModel(models[19],_testData[20], false);
                TimeSpanintervalArray2M.AssertModel(models[20],_testData[21], false);
                TimeSpanintervalArray2M.AssertModel(models[21],_testData[22], false);
                TimeSpanintervalArray2M.AssertModel(models[22],_testData[23], false);
                TimeSpanintervalArray2M.AssertModel(models[23],_testData[24], false);
                TimeSpanintervalArray2M.AssertModel(models[24],_testData[25], false);
                TimeSpanintervalArray2M.AssertModel(models[25],_testData[26], false);
                TimeSpanintervalArray2M.AssertModel(models[26],_testData[27], false);
                TimeSpanintervalArray2M.AssertModel(models[27],_testData[28], false);
                TimeSpanintervalArray2M.AssertModel(models[28],_testData[29], false);
                TimeSpanintervalArray2M.AssertModel(models[29],_testData[30], false);
                TimeSpanintervalArray2M.AssertModel(models[30],_testData[31], false);
                TimeSpanintervalArray2M.AssertModel(models[31],_testData[32], false);
                TimeSpanintervalArray2M.AssertModel(models[32],_testData[33], false);
                TimeSpanintervalArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MIWA),
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
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanListintervalArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanListintervalArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MI),
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
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanListintervalArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanListintervalArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
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
            asPartInterface: typeof(ITimeSpanListintervalArray))]
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
FROM public.binary_timespanintervalarray2m m
LEFT JOIN public.binary_timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanListintervalArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanListintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models =  ((ITimeSpanListintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA), typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                await ((ITimeSpanListintervalArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                ((ITimeSpanListintervalArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await ((ITimeSpanListintervalArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray2mi
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
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalarray2mi
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
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA), typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                await ((ITimeSpanListintervalArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                ((ITimeSpanListintervalArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
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
                var models = await ((ITimeSpanListintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray2mi
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
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalarray2mi
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
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI), typeof(TimeSpanintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray2MI>();
                var models2 = new List<TimeSpanintervalArray2MI>();
                await ((ITimeSpanListintervalArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray2MI>();
                var models2 = new List<TimeSpanintervalArray2MI>();
                ((ITimeSpanListintervalArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
                var models = await ((ITimeSpanListintervalArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA), typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                await ((ITimeSpanListintervalArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray2MIWA>();
                var models2 = new List<TimeSpanintervalArray2MIWA>();
                ((ITimeSpanListintervalArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
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
                var models = await ((ITimeSpanListintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

