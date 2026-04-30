

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 29, milliseconds: 922),

new TimeSpan(days: 0, hours: 22, minutes: 26, seconds: 4, milliseconds: 793),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 4, milliseconds: 603),

new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 42, milliseconds: 848),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 28, milliseconds: 213),

new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 5, milliseconds: 36),

new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 16, milliseconds: 636),

},
},
            new TimeSpanintervalArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 22, milliseconds: 164),

new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 55, milliseconds: 121),

new TimeSpan(days: 0, hours: 16, minutes: 45, seconds: 33, milliseconds: 611),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 9, milliseconds: 818),

new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 29, milliseconds: 881),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 24, milliseconds: 252),

new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 53, milliseconds: 40),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 36, milliseconds: 224),

new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 38, milliseconds: 265),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 44, milliseconds: 578),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 26, milliseconds: 83),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 17, milliseconds: 783),

new TimeSpan(days: 0, hours: 14, minutes: 24, seconds: 42, milliseconds: 454),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 16, milliseconds: 444),

},
},
            new TimeSpanintervalArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 38, seconds: 13, milliseconds: 214),

new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 8, milliseconds: 160),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 34, milliseconds: 906),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 32, milliseconds: 683),

new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 58, milliseconds: 781),

new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 49, milliseconds: 974),

},
},
            new TimeSpanintervalArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 11, milliseconds: 569),

new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 8, milliseconds: 169),

new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 35, milliseconds: 65),

new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 32, milliseconds: 76),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 50, milliseconds: 643),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 12, milliseconds: 780),

new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 51, milliseconds: 701),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 12, milliseconds: 962),

new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 24, milliseconds: 793),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 36, milliseconds: 817),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 12, milliseconds: 665),

},
},
            new TimeSpanintervalArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 45, milliseconds: 775),

new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 42, milliseconds: 528),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 14, milliseconds: 819),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 42, milliseconds: 140),

new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 31, milliseconds: 941),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 54, milliseconds: 373),

},
},
            new TimeSpanintervalArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 37, milliseconds: 547),

new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 25, milliseconds: 923),

new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 46, milliseconds: 756),

new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 52, milliseconds: 350),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 48, milliseconds: 33),

new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 45, milliseconds: 588),

new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 53, milliseconds: 912),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 23, milliseconds: 949),

new TimeSpan(days: 0, hours: 21, minutes: 39, seconds: 33, milliseconds: 222),

new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 4, milliseconds: 67),

new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 14, milliseconds: 146),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 52, milliseconds: 81),

new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 12, milliseconds: 26),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 23, milliseconds: 450),

new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 24, milliseconds: 450),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 6, milliseconds: 649),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 16, milliseconds: 420),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 7, milliseconds: 588),

},
},
            new TimeSpanintervalArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 53, milliseconds: 320),

new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 43, milliseconds: 948),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 45, milliseconds: 856),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 30, milliseconds: 234),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 3, milliseconds: 458),

new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 24, milliseconds: 1),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 30, milliseconds: 291),

new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 32, milliseconds: 140),

new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 58, milliseconds: 90),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 48, milliseconds: 993),

},
},
            new TimeSpanintervalArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 18, milliseconds: 743),

new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 55, milliseconds: 901),

new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 5, milliseconds: 847),

new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 48, milliseconds: 314),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 16, milliseconds: 205),

new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 14, milliseconds: 304),

new TimeSpan(days: 0, hours: 12, minutes: 51, seconds: 52, milliseconds: 256),

},
},
            new TimeSpanintervalArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 10, milliseconds: 48),

new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 17, milliseconds: 209),

new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 55, milliseconds: 476),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 43, milliseconds: 635),

new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 17, milliseconds: 336),

new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 19, milliseconds: 901),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 10, milliseconds: 978),

new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 11, milliseconds: 842),

new TimeSpan(days: 0, hours: 3, minutes: 1, seconds: 44, milliseconds: 826),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 28, milliseconds: 774),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 16, milliseconds: 79),

new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 26, milliseconds: 701),

new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 1, milliseconds: 574),

new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 35, milliseconds: 243),

},
},
            new TimeSpanintervalArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 14, milliseconds: 611),

new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 32, milliseconds: 267),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 43, milliseconds: 417),

new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 46, milliseconds: 592),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 47, milliseconds: 867),

new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 10, milliseconds: 969),

new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 18, milliseconds: 524),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 46, milliseconds: 300),

new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 8, milliseconds: 132),

new TimeSpan(days: 0, hours: 12, minutes: 26, seconds: 31, milliseconds: 850),

new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 7, milliseconds: 967),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 47, milliseconds: 859),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 20, milliseconds: 436),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 12, milliseconds: 492),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 57, milliseconds: 725),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 22, milliseconds: 368),

new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 4, milliseconds: 752),

new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 51, milliseconds: 413),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 49, milliseconds: 818),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 44, milliseconds: 364),

new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 10, milliseconds: 907),

new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 26, milliseconds: 353),

},
},
            new TimeSpanintervalArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 6, milliseconds: 147),

new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 6, milliseconds: 625),

new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 14, milliseconds: 438),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 30, milliseconds: 29),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 54, milliseconds: 312),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 34, milliseconds: 290),

new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 16, milliseconds: 227),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 33, milliseconds: 592),

new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 28, milliseconds: 431),

new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 39, milliseconds: 283),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 4, milliseconds: 969),

new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 18, milliseconds: 780),

new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 42, milliseconds: 635),

new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 47, milliseconds: 475),

},
},
            new TimeSpanintervalArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 58, milliseconds: 223),

new TimeSpan(days: 0, hours: 4, minutes: 32, seconds: 13, milliseconds: 457),

new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 42, milliseconds: 45),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 46, milliseconds: 821),

new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 48, milliseconds: 903),

new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 17, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 41, milliseconds: 723),

},
},
            new TimeSpanintervalArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 7, milliseconds: 367),

new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 7, milliseconds: 386),

new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 54, milliseconds: 700),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 22, milliseconds: 578),

new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 13, milliseconds: 614),

new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 16, milliseconds: 666),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 9, milliseconds: 151),

new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 0, milliseconds: 494),

new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 21, milliseconds: 339),

new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 29, milliseconds: 483),

},
},
            new TimeSpanintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 16, milliseconds: 93),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 46, milliseconds: 263),

new TimeSpan(days: 0, hours: 14, minutes: 36, seconds: 10, milliseconds: 93),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 50, milliseconds: 109),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 0, milliseconds: 816),

new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 57, milliseconds: 982),

new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 18, milliseconds: 897),

},
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 0, milliseconds: 572),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 33, milliseconds: 989),

new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 22, milliseconds: 381),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 26, milliseconds: 330),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 16, milliseconds: 240),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 51, milliseconds: 92),

new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 1, milliseconds: 19),

new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 35, milliseconds: 651),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 34, milliseconds: 832),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 25, milliseconds: 561),

new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 14, milliseconds: 191),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 48, seconds: 42, milliseconds: 149),

new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 35, milliseconds: 899),

new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 49, milliseconds: 884),

},
},
            new TimeSpanintervalArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 50, milliseconds: 383),

new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 41, milliseconds: 88),

new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 51, milliseconds: 57),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 36, milliseconds: 150),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 33, milliseconds: 853),

new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 3, milliseconds: 696),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 53, milliseconds: 151),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 58, seconds: 22, milliseconds: 721),

new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 45, milliseconds: 323),

new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 24, milliseconds: 981),

new TimeSpan(days: 0, hours: 21, minutes: 39, seconds: 31, milliseconds: 25),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 0, seconds: 32, milliseconds: 210),

new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 9, milliseconds: 600),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 19, milliseconds: 732),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 12, milliseconds: 906),

new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 14, milliseconds: 936),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 19, milliseconds: 3),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 27, milliseconds: 535),

new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 33, milliseconds: 669),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 44, milliseconds: 556),

new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 15, milliseconds: 348),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 1, milliseconds: 26),

new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 29, milliseconds: 153),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 6, milliseconds: 197),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 32, milliseconds: 82),

new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 27, milliseconds: 391),

new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 29, milliseconds: 706),

new TimeSpan(days: 0, hours: 20, minutes: 53, seconds: 27, milliseconds: 151),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 25, milliseconds: 375),

new TimeSpan(days: 0, hours: 1, minutes: 26, seconds: 10, milliseconds: 475),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 50, milliseconds: 150),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 7, milliseconds: 402),

new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 16, milliseconds: 693),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 19, milliseconds: 794),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 44, milliseconds: 515),

new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 55, milliseconds: 410),

new TimeSpan(days: 0, hours: 6, minutes: 57, seconds: 21, milliseconds: 893),

},
},
            new TimeSpanintervalArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 46, milliseconds: 323),

new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 8, milliseconds: 350),

new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 42, milliseconds: 829),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 8, milliseconds: 462),

new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 52, milliseconds: 328),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 42, milliseconds: 480),

new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 46, milliseconds: 799),

},
},
            new TimeSpanintervalArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 58, milliseconds: 839),

new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 13, milliseconds: 57),

new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 27, milliseconds: 237),

new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 36, milliseconds: 145),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 12, milliseconds: 224),

new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 10, milliseconds: 57),

new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 41, milliseconds: 875),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 37, milliseconds: 935),

new TimeSpan(days: 0, hours: 10, minutes: 53, seconds: 32, milliseconds: 494),

new TimeSpan(days: 0, hours: 13, minutes: 21, seconds: 19, milliseconds: 286),

new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 12, milliseconds: 920),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 47, milliseconds: 398),

new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 51, milliseconds: 384),

new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 44, milliseconds: 505),

new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 26, milliseconds: 268),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 5, milliseconds: 650),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 19, milliseconds: 947),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 44, milliseconds: 552),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 19, milliseconds: 268),

},
},
            new TimeSpanintervalArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 32, milliseconds: 657),

new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 45, milliseconds: 308),

new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 4, milliseconds: 102),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 33, seconds: 16, milliseconds: 680),

new TimeSpan(days: 0, hours: 1, minutes: 5, seconds: 4, milliseconds: 203),

new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 5, milliseconds: 328),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 26, milliseconds: 810),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 36, milliseconds: 358),

new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 42, milliseconds: 679),

new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 11, milliseconds: 613),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 41, milliseconds: 672),

new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 6, milliseconds: 851),

new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 47, milliseconds: 168),

},
},
            new TimeSpanintervalArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 19, milliseconds: 249),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 32, milliseconds: 251),

new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 48, milliseconds: 274),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 7, milliseconds: 400),

new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 23, milliseconds: 661),

new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 24, milliseconds: 485),

new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 22, milliseconds: 736),

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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[29], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
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
                parametr1.Value = 26;
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
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                        Assert.That(models, Has.Count.EqualTo(13));

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
                parametr1.Value = 137;
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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[4], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[5], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[6], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[23],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[24],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[25],_testData[29], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[29], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[24],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 26, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 117, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 15))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 119, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanListintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpanintervalArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanListintervalArray)this).DynQuerySelectImportModelInner(connection);
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
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

