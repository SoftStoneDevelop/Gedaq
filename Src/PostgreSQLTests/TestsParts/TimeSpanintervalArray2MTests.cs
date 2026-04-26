

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 57, milliseconds: 372),

new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 44, milliseconds: 50),

new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 4, milliseconds: 299),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 27, milliseconds: 619),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 48, milliseconds: 253),

new TimeSpan(days: 0, hours: 16, minutes: 41, seconds: 14, milliseconds: 490),

new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 51, milliseconds: 450),

new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 14, milliseconds: 638),

},
},
            new TimeSpanintervalArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 53, milliseconds: 595),

new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 33, milliseconds: 782),

new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 56, milliseconds: 88),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 49, milliseconds: 582),

new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 21, milliseconds: 149),

new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 17, milliseconds: 37),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 37, seconds: 7, milliseconds: 540),

new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 56, milliseconds: 412),

new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 40, milliseconds: 955),

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
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 27, milliseconds: 237),

new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 31, milliseconds: 391),

new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 42, milliseconds: 770),

new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 22, milliseconds: 853),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 8, milliseconds: 650),

new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 36, milliseconds: 876),

new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 28, milliseconds: 764),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 48, milliseconds: 980),

new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 0, milliseconds: 326),

new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 53, milliseconds: 333),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 52, milliseconds: 521),

new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 44, milliseconds: 885),

new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 38, milliseconds: 879),

new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 48, milliseconds: 586),

},
},
            new TimeSpanintervalArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 52, milliseconds: 860),

new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 0, milliseconds: 427),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 52, milliseconds: 60),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 56, milliseconds: 958),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 9, milliseconds: 518),

new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 46, milliseconds: 143),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 10, milliseconds: 390),

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
new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 55, milliseconds: 315),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 31, milliseconds: 357),

new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 28, milliseconds: 800),

new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 28, milliseconds: 204),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 2, milliseconds: 421),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 35, milliseconds: 565),

new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 1, milliseconds: 913),

new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 23, milliseconds: 797),

},
},
            new TimeSpanintervalArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 16, milliseconds: 797),

new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 12, milliseconds: 258),

new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 43, milliseconds: 489),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 16, milliseconds: 723),

new TimeSpan(days: 0, hours: 8, minutes: 45, seconds: 33, milliseconds: 972),

new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 58, milliseconds: 729),

new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 1, milliseconds: 40),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 19, milliseconds: 282),

new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 36, milliseconds: 9),

new TimeSpan(days: 0, hours: 13, minutes: 32, seconds: 56, milliseconds: 576),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 22, milliseconds: 72),

new TimeSpan(days: 0, hours: 15, minutes: 6, seconds: 57, milliseconds: 827),

new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 34, milliseconds: 49),

new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 48, milliseconds: 547),

},
},
            new TimeSpanintervalArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 13, milliseconds: 861),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 19, milliseconds: 985),

new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 17, milliseconds: 354),

new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 55, milliseconds: 666),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 17, milliseconds: 253),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 56, milliseconds: 814),

new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 38, milliseconds: 809),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 17, milliseconds: 409),

new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 4, milliseconds: 219),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 828),

new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 24, milliseconds: 120),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 27, milliseconds: 575),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 27, milliseconds: 657),

new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 21, milliseconds: 933),

new TimeSpan(days: 0, hours: 19, minutes: 50, seconds: 27, milliseconds: 499),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 0, milliseconds: 163),

new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 36, milliseconds: 373),

new TimeSpan(days: 0, hours: 7, minutes: 52, seconds: 18, milliseconds: 311),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 21, milliseconds: 117),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 57, milliseconds: 396),

new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 3, milliseconds: 238),

new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 23, milliseconds: 100),

new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 56, milliseconds: 212),

},
},
            new TimeSpanintervalArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 32, milliseconds: 301),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 48, milliseconds: 454),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 21, milliseconds: 53),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 35, milliseconds: 445),

new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 50, milliseconds: 605),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 57, milliseconds: 886),

},
},
            new TimeSpanintervalArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 51, milliseconds: 529),

new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 29, milliseconds: 977),

new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 4, milliseconds: 377),

new TimeSpan(days: 0, hours: 8, minutes: 26, seconds: 35, milliseconds: 834),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 42, milliseconds: 538),

new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 8, milliseconds: 492),

new TimeSpan(days: 0, hours: 16, minutes: 29, seconds: 41, milliseconds: 977),

new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 40, milliseconds: 849),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 51, milliseconds: 6),

new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 33, milliseconds: 569),

new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 49, milliseconds: 553),

new TimeSpan(days: 0, hours: 22, minutes: 0, seconds: 55, milliseconds: 668),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 8, milliseconds: 657),

new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 1, milliseconds: 41),

new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 20, milliseconds: 844),

new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 9, milliseconds: 511),

},
},
            new TimeSpanintervalArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 55, milliseconds: 471),

new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 9, milliseconds: 617),

new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 6, milliseconds: 588),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 21, milliseconds: 951),

new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 7, milliseconds: 930),

new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 48, milliseconds: 385),

new TimeSpan(days: 0, hours: 8, minutes: 40, seconds: 8, milliseconds: 227),

},
},
            new TimeSpanintervalArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 52, seconds: 26, milliseconds: 385),

new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 19, milliseconds: 131),

new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 9, milliseconds: 942),

new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 51, milliseconds: 174),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 11, milliseconds: 981),

new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 5, milliseconds: 57),

new TimeSpan(days: 0, hours: 20, minutes: 53, seconds: 33, milliseconds: 605),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 44, milliseconds: 17),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 56, milliseconds: 214),

new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 35, milliseconds: 8),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 44, milliseconds: 371),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 56, milliseconds: 514),

new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 9, milliseconds: 165),

new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 45, milliseconds: 728),

new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 20, milliseconds: 690),

},
},
            new TimeSpanintervalArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 45, milliseconds: 293),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 21, milliseconds: 272),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 54, milliseconds: 806),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 18, milliseconds: 162),

new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 56, milliseconds: 481),

new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 15, milliseconds: 221),

new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 58, milliseconds: 282),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 42, milliseconds: 177),

new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 17, milliseconds: 219),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 20, milliseconds: 63),

new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 15, milliseconds: 21),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 14, milliseconds: 982),

new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 42, milliseconds: 477),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 25, milliseconds: 484),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 50, milliseconds: 694),

new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 47, milliseconds: 605),

new TimeSpan(days: 0, hours: 21, minutes: 11, seconds: 2, milliseconds: 479),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 39, milliseconds: 960),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 9, milliseconds: 19),

new TimeSpan(days: 0, hours: 16, minutes: 21, seconds: 5, milliseconds: 116),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 19, milliseconds: 485),

new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 28, milliseconds: 814),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 12, milliseconds: 149),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 43, milliseconds: 705),

new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 50, milliseconds: 312),

new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 15, milliseconds: 307),

},
},
            new TimeSpanintervalArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 8, milliseconds: 156),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 28, milliseconds: 715),

new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 34, milliseconds: 305),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 30, milliseconds: 138),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 24, milliseconds: 906),

new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 28, milliseconds: 974),

new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 50, milliseconds: 878),

new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 57, milliseconds: 306),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 50, milliseconds: 646),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 18, milliseconds: 887),

new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 24, milliseconds: 871),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 23, milliseconds: 982),

new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 3, milliseconds: 906),

new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 33, milliseconds: 352),

new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 48, milliseconds: 499),

},
},
            new TimeSpanintervalArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 23, milliseconds: 345),

new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 5, milliseconds: 734),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 51, milliseconds: 742),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 41, milliseconds: 628),

new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 29, milliseconds: 480),

new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 4, milliseconds: 473),

},
},
            new TimeSpanintervalArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 22, milliseconds: 200),

new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 44, milliseconds: 537),

new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 22, milliseconds: 620),

new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 41, milliseconds: 780),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 207),

new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 3, milliseconds: 608),

new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 36, milliseconds: 938),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 15, milliseconds: 447),

new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 31, milliseconds: 485),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 51, milliseconds: 594),

new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 48, milliseconds: 192),

},
},
            new TimeSpanintervalArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 18, milliseconds: 805),

new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 37, milliseconds: 92),

new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 54, milliseconds: 508),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 55, milliseconds: 393),

new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 16, milliseconds: 827),

new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 30, milliseconds: 637),

new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 46, milliseconds: 352),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 7, milliseconds: 484),

new TimeSpan(days: 0, hours: 22, minutes: 57, seconds: 40, milliseconds: 68),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 55, milliseconds: 449),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 45, milliseconds: 40),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 44, milliseconds: 968),

new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 38, milliseconds: 420),

new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 19, milliseconds: 561),

new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 49, milliseconds: 595),

},
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 13, milliseconds: 191),

new TimeSpan(days: 0, hours: 12, minutes: 51, seconds: 29, milliseconds: 839),

new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 189),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 40, milliseconds: 759),

new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 58, milliseconds: 336),

new TimeSpan(days: 0, hours: 16, minutes: 29, seconds: 45, milliseconds: 685),

new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 30, milliseconds: 379),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 25, milliseconds: 692),

new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 34, milliseconds: 545),

new TimeSpan(days: 0, hours: 22, minutes: 48, seconds: 56, milliseconds: 215),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 25, milliseconds: 555),

new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 41, milliseconds: 494),

new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 57, milliseconds: 993),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 58, milliseconds: 604),

new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 8, milliseconds: 579),

new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 16, milliseconds: 965),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 25, milliseconds: 76),

},
    ModelInner = new TimeSpanintervalArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 20, milliseconds: 871),

new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 2, milliseconds: 764),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 37, milliseconds: 199),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 54, seconds: 11, milliseconds: 363),

new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 3, milliseconds: 306),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 15, milliseconds: 867),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 22, milliseconds: 720),

new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 42, milliseconds: 795),

new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 0, milliseconds: 777),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 33, milliseconds: 357),

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 32, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ITimeSpanListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((ITimeSpanListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray2M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                await ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 47, query2))
                {
                    if(++resultIndex == 1)
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
                 ((ITimeSpanListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 59, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[14], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[15], false);
                        TimeSpanintervalArray2M.AssertModel(models[2],_testData[16], false);
                        TimeSpanintervalArray2M.AssertModel(models[3],_testData[17], false);
                        TimeSpanintervalArray2M.AssertModel(models[4],_testData[18], false);
                        TimeSpanintervalArray2M.AssertModel(models[5],_testData[19], false);
                        TimeSpanintervalArray2M.AssertModel(models[6],_testData[20], false);
                        TimeSpanintervalArray2M.AssertModel(models[7],_testData[21], false);
                        TimeSpanintervalArray2M.AssertModel(models[8],_testData[22], false);
                        TimeSpanintervalArray2M.AssertModel(models[9],_testData[23], false);
                        TimeSpanintervalArray2M.AssertModel(models[10],_testData[24], false);
                        TimeSpanintervalArray2M.AssertModel(models[11],_testData[25], false);
                        TimeSpanintervalArray2M.AssertModel(models[12],_testData[26], false);
                        TimeSpanintervalArray2M.AssertModel(models[13],_testData[27], false);
                        TimeSpanintervalArray2M.AssertModel(models[14],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalArray2M.AssertModel(models[0],_testData[28], false);
                        TimeSpanintervalArray2M.AssertModel(models[1],_testData[29], false);
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
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray2M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray2M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray2M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray2M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray2M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray2M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray2M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray2M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray2M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray2M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray2M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray2M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray2M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray2M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray2M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray2M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
TimeSpanintervalArray2M.AssertModel(models[0],_testData[26], false);TimeSpanintervalArray2M.AssertModel(models[1],_testData[27], false);TimeSpanintervalArray2M.AssertModel(models[2],_testData[28], false);TimeSpanintervalArray2M.AssertModel(models[3],_testData[29], false);
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

