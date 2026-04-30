

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
new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 25, milliseconds: 145),

new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 56, milliseconds: 857),

new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 31, milliseconds: 46),

new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 31, milliseconds: 617),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 19, milliseconds: 375),

new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 1, milliseconds: 533),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 28, milliseconds: 736),

new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 17, milliseconds: 973),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 13, milliseconds: 143),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 32, milliseconds: 770),

new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 7, milliseconds: 378),

new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 8, milliseconds: 287),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 41, milliseconds: 112),

new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 43, milliseconds: 355),

new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 20, milliseconds: 684),

new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 29, milliseconds: 595),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 42, milliseconds: 601),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 47, milliseconds: 300),

new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 24, milliseconds: 753),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 34, milliseconds: 481),

},
},
            new TimeSpanintervalArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 34, milliseconds: 764),

new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 28, milliseconds: 470),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 1, milliseconds: 151),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 35, milliseconds: 843),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 7, milliseconds: 169),

new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 18, milliseconds: 273),

new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 52, milliseconds: 918),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 0, milliseconds: 944),

new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 48, milliseconds: 259),

new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 25, milliseconds: 951),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 44, milliseconds: 747),

new TimeSpan(days: 0, hours: 5, minutes: 37, seconds: 51, milliseconds: 608),

new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 18, milliseconds: 896),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 57, milliseconds: 984),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 46, milliseconds: 536),

new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 58, milliseconds: 637),

},
},
            new TimeSpanintervalArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 2, milliseconds: 49),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 28, milliseconds: 700),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 42, milliseconds: 659),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 52, milliseconds: 908),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 1, milliseconds: 847),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 8, milliseconds: 7),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 51, milliseconds: 323),

new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 36, milliseconds: 38),

new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 41, milliseconds: 822),

},
},
            new TimeSpanintervalArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 54, milliseconds: 301),

new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 36, milliseconds: 575),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 35, milliseconds: 265),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 8, seconds: 0, milliseconds: 968),

new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 18, milliseconds: 365),

new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 37, milliseconds: 313),

},
},
            new TimeSpanintervalArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 35, milliseconds: 594),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 45, milliseconds: 504),

new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 32, milliseconds: 808),

new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 34, milliseconds: 733),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 14, milliseconds: 605),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 36, milliseconds: 582),

new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 33, milliseconds: 934),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 3, milliseconds: 551),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 33, milliseconds: 690),

new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 22, milliseconds: 240),

new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 5, milliseconds: 799),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 2, milliseconds: 13),

new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 32, milliseconds: 15),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 1, milliseconds: 608),

new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 23, milliseconds: 808),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 56, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 47, milliseconds: 496),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 58, milliseconds: 471),

},
},
            new TimeSpanintervalArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 22, milliseconds: 743),

new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 4, milliseconds: 689),

new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 45, milliseconds: 801),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 57, milliseconds: 761),

new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 48, milliseconds: 492),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 31, milliseconds: 370),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 22, milliseconds: 291),

new TimeSpan(days: 0, hours: 20, minutes: 36, seconds: 33, milliseconds: 809),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 32, milliseconds: 215),

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
new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 27, milliseconds: 859),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 55, milliseconds: 234),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 23, milliseconds: 373),

new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 41, milliseconds: 269),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 14, milliseconds: 856),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 54, milliseconds: 599),

new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 24, milliseconds: 393),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 35, milliseconds: 253),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 23, milliseconds: 836),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 6, milliseconds: 974),

new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 4, milliseconds: 603),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 43, milliseconds: 876),

new TimeSpan(days: 0, hours: 12, minutes: 49, seconds: 39, milliseconds: 447),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 58, milliseconds: 906),

new TimeSpan(days: 0, hours: 3, minutes: 38, seconds: 38, milliseconds: 796),

},
},
            new TimeSpanintervalArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 22, milliseconds: 979),

new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 50, milliseconds: 441),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 30, milliseconds: 640),

new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 1, milliseconds: 886),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 32, milliseconds: 134),

new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 24, milliseconds: 478),

new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 41, milliseconds: 933),

new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 19, milliseconds: 659),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 44, milliseconds: 247),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 44, milliseconds: 464),

new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 23, milliseconds: 200),

new TimeSpan(days: 0, hours: 20, minutes: 47, seconds: 51, milliseconds: 813),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 43, milliseconds: 484),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 57, milliseconds: 201),

new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 19, milliseconds: 284),

},
},
            new TimeSpanintervalArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 57, milliseconds: 110),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 13, milliseconds: 871),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 55, milliseconds: 714),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 11, milliseconds: 375),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 851),

new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 21, milliseconds: 250),

},
},
            new TimeSpanintervalArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 56, milliseconds: 148),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 55, milliseconds: 565),

new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 10, milliseconds: 422),

new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 51, milliseconds: 97),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 18, seconds: 9, milliseconds: 864),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 20, milliseconds: 914),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 15, milliseconds: 701),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 57, milliseconds: 594),

new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 48, milliseconds: 444),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 22, milliseconds: 737),

},
},
            new TimeSpanintervalArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 1, milliseconds: 728),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 28, milliseconds: 14),

new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 6, milliseconds: 50),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 45, milliseconds: 707),

new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 36, milliseconds: 300),

new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 49, milliseconds: 535),

},
},
            new TimeSpanintervalArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 21, milliseconds: 260),

new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 13, milliseconds: 46),

new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 6, milliseconds: 749),

new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 20, milliseconds: 653),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 20, milliseconds: 109),

new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 54, milliseconds: 192),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 0, milliseconds: 630),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 39, milliseconds: 446),

new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 46, milliseconds: 79),

new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 39, milliseconds: 274),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 25, milliseconds: 865),

new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 5, milliseconds: 641),

new TimeSpan(days: 0, hours: 19, minutes: 3, seconds: 48, milliseconds: 816),

},
},
            new TimeSpanintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 14, milliseconds: 160),

new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 41, milliseconds: 657),

new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 37, milliseconds: 96),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 33, milliseconds: 21),

new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 16, milliseconds: 250),

new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 9, milliseconds: 472),

new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 7, milliseconds: 562),

},
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 33, milliseconds: 654),

new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 38, milliseconds: 57),

new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 44, milliseconds: 187),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 33, milliseconds: 418),

new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 38, milliseconds: 72),

new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 52, milliseconds: 619),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 55, milliseconds: 236),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 16, milliseconds: 770),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 11, milliseconds: 586),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 21, milliseconds: 824),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 23, milliseconds: 17),

new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 28, milliseconds: 781),

new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 31, milliseconds: 461),

},
},
            new TimeSpanintervalArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 56, milliseconds: 886),

new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 11, milliseconds: 809),

new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 20, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 41, milliseconds: 98),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 1, milliseconds: 256),

new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 20, milliseconds: 710),

new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 31, milliseconds: 615),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 24, milliseconds: 326),

},
},
            new TimeSpanintervalArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 25, milliseconds: 128),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 26, milliseconds: 281),

new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 29, milliseconds: 919),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 57, milliseconds: 753),

new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 53, milliseconds: 324),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 35, milliseconds: 125),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 50, milliseconds: 345),

new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 18, milliseconds: 706),

new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 13, milliseconds: 780),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 56, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 35, milliseconds: 699),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 52, milliseconds: 670),

new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 17, milliseconds: 587),

},
},
            new TimeSpanintervalArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 58, seconds: 29, milliseconds: 600),

new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 3, milliseconds: 509),

new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 21, milliseconds: 52),

new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 42, milliseconds: 579),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 47, milliseconds: 579),

new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 44, milliseconds: 658),

new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 27, milliseconds: 60),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 21, milliseconds: 899),

new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 30, milliseconds: 468),

new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 1, milliseconds: 960),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 2, milliseconds: 500),

new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 58, milliseconds: 357),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 16, milliseconds: 451),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 54, milliseconds: 785),

new TimeSpan(days: 0, hours: 12, minutes: 11, seconds: 51, milliseconds: 11),

new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 22, milliseconds: 342),

},
},
            new TimeSpanintervalArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 19, milliseconds: 116),

new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 29, milliseconds: 139),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 37, milliseconds: 683),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 41, milliseconds: 150),

new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 19, milliseconds: 834),

new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 5, milliseconds: 890),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 16, milliseconds: 87),

new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 6, milliseconds: 955),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 21, milliseconds: 850),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 32, milliseconds: 85),

new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 28, milliseconds: 770),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 11, milliseconds: 59),

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
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 35, milliseconds: 587),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 28, milliseconds: 689),

new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 43, milliseconds: 410),

new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 26, milliseconds: 530),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 22, milliseconds: 464),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 50, milliseconds: 876),

new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 48, milliseconds: 335),

},
},
            new TimeSpanintervalArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 58, milliseconds: 831),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 28, milliseconds: 371),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 28, milliseconds: 765),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 8, milliseconds: 331),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 34, milliseconds: 479),

new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 13, milliseconds: 766),

new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 48, milliseconds: 669),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 605),

new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 44, milliseconds: 92),

new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 5, milliseconds: 363),

new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 18, milliseconds: 48),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 36, milliseconds: 725),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 7, milliseconds: 378),

new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 37, milliseconds: 776),

new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 24, milliseconds: 317),

},
},
            new TimeSpanintervalArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 27, milliseconds: 799),

new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 10, milliseconds: 422),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 19, milliseconds: 920),

new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 35, milliseconds: 312),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 2, milliseconds: 38),

new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 55, milliseconds: 48),

new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 35, milliseconds: 527),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 17, milliseconds: 126),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 11, milliseconds: 336),

new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 2, milliseconds: 756),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 45, milliseconds: 510),

new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 39, milliseconds: 840),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 9, milliseconds: 344),

},
},
            new TimeSpanintervalArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 56, milliseconds: 381),

new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 52, milliseconds: 727),

new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 37, milliseconds: 256),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 14, milliseconds: 948),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 53, milliseconds: 681),

new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 42, milliseconds: 479),

new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 54, milliseconds: 915),

new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 39, milliseconds: 965),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 12, milliseconds: 764),

new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 41, milliseconds: 245),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 4, milliseconds: 351),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 27, milliseconds: 26),

new TimeSpan(days: 0, hours: 4, minutes: 0, seconds: 24, milliseconds: 725),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 2, milliseconds: 692),

new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 42, milliseconds: 76),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 39, milliseconds: 431),

new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 10, milliseconds: 532),

new TimeSpan(days: 0, hours: 20, minutes: 28, seconds: 16, milliseconds: 59),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 26, milliseconds: 353),

new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 30, milliseconds: 915),

new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 5, milliseconds: 580),

new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 4, milliseconds: 948),

},
},
            new TimeSpanintervalArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 11, milliseconds: 125),

new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 19, milliseconds: 737),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 52, milliseconds: 391),

new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 23, milliseconds: 137),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 40, milliseconds: 538),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 5, milliseconds: 708),

new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 36, milliseconds: 354),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 15, milliseconds: 68),

new TimeSpan(days: 0, hours: 15, minutes: 35, seconds: 19, milliseconds: 558),

new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 16, milliseconds: 705),

new TimeSpan(days: 0, hours: 20, minutes: 36, seconds: 9, milliseconds: 996),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 51, milliseconds: 506),

new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 51, milliseconds: 244),

new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 13, milliseconds: 20),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 37, milliseconds: 541),

new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 23, milliseconds: 836),

new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 54, milliseconds: 311),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 46, milliseconds: 201),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[3], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[4], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[5], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[25],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[26],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[27],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[28],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[29],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[30],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 62, query2))
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
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[34], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[23],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[24],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[25],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[26],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[27],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[28],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[29],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[30],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[34], false);
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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[2], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[3], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[4], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[5], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[25],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[26],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[27],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[28],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[29],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[30],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[31],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 136, 24))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[3], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[4], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[5], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[25],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[26],_testData[29], false);
                        TimeSpanintervalArray2M.AssertModel(models[27],_testData[30], false);
                        TimeSpanintervalArray2M.AssertModel(models[28],_testData[31], false);
                        TimeSpanintervalArray2M.AssertModel(models[29],_testData[32], false);
                        TimeSpanintervalArray2M.AssertModel(models[30],_testData[33], false);
                        TimeSpanintervalArray2M.AssertModel(models[31],_testData[34], false);
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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[6], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[23],_testData[29], false);TimeSpanintervalArray2M.AssertModel(models[24],_testData[30], false);TimeSpanintervalArray2M.AssertModel(models[25],_testData[31], false);TimeSpanintervalArray2M.AssertModel(models[26],_testData[32], false);TimeSpanintervalArray2M.AssertModel(models[27],_testData[33], false);TimeSpanintervalArray2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[30], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[31], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[32], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[33], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[34], false);
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

