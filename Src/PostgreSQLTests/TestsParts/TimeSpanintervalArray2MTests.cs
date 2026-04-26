

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 27, milliseconds: 578),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 54, milliseconds: 165),

new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 42, milliseconds: 54),

new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 30, milliseconds: 411),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 37, milliseconds: 876),

new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 14, milliseconds: 697),

new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 47, milliseconds: 310),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 56, milliseconds: 6),

},
},
            new TimeSpanintervalArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 3, seconds: 11, milliseconds: 388),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 2, milliseconds: 887),

new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 1, milliseconds: 339),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 10, milliseconds: 616),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 28, milliseconds: 680),

new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 11, milliseconds: 616),

new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 28, milliseconds: 821),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 0, milliseconds: 219),

new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 33, milliseconds: 903),

new TimeSpan(days: 0, hours: 16, minutes: 19, seconds: 13, milliseconds: 717),

},
},
            new TimeSpanintervalArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 25, milliseconds: 483),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 9, milliseconds: 161),

new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 50, milliseconds: 607),

new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 1, milliseconds: 473),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 37, seconds: 51, milliseconds: 618),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 30, milliseconds: 218),

new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 41, milliseconds: 186),

},
},
            new TimeSpanintervalArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 37, milliseconds: 480),

new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 52, milliseconds: 773),

new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 4, milliseconds: 184),

new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 32, milliseconds: 149),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 30, milliseconds: 921),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 5, milliseconds: 646),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 48, milliseconds: 9),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 44, milliseconds: 558),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 24, milliseconds: 981),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 44, milliseconds: 813),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 43, milliseconds: 609),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 45, milliseconds: 843),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 46, milliseconds: 793),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 19, milliseconds: 612),

},
},
            new TimeSpanintervalArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 23, milliseconds: 581),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 2, milliseconds: 513),

new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 38, milliseconds: 242),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 18, milliseconds: 679),

new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 52, milliseconds: 828),

new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 25, milliseconds: 897),

},
},
            new TimeSpanintervalArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 12, milliseconds: 158),

new TimeSpan(days: 0, hours: 11, minutes: 8, seconds: 16, milliseconds: 207),

new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 25, milliseconds: 7),

new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 49, milliseconds: 991),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 55, milliseconds: 644),

new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 24, milliseconds: 883),

new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 52, milliseconds: 321),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 32, milliseconds: 581),

new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 37, milliseconds: 989),

new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 49, milliseconds: 452),

new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 19, milliseconds: 319),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 53, milliseconds: 741),

new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 8, milliseconds: 740),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 27, milliseconds: 235),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 39, milliseconds: 570),

new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 47, milliseconds: 632),

new TimeSpan(days: 0, hours: 16, minutes: 29, seconds: 34, milliseconds: 817),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 44, milliseconds: 419),

new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 52, milliseconds: 907),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 53, milliseconds: 716),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 24, milliseconds: 878),

new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 3, milliseconds: 202),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 55, milliseconds: 243),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 28, seconds: 3, milliseconds: 534),

new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 19, milliseconds: 571),

new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 57, milliseconds: 804),

},
},
            new TimeSpanintervalArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 56, milliseconds: 895),

new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 42, milliseconds: 814),

new TimeSpan(days: 0, hours: 10, minutes: 30, seconds: 12, milliseconds: 190),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 32, seconds: 34, milliseconds: 912),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 16, milliseconds: 737),

new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 14, milliseconds: 931),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 1, milliseconds: 901),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 53, milliseconds: 747),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 14, milliseconds: 139),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 22, milliseconds: 419),

new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 20, milliseconds: 599),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 32, milliseconds: 430),

new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 35, milliseconds: 279),

new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 29, milliseconds: 204),

new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 3, milliseconds: 947),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 19, milliseconds: 743),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 34, milliseconds: 732),

new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 49, milliseconds: 118),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 19, milliseconds: 646),

new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 50, milliseconds: 797),

new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 47, milliseconds: 502),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 5, milliseconds: 25),

new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 46, milliseconds: 421),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 1, milliseconds: 208),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 4, milliseconds: 928),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 32, milliseconds: 710),

new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 52, milliseconds: 386),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 50, milliseconds: 410),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 50, milliseconds: 343),

new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 781),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 54, milliseconds: 536),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 52, milliseconds: 326),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 28, milliseconds: 52),

new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 44, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 51, milliseconds: 708),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 54, milliseconds: 996),

new TimeSpan(days: 0, hours: 6, minutes: 52, seconds: 42, milliseconds: 289),

new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 12, milliseconds: 401),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 55, milliseconds: 442),

new TimeSpan(days: 0, hours: 16, minutes: 29, seconds: 26, milliseconds: 366),

new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 649),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 3, milliseconds: 525),

new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 55, milliseconds: 935),

new TimeSpan(days: 0, hours: 10, minutes: 53, seconds: 43, milliseconds: 539),

new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 22, milliseconds: 693),

},
},
            new TimeSpanintervalArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 16, milliseconds: 722),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 7, milliseconds: 130),

new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 46, milliseconds: 974),

new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 22, milliseconds: 882),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 1, milliseconds: 947),

new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 18, milliseconds: 39),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 27, milliseconds: 511),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 32, milliseconds: 546),

new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 51, milliseconds: 943),

new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 17, milliseconds: 165),

new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 43, milliseconds: 983),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 34, milliseconds: 284),

new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 54, milliseconds: 883),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 17, milliseconds: 73),

new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 38, milliseconds: 30),

},
},
            new TimeSpanintervalArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 40, milliseconds: 964),

new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 40, milliseconds: 736),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 3, milliseconds: 600),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 23, milliseconds: 106),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 31, milliseconds: 643),

new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 57, milliseconds: 162),

new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 8, milliseconds: 620),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 15, milliseconds: 186),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 28, milliseconds: 422),

new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 46, milliseconds: 40),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 25, milliseconds: 78),

new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 1, milliseconds: 262),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 33, milliseconds: 87),

new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 38, milliseconds: 319),

},
},
            new TimeSpanintervalArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 13, milliseconds: 3),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 11, milliseconds: 817),

new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 58, milliseconds: 390),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 18, milliseconds: 109),

new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 26, milliseconds: 414),

new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 52, milliseconds: 908),

},
},
            new TimeSpanintervalArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 58, milliseconds: 673),

new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 4, milliseconds: 729),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 4, milliseconds: 13),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 23, milliseconds: 597),

new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 55, milliseconds: 83),

new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 8, milliseconds: 684),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 48, milliseconds: 759),

new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 18, milliseconds: 669),

new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 57, milliseconds: 546),

new TimeSpan(days: 0, hours: 22, minutes: 10, seconds: 25, milliseconds: 254),

},
},
            new TimeSpanintervalArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 23, milliseconds: 993),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 4, milliseconds: 530),

new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 29, milliseconds: 880),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 15, milliseconds: 371),

new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 44, milliseconds: 589),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 13, milliseconds: 748),

new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 14, milliseconds: 330),

},
},
            new TimeSpanintervalArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 30, milliseconds: 895),

new TimeSpan(days: 0, hours: 21, minutes: 15, seconds: 7, milliseconds: 1),

new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 47, milliseconds: 416),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 17, milliseconds: 533),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 26, milliseconds: 324),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 42, milliseconds: 769),

new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 24, milliseconds: 608),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 3, milliseconds: 430),

new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 18, milliseconds: 425),

new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 15, milliseconds: 406),

new TimeSpan(days: 0, hours: 16, minutes: 54, seconds: 17, milliseconds: 832),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 14, milliseconds: 736),

new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 0, milliseconds: 231),

new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 52, milliseconds: 807),

new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 13, milliseconds: 344),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 18, milliseconds: 627),

new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 46, milliseconds: 541),

new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 40, milliseconds: 688),

},
},
            new TimeSpanintervalArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 26, milliseconds: 888),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 34, milliseconds: 156),

new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 51, milliseconds: 296),

new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 4, milliseconds: 297),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 13, milliseconds: 425),

new TimeSpan(days: 0, hours: 19, minutes: 3, seconds: 9, milliseconds: 616),

new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 30, milliseconds: 897),

new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 58, milliseconds: 770),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 43, milliseconds: 712),

new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 54, milliseconds: 79),

new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 14, milliseconds: 953),

},
},
            new TimeSpanintervalArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 52, milliseconds: 284),

new TimeSpan(days: 0, hours: 2, minutes: 22, seconds: 58, milliseconds: 568),

new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 26, milliseconds: 793),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 45, milliseconds: 140),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 45, milliseconds: 181),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 36, milliseconds: 120),

new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 20, milliseconds: 781),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 31, milliseconds: 886),

new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 32, milliseconds: 245),

new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 32, milliseconds: 437),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 28, milliseconds: 685),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 37, milliseconds: 663),

new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 4, milliseconds: 986),

},
},
            new TimeSpanintervalArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 3, milliseconds: 898),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 11, milliseconds: 510),

new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 30, milliseconds: 10),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 36, milliseconds: 990),

new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 30, milliseconds: 857),

new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 28, milliseconds: 386),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 32, milliseconds: 728),

},
},
            new TimeSpanintervalArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 35, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 47, milliseconds: 382),

new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 55, milliseconds: 488),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 2, milliseconds: 678),

new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 11, milliseconds: 109),

new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 52, milliseconds: 733),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 29, milliseconds: 676),

new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 32, milliseconds: 294),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 21, milliseconds: 793),

},
},
            new TimeSpanintervalArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 7, milliseconds: 370),

new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 3, milliseconds: 329),

new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 31, milliseconds: 353),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 16, milliseconds: 342),

new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 8, milliseconds: 733),

new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 25, milliseconds: 196),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 10, milliseconds: 836),

},
},
            new TimeSpanintervalArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 42, milliseconds: 701),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 12, milliseconds: 781),

new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 20, milliseconds: 437),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 18, milliseconds: 536),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 11, milliseconds: 118),

new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 15, milliseconds: 774),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 24, milliseconds: 597),

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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeSpanListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((ITimeSpanListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((ITimeSpanListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[8], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[9], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[10], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[11], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[12], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[13], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[14], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[15], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[16], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[17], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[11], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[12], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[13], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[14], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[15], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[16], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[17], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[29], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[5], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[6], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[23],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
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

                var models =  ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
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
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[13], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[14], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[15], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[16], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[17], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 158, 150))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
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
                var models =  ((ITimeSpanListintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatch(connection, 51, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);
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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeSpanListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(actual, expect, false);
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
                await ((ITimeSpanListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeSpanListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(TimeSpanintervalArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray2M>(15);

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
                ((ITimeSpanListintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeSpanintervalArray2M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray2M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray2M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray2M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray2M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray2M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray2M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray2M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray2M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray2M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray2M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray2M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray2M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray2M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeSpanListintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeSpanListintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeSpanintervalArray2M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray2M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray2M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray2M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray2M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray2M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray2M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray2M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray2M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray2M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray2M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray2M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray2M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray2M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray2M.AssertModel(models[14],_testData[14], false);
                TimeSpanintervalArray2M.AssertModel(models[15],_testData[15], false);
                TimeSpanintervalArray2M.AssertModel(models[16],_testData[16], false);
                TimeSpanintervalArray2M.AssertModel(models[17],_testData[17], false);
                TimeSpanintervalArray2M.AssertModel(models[18],_testData[18], false);
                TimeSpanintervalArray2M.AssertModel(models[19],_testData[19], false);
                TimeSpanintervalArray2M.AssertModel(models[20],_testData[20], false);
                TimeSpanintervalArray2M.AssertModel(models[21],_testData[21], false);
                TimeSpanintervalArray2M.AssertModel(models[22],_testData[22], false);
                TimeSpanintervalArray2M.AssertModel(models[23],_testData[23], false);
                TimeSpanintervalArray2M.AssertModel(models[24],_testData[24], false);
                TimeSpanintervalArray2M.AssertModel(models[25],_testData[25], false);
                TimeSpanintervalArray2M.AssertModel(models[26],_testData[26], false);
                TimeSpanintervalArray2M.AssertModel(models[27],_testData[27], false);
                TimeSpanintervalArray2M.AssertModel(models[28],_testData[28], false);
                TimeSpanintervalArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_timespanintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanListintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

