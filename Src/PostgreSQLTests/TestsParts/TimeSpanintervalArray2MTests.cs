

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 26, milliseconds: 153),

new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 40, milliseconds: 66),

new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 29, milliseconds: 135),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 37, milliseconds: 812),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 6, milliseconds: 349),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 54, milliseconds: 479),

new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 46, milliseconds: 520),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 27, milliseconds: 27),

new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 36, milliseconds: 705),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 56, milliseconds: 952),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 9, milliseconds: 350),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 29, milliseconds: 258),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 56, milliseconds: 595),

new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 38, milliseconds: 461),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 2, milliseconds: 130),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 3, milliseconds: 92),

new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 25, milliseconds: 890),

},
},
            new TimeSpanintervalArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 4, milliseconds: 557),

new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 34, milliseconds: 203),

new TimeSpan(days: 0, hours: 4, minutes: 17, seconds: 7, milliseconds: 675),

new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 2, milliseconds: 713),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 33, milliseconds: 132),

new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 47, milliseconds: 89),

new TimeSpan(days: 0, hours: 21, minutes: 55, seconds: 20, milliseconds: 9),

new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 1, milliseconds: 894),

},
},
            new TimeSpanintervalArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 2, milliseconds: 613),

new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 37, milliseconds: 744),

new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 42, milliseconds: 279),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 18, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 51, milliseconds: 359),

new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 33, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 37, milliseconds: 123),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 8, milliseconds: 175),

new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 8, minutes: 11, seconds: 40, milliseconds: 170),

new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 6, milliseconds: 246),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 41, milliseconds: 948),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 0, milliseconds: 478),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 46, milliseconds: 214),

new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 56, milliseconds: 746),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 31, milliseconds: 531),

new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 1, milliseconds: 149),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 18, milliseconds: 960),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 33, milliseconds: 906),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 48, milliseconds: 725),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 13, milliseconds: 247),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 26, milliseconds: 182),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 57, milliseconds: 842),

new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 32, milliseconds: 601),

new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 46, milliseconds: 171),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 32, milliseconds: 414),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 33, milliseconds: 398),

new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 18, milliseconds: 770),

new TimeSpan(days: 0, hours: 13, minutes: 20, seconds: 18, milliseconds: 729),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 39, milliseconds: 641),

new TimeSpan(days: 0, hours: 15, minutes: 21, seconds: 21, milliseconds: 970),

new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 46, milliseconds: 342),

new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 56, milliseconds: 524),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 9, milliseconds: 411),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 39, milliseconds: 29),

new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 19, milliseconds: 982),

new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 44, milliseconds: 318),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 54, milliseconds: 579),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 47, milliseconds: 260),

new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 39, milliseconds: 723),

new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 2, milliseconds: 677),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 26, milliseconds: 455),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 35, milliseconds: 484),

new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 20, milliseconds: 665),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 30, milliseconds: 121),

new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 7, milliseconds: 650),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 34, milliseconds: 894),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 58, milliseconds: 650),

new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 21, milliseconds: 50),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 29, milliseconds: 617),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 18, milliseconds: 691),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 0, milliseconds: 479),

new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 39, milliseconds: 804),

new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 52, milliseconds: 686),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 27, milliseconds: 42),

new TimeSpan(days: 0, hours: 4, minutes: 22, seconds: 36, milliseconds: 147),

new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 56, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 50, milliseconds: 51),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 46, milliseconds: 627),

new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 20, milliseconds: 2),

new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 8, milliseconds: 955),

new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 15, milliseconds: 447),

},
},
            new TimeSpanintervalArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 2, milliseconds: 683),

new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 3, milliseconds: 941),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 8, milliseconds: 109),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 23, milliseconds: 487),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 56, milliseconds: 682),

new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 14, milliseconds: 898),

new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 13, milliseconds: 985),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 53, milliseconds: 356),

new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 49, milliseconds: 816),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 54, milliseconds: 853),

new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 22, milliseconds: 657),

},
},
            new TimeSpanintervalArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 34, milliseconds: 457),

new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 7, milliseconds: 809),

new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 35, milliseconds: 250),

new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 3, milliseconds: 509),

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
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 36, milliseconds: 705),

new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 32, milliseconds: 160),

new TimeSpan(days: 0, hours: 13, minutes: 17, seconds: 53, milliseconds: 238),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 20, milliseconds: 671),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 7, milliseconds: 25),

new TimeSpan(days: 0, hours: 6, minutes: 19, seconds: 45, milliseconds: 298),

new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 29, milliseconds: 327),

new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 32, milliseconds: 829),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 9, milliseconds: 612),

new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 14, milliseconds: 676),

new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 15, milliseconds: 670),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 31, milliseconds: 472),

new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 12, milliseconds: 97),

new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 52, milliseconds: 286),

new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 12, milliseconds: 246),

},
},
            new TimeSpanintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 5, milliseconds: 370),

new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 0, milliseconds: 830),

new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 46, milliseconds: 23),

new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 38, milliseconds: 494),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 3, milliseconds: 722),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 51, milliseconds: 517),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 49, milliseconds: 957),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 49, milliseconds: 952),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 35, milliseconds: 397),

new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 19, milliseconds: 572),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 40, milliseconds: 338),

new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 40, milliseconds: 178),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 15, milliseconds: 135),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 57, milliseconds: 901),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 55, milliseconds: 218),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 57, milliseconds: 467),

new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 50, milliseconds: 47),

},
},
            new TimeSpanintervalArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 17, milliseconds: 197),

new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 38, milliseconds: 272),

new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 38, milliseconds: 54),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 42, milliseconds: 40),

new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 47, milliseconds: 300),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 19, milliseconds: 374),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 21, milliseconds: 290),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 16, seconds: 29, milliseconds: 765),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 44, milliseconds: 702),

new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 18, milliseconds: 735),

new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 6, milliseconds: 981),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 41, milliseconds: 488),

new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 15, milliseconds: 337),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 33, milliseconds: 383),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 48, milliseconds: 686),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 50, milliseconds: 836),

new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 5, milliseconds: 279),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 17, milliseconds: 418),

},
},
            new TimeSpanintervalArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 279),

new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 36, milliseconds: 449),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 14, milliseconds: 403),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 52, milliseconds: 842),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 39, milliseconds: 586),

new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 17, milliseconds: 225),

new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 45, milliseconds: 876),

},
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 51, milliseconds: 782),

new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 39, milliseconds: 426),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 19, milliseconds: 516),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 53, milliseconds: 966),

new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 51, milliseconds: 691),

new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 50, milliseconds: 871),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 55, milliseconds: 361),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 3, milliseconds: 789),

new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 5, milliseconds: 558),

new TimeSpan(days: 0, hours: 14, minutes: 38, seconds: 28, milliseconds: 142),

new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 29, milliseconds: 764),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 50, milliseconds: 23),

new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 50, milliseconds: 194),

new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 25, milliseconds: 788),

new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 35, milliseconds: 165),

},
},
            new TimeSpanintervalArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 33, milliseconds: 336),

new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 31, milliseconds: 456),

new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 49, milliseconds: 701),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 54, milliseconds: 245),

new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 58, milliseconds: 854),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 34, milliseconds: 671),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 0, milliseconds: 685),

},
},
            new TimeSpanintervalArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 13, milliseconds: 260),

new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 39, milliseconds: 630),

new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 49, milliseconds: 148),

new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 15, milliseconds: 589),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 39, milliseconds: 925),

new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 43, milliseconds: 83),

new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 36, milliseconds: 439),

new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 20, milliseconds: 256),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 9, milliseconds: 683),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 29, milliseconds: 503),

new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 27, milliseconds: 232),

new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 34, milliseconds: 335),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 13, milliseconds: 37),

new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 48, milliseconds: 23),

new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 29, milliseconds: 931),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 46, milliseconds: 333),

},
},
            new TimeSpanintervalArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 0, milliseconds: 179),

new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 17, milliseconds: 884),

new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 30, milliseconds: 315),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 51, milliseconds: 501),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 14, milliseconds: 868),

new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 19, milliseconds: 615),

new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 54, milliseconds: 699),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 24, milliseconds: 402),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 46, milliseconds: 59),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 57, milliseconds: 422),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 18, milliseconds: 705),

new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 4, milliseconds: 66),

new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 23, milliseconds: 878),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 37, milliseconds: 903),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 28, seconds: 17, milliseconds: 575),

new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 46, milliseconds: 369),

new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 52, milliseconds: 246),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 18, milliseconds: 253),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 49, milliseconds: 136),

new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 40, milliseconds: 403),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 8, milliseconds: 825),

new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 18, milliseconds: 930),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 7, milliseconds: 828),

new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 49, milliseconds: 67),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 12, milliseconds: 694),

new TimeSpan(days: 0, hours: 15, minutes: 45, seconds: 14, milliseconds: 915),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 11, milliseconds: 75),

new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 40, milliseconds: 375),

},
},
            new TimeSpanintervalArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 33, milliseconds: 711),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 8, milliseconds: 608),

new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 20, milliseconds: 507),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 48, milliseconds: 254),

new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 41, milliseconds: 164),

new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 27, milliseconds: 68),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 29, milliseconds: 830),

new TimeSpan(days: 0, hours: 1, minutes: 26, seconds: 56, milliseconds: 540),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 16, milliseconds: 441),

new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 48, milliseconds: 435),

},
},
            new TimeSpanintervalArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 54, milliseconds: 663),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 35, milliseconds: 244),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 30, milliseconds: 347),

new TimeSpan(days: 0, hours: 14, minutes: 24, seconds: 12, milliseconds: 716),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 11, milliseconds: 589),

new TimeSpan(days: 0, hours: 22, minutes: 11, seconds: 15, milliseconds: 269),

new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 18, milliseconds: 802),

},
},
            new TimeSpanintervalArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 0, milliseconds: 815),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 40, milliseconds: 737),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 37, milliseconds: 915),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 23, milliseconds: 272),

new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 46, milliseconds: 531),

new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 18, milliseconds: 901),

new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 10, milliseconds: 737),

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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)),
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);
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
                var models = await((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[6], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[23],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[3], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[4], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[5], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[6], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[7], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[8], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[9], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[10], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[11], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[12], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[13], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[14], false);FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[15], false);FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[16], false);FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[17], false);FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[13], false);FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[14], false);FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[15], false);FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[16], false);FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[17], false);FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[18], false);FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[19], false);FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[20], false);FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[21], false);FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[22], false);FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[23], false);FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[24], false);FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[25], false);FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[26], false);FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[27], false);FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[28], false);FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[29], false);
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
                var models = await((ITimeSpanListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 16, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[4], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[5], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[6], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[23],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[24],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[25],_testData[29], false);
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
                var models = ((ITimeSpanListintervalArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatch(connection, 106, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[6], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[23],_testData[29], false);
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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
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

