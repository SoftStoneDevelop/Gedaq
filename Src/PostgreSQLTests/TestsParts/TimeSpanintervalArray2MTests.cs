

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
new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 56, milliseconds: 186),

new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 5, milliseconds: 536),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 38, milliseconds: 371),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 42, milliseconds: 133),

new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 28, milliseconds: 881),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 45, milliseconds: 731),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 47, milliseconds: 647),

new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 9, milliseconds: 229),

new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 12, milliseconds: 760),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 57, milliseconds: 862),

new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 44, milliseconds: 114),

new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 11, milliseconds: 165),

new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 47, milliseconds: 232),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 34, milliseconds: 537),

new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 50, milliseconds: 23),

new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 38, milliseconds: 504),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 37, milliseconds: 837),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 27, milliseconds: 637),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 12, milliseconds: 265),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 35, milliseconds: 236),

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
new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 41, milliseconds: 208),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 13, milliseconds: 893),

new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 0, milliseconds: 552),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 45, milliseconds: 50),

new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 53, milliseconds: 16),

new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 6, milliseconds: 590),

new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 2, milliseconds: 461),

},
},
            new TimeSpanintervalArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 44, milliseconds: 771),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 58, milliseconds: 284),

new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 57, milliseconds: 274),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 41, milliseconds: 183),

new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 3, milliseconds: 642),

new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 44, milliseconds: 831),

new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 34, milliseconds: 919),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 13, milliseconds: 233),

new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 4, milliseconds: 160),

new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 16, milliseconds: 744),

new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 22, milliseconds: 0),

},
},
            new TimeSpanintervalArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 45, milliseconds: 251),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 34, milliseconds: 905),

new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 28, milliseconds: 288),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 23, milliseconds: 592),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 26, milliseconds: 631),

new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 12, milliseconds: 946),

},
},
            new TimeSpanintervalArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 17, milliseconds: 907),

new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 34, milliseconds: 659),

new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 38, milliseconds: 78),

new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 28, milliseconds: 983),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 47, milliseconds: 651),

new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 2, milliseconds: 802),

new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 44, milliseconds: 97),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 29, milliseconds: 738),

new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 23, milliseconds: 767),

new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 21, milliseconds: 566),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 10, milliseconds: 785),

new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 45, milliseconds: 874),

new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 47, milliseconds: 48),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 15, milliseconds: 639),

new TimeSpan(days: 0, hours: 6, minutes: 19, seconds: 12, milliseconds: 807),

new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 44, milliseconds: 731),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 23, milliseconds: 652),

new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 54, milliseconds: 542),

new TimeSpan(days: 0, hours: 8, minutes: 40, seconds: 40, milliseconds: 690),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 23, milliseconds: 76),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 13, milliseconds: 238),

new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 56, milliseconds: 991),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 37, milliseconds: 983),

},
},
            new TimeSpanintervalArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 41, milliseconds: 411),

new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 26, milliseconds: 318),

new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 8, milliseconds: 357),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 38, seconds: 20, milliseconds: 59),

new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 8, milliseconds: 152),

new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 10, milliseconds: 509),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 22, milliseconds: 620),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 58, milliseconds: 896),

new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 3, milliseconds: 486),

new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 3, milliseconds: 807),

},
},
            new TimeSpanintervalArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 24, milliseconds: 755),

new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 27, milliseconds: 779),

new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 58, milliseconds: 874),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 14, milliseconds: 145),

new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 48, milliseconds: 470),

new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 23, milliseconds: 764),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 11, milliseconds: 23),

new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 22, milliseconds: 887),

new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 11, milliseconds: 904),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 15, milliseconds: 104),

new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 51, milliseconds: 274),

new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 56, milliseconds: 306),

new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 58, milliseconds: 968),

},
},
            new TimeSpanintervalArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 3, milliseconds: 377),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 24, milliseconds: 210),

new TimeSpan(days: 0, hours: 5, minutes: 34, seconds: 42, milliseconds: 50),

new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 45, milliseconds: 653),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 4, seconds: 18, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 19, milliseconds: 765),

new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 13, milliseconds: 753),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 31, milliseconds: 134),

},
},
            new TimeSpanintervalArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 53, milliseconds: 765),

new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 31, milliseconds: 107),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 22, milliseconds: 510),

new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 29, milliseconds: 312),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 18, seconds: 7, milliseconds: 511),

new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 42, milliseconds: 739),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 56, milliseconds: 693),

new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 41, milliseconds: 856),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 44, milliseconds: 548),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 936),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 1, milliseconds: 683),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 10, milliseconds: 140),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 21, milliseconds: 195),

new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 8, milliseconds: 899),

},
},
            new TimeSpanintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 43, milliseconds: 319),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 8, milliseconds: 556),

new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 10, milliseconds: 878),

new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 24, milliseconds: 521),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 56, milliseconds: 415),

new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 48, milliseconds: 35),

new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 25, milliseconds: 473),

new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 17, milliseconds: 622),

},
},
            new TimeSpanintervalArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 4, seconds: 0, milliseconds: 550),

new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 42, milliseconds: 850),

new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 52, milliseconds: 103),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 19, milliseconds: 954),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 11, milliseconds: 707),

new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 22, milliseconds: 707),

new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 3, milliseconds: 48),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 40, milliseconds: 280),

new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 44, milliseconds: 966),

new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 7, milliseconds: 498),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 29, milliseconds: 322),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 17, milliseconds: 944),

new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 35, milliseconds: 250),

new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 12, milliseconds: 172),

},
},
            new TimeSpanintervalArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 34, milliseconds: 411),

new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 28, milliseconds: 309),

new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 48, milliseconds: 952),

new TimeSpan(days: 0, hours: 10, minutes: 38, seconds: 47, milliseconds: 455),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 28, milliseconds: 572),

new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 1, milliseconds: 77),

new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 51, milliseconds: 913),

},
},
            new TimeSpanintervalArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 49, milliseconds: 59),

new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 43, milliseconds: 739),

new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 58, milliseconds: 525),

new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 9, milliseconds: 490),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 48, milliseconds: 147),

new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 36, milliseconds: 442),

new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 27, milliseconds: 151),

new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 42, milliseconds: 774),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 19, milliseconds: 117),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 58, milliseconds: 52),

new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 29, milliseconds: 543),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 12, milliseconds: 809),

new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 54, milliseconds: 214),

new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 56, milliseconds: 236),

new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 15, milliseconds: 1),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 10, milliseconds: 838),

new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 52, milliseconds: 469),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 35, milliseconds: 542),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 39, milliseconds: 980),

new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 31, milliseconds: 510),

new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 35, milliseconds: 236),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 40, milliseconds: 665),

new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 31, milliseconds: 580),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 41, milliseconds: 918),

},
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 57, milliseconds: 362),

new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 51, milliseconds: 602),

new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 21, milliseconds: 694),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 6, milliseconds: 571),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 13, milliseconds: 285),

new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 37, milliseconds: 290),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 56, milliseconds: 87),

},
},
            new TimeSpanintervalArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 36, milliseconds: 85),

new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 45, milliseconds: 354),

new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 58, milliseconds: 592),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 26, milliseconds: 801),

new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 51, milliseconds: 721),

new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 57, milliseconds: 352),

new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 27, milliseconds: 624),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 48, milliseconds: 298),

new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 22, milliseconds: 314),

new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 19, milliseconds: 293),

new TimeSpan(days: 0, hours: 22, minutes: 11, seconds: 27, milliseconds: 849),

},
},
            new TimeSpanintervalArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 16, milliseconds: 705),

new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 8, milliseconds: 124),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 45, milliseconds: 660),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 49, milliseconds: 364),

new TimeSpan(days: 0, hours: 12, minutes: 26, seconds: 33, milliseconds: 579),

new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 4, milliseconds: 763),

new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 18, milliseconds: 943),

},
},
            new TimeSpanintervalArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 13, milliseconds: 54),

new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 58, milliseconds: 344),

new TimeSpan(days: 0, hours: 21, minutes: 22, seconds: 23, milliseconds: 777),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 46, milliseconds: 697),

new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 12, milliseconds: 178),

new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 4, milliseconds: 591),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 10, milliseconds: 258),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 39, milliseconds: 525),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 40, milliseconds: 16),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 15, milliseconds: 445),

new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 45, milliseconds: 211),

new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 34, milliseconds: 525),

new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 13, milliseconds: 662),

},
},
            new TimeSpanintervalArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 50, milliseconds: 147),

new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 0, milliseconds: 174),

new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 57, milliseconds: 407),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 50, seconds: 28, milliseconds: 93),

new TimeSpan(days: 0, hours: 6, minutes: 52, seconds: 34, milliseconds: 336),

new TimeSpan(days: 0, hours: 15, minutes: 45, seconds: 53, milliseconds: 313),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 0, milliseconds: 589),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 56, milliseconds: 450),

new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 18, milliseconds: 161),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 13, milliseconds: 764),

new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 8, milliseconds: 983),

new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 19, milliseconds: 394),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 21, milliseconds: 146),

new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 42, milliseconds: 858),

new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 5, milliseconds: 14),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 6, milliseconds: 444),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 29, milliseconds: 133),

new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 13, milliseconds: 80),

new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 53, milliseconds: 622),

new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 22, milliseconds: 21),

},
},
            new TimeSpanintervalArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 25, milliseconds: 826),

new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 44, milliseconds: 897),

new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 20, milliseconds: 364),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 30, milliseconds: 389),

new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 28, milliseconds: 401),

new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 53, milliseconds: 234),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 23, milliseconds: 465),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 14, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 10, milliseconds: 712),

new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 56, milliseconds: 587),

},
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
                parametr1.Value = 87;
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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[29], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(19));

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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 87, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 35, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[29], false);
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
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[21],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 55))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 79, 107))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[29], false);
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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 8; i < 12; i++)
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeSpanintervalArray2MI>(2);
                for (int i = 12; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

