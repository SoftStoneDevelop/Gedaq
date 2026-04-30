

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 54, milliseconds: 313),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 47, milliseconds: 867),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 8, milliseconds: 124),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 55, milliseconds: 286),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 40, milliseconds: 768),

new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 3, milliseconds: 666),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 46, milliseconds: 425),

new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 24, milliseconds: 505),

new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 48, milliseconds: 135),

new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 55, milliseconds: 353),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 43, milliseconds: 58),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 35, milliseconds: 949),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 22, milliseconds: 511),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 58, milliseconds: 94),

new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 27, milliseconds: 18),

new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 44, milliseconds: 13),

new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 36, milliseconds: 997),

},
},
            new TimeSpanintervalArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 31, milliseconds: 8),

new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 2, milliseconds: 572),

new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 28, milliseconds: 186),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 1, milliseconds: 451),

new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 12, milliseconds: 972),

new TimeSpan(days: 0, hours: 18, minutes: 22, seconds: 37, milliseconds: 188),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 35, milliseconds: 670),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 31, milliseconds: 798),

new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 0, milliseconds: 638),

new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 3, milliseconds: 486),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 28, milliseconds: 173),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 58, milliseconds: 920),

new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 45, milliseconds: 617),

new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 24, milliseconds: 426),

},
},
            new TimeSpanintervalArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 0, milliseconds: 609),

new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 27, milliseconds: 137),

new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 33, milliseconds: 338),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 47, milliseconds: 970),

new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 54, milliseconds: 366),

new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 14, milliseconds: 639),

new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 34, milliseconds: 840),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 14, milliseconds: 128),

new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 17, milliseconds: 779),

new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 42, milliseconds: 818),

new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 47, milliseconds: 500),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 35, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 15, milliseconds: 463),

new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 19, milliseconds: 717),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 28, milliseconds: 38),

new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 35, milliseconds: 308),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 52, milliseconds: 519),

},
},
            new TimeSpanintervalArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 34, milliseconds: 259),

new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 14, milliseconds: 551),

new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 55, milliseconds: 347),

new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 43, milliseconds: 400),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 11, milliseconds: 303),

new TimeSpan(days: 0, hours: 8, minutes: 11, seconds: 58, milliseconds: 24),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 32, milliseconds: 462),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 36, milliseconds: 540),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 29, milliseconds: 954),

new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 44, milliseconds: 781),

new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 37, milliseconds: 138),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 57, milliseconds: 326),

new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 51, milliseconds: 643),

new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 7, milliseconds: 910),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 54, milliseconds: 595),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 19, milliseconds: 470),

new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 57, milliseconds: 917),

new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 53, milliseconds: 421),

},
},
            new TimeSpanintervalArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 14, milliseconds: 797),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 14, milliseconds: 613),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 39, milliseconds: 970),

new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 3, milliseconds: 585),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 47, milliseconds: 32),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 51, milliseconds: 298),

new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 54, milliseconds: 443),

new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 2, milliseconds: 825),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 12, milliseconds: 45),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 33, milliseconds: 285),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 43, milliseconds: 378),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 20, milliseconds: 138),

new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 9, milliseconds: 802),

new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 14, milliseconds: 279),

new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 31, milliseconds: 497),

},
},
            new TimeSpanintervalArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 11, milliseconds: 282),

new TimeSpan(days: 0, hours: 12, minutes: 26, seconds: 58, milliseconds: 421),

new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 19, milliseconds: 840),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 41, milliseconds: 596),

new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 44, milliseconds: 888),

new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 35, milliseconds: 974),

new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 52, milliseconds: 856),

},
},
            new TimeSpanintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 12, milliseconds: 27),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 4, milliseconds: 561),

new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 37, milliseconds: 353),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 23, milliseconds: 269),

new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 44, milliseconds: 583),

new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 23, milliseconds: 931),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 34, milliseconds: 639),

new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 38, milliseconds: 682),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 38, milliseconds: 788),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 24, milliseconds: 115),

new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 49, milliseconds: 349),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 35, milliseconds: 242),

new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 17, milliseconds: 750),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 54, milliseconds: 933),

new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 40, milliseconds: 835),

new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 56, milliseconds: 784),

new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 32, milliseconds: 925),

},
},
            new TimeSpanintervalArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 47, milliseconds: 171),

new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 10, milliseconds: 282),

new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 20, milliseconds: 83),

new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 26, milliseconds: 149),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 19, milliseconds: 726),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 54, milliseconds: 127),

new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 26, milliseconds: 383),

new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 49, milliseconds: 376),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 6, milliseconds: 704),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 23, milliseconds: 430),

new TimeSpan(days: 0, hours: 22, minutes: 35, seconds: 28, milliseconds: 440),

new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 9, milliseconds: 178),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 27, milliseconds: 672),

new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 18, milliseconds: 406),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 37, milliseconds: 786),

new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 1, milliseconds: 109),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 12, milliseconds: 908),

new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 3, milliseconds: 766),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 11, milliseconds: 613),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 6, milliseconds: 845),

new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 16, milliseconds: 524),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 54, milliseconds: 472),

new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 50, milliseconds: 367),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 47, milliseconds: 96),

new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 36, milliseconds: 938),

new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 52, milliseconds: 971),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 2, milliseconds: 837),

new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 4, milliseconds: 505),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 10, milliseconds: 450),

new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 27, milliseconds: 38),

},
},
            new TimeSpanintervalArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 0, milliseconds: 498),

new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 36, milliseconds: 358),

new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 32, milliseconds: 491),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 51, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 53, milliseconds: 170),

new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 24, milliseconds: 218),

new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 19, milliseconds: 268),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 0, milliseconds: 766),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 8, milliseconds: 165),

new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 49, milliseconds: 575),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 13, milliseconds: 820),

new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 50, milliseconds: 595),

new TimeSpan(days: 0, hours: 15, minutes: 21, seconds: 0, milliseconds: 826),

new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 11, milliseconds: 153),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 45, milliseconds: 38),

new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 46, milliseconds: 873),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 34, milliseconds: 364),

new TimeSpan(days: 0, hours: 3, minutes: 38, seconds: 11, milliseconds: 331),

},
},
            new TimeSpanintervalArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 9, milliseconds: 181),

new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 29, milliseconds: 216),

new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 43, milliseconds: 908),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 40, milliseconds: 89),

new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 3, milliseconds: 977),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 15, milliseconds: 357),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 36, milliseconds: 170),

},
},
            new TimeSpanintervalArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 7, milliseconds: 129),

new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 58, milliseconds: 246),

new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 12, milliseconds: 186),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 49, milliseconds: 911),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 16, milliseconds: 205),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 3, milliseconds: 346),

new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 34, milliseconds: 650),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 6, milliseconds: 770),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 19, milliseconds: 519),

new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 20, milliseconds: 275),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 38, milliseconds: 784),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 23, milliseconds: 939),

new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 42, milliseconds: 473),

new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 48, milliseconds: 672),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 11, milliseconds: 881),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 48, milliseconds: 294),

new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 52, milliseconds: 750),

new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 34, milliseconds: 457),

new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 34, milliseconds: 327),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 42, milliseconds: 639),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 0, milliseconds: 209),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 36, milliseconds: 237),

new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 3, milliseconds: 881),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 41, milliseconds: 912),

new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 15, milliseconds: 976),

new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 39, milliseconds: 371),

new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 17, milliseconds: 830),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 30, milliseconds: 507),

new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 56, milliseconds: 439),

new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 9, milliseconds: 784),

new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 52, milliseconds: 149),

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
new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 39, milliseconds: 436),

new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 23, milliseconds: 838),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 57, milliseconds: 655),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 314),

new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 23, milliseconds: 788),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 5, milliseconds: 227),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 50, milliseconds: 682),

new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 22, milliseconds: 478),

new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 5, milliseconds: 183),

new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 9, milliseconds: 816),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 32, milliseconds: 504),

new TimeSpan(days: 0, hours: 22, minutes: 50, seconds: 21, milliseconds: 340),

new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 32, milliseconds: 579),

},
},
            new TimeSpanintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 38, milliseconds: 307),

new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 41, milliseconds: 166),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 10, milliseconds: 938),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 23, milliseconds: 816),

new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 52, milliseconds: 499),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 35, milliseconds: 669),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 10, milliseconds: 255),

new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 39, milliseconds: 459),

new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 6, milliseconds: 48),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 45, milliseconds: 363),

new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 27, milliseconds: 731),

new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 17, milliseconds: 547),

new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 29, milliseconds: 721),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 30, milliseconds: 14),

new TimeSpan(days: 0, hours: 3, minutes: 38, seconds: 18, milliseconds: 224),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 15, milliseconds: 137),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 58, milliseconds: 870),

new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 28, milliseconds: 291),

new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 15, milliseconds: 383),

},
},
            new TimeSpanintervalArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 12, milliseconds: 919),

new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 26, milliseconds: 515),

new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 52, milliseconds: 207),

new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 0, milliseconds: 234),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 28, milliseconds: 890),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 33, milliseconds: 624),

new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 25, milliseconds: 417),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 35, milliseconds: 837),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 14, milliseconds: 666),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 54, milliseconds: 614),

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((ITimeSpanListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((ITimeSpanListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                parametr1.Value = 46;
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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 85, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 29, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[29], false);
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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 108, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(10));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((ITimeSpanListintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((ITimeSpanListintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
        private void ImportModelInnerConfig()
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

