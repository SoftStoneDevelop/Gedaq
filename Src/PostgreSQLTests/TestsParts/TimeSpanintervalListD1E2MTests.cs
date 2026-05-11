

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
    internal partial interface ITimeSpanListintervalListD1
    {
    }
    
    internal partial class TimeSpanListintervalListD1 : ITimeSpanListintervalListD1
    {


#region TestData

        private readonly TimeSpanintervalListD1E2M[] _testData = new TimeSpanintervalListD1E2M[]
        {
            new TimeSpanintervalListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 22, milliseconds: 565),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 54, milliseconds: 737),

new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 27, milliseconds: 674),

new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 22, milliseconds: 605),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 14, milliseconds: 785),

new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 7, milliseconds: 845),

new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 13, milliseconds: 699),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 2, milliseconds: 638),

new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 47, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 576),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 37, milliseconds: 64),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 27, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 20, seconds: 46, milliseconds: 2),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 39, milliseconds: 879),

new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 33, milliseconds: 304),

new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 26, milliseconds: 467),

new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 55, milliseconds: 271),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 57, milliseconds: 939),

new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 33, milliseconds: 976),

new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 30, milliseconds: 564),

new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 27, milliseconds: 268),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 19, milliseconds: 725),

new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 17, milliseconds: 642),

new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 50, milliseconds: 291),

new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 24, milliseconds: 587),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 54, milliseconds: 491),

new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 18, milliseconds: 24),

new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 18, milliseconds: 878),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 49, milliseconds: 895),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 47, milliseconds: 544),

new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 53, milliseconds: 754),

new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 20, milliseconds: 153),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 39, milliseconds: 492),

new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 52, milliseconds: 225),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 18, milliseconds: 887),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 20, milliseconds: 464),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 46, milliseconds: 134),

new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 18, milliseconds: 890),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 26, milliseconds: 973),

new TimeSpan(days: 0, hours: 21, minutes: 20, seconds: 49, milliseconds: 795),

new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 2, milliseconds: 154),

new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 49, milliseconds: 839),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 52, milliseconds: 193),

new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 14, milliseconds: 336),

new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 3, milliseconds: 467),

new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 3, milliseconds: 137),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 49, milliseconds: 463),

new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 44, milliseconds: 844),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 47, milliseconds: 218),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 36, milliseconds: 782),

new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 42, milliseconds: 665),

new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 48, milliseconds: 273),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 56, seconds: 41, milliseconds: 71),

new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 58, milliseconds: 845),

new TimeSpan(days: 0, hours: 17, minutes: 49, seconds: 27, milliseconds: 655),

new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 45, milliseconds: 813),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 56, milliseconds: 162),

new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 1, milliseconds: 956),

new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 44, milliseconds: 989),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 31, milliseconds: 170),

new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 44, milliseconds: 531),

new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 15, milliseconds: 53),

new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 47, milliseconds: 422),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 27, milliseconds: 945),

new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 7, milliseconds: 974),

new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 50, milliseconds: 648),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 19, milliseconds: 630),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 1, milliseconds: 246),

new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 35, milliseconds: 289),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 6, milliseconds: 56),

new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 42, milliseconds: 651),

new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 22, milliseconds: 48),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 48, milliseconds: 239),

new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 4, milliseconds: 39),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 55, milliseconds: 899),

new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 51, milliseconds: 956),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 53, milliseconds: 224),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 10, milliseconds: 490),

new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 40, milliseconds: 212),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 49, milliseconds: 401),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 20, milliseconds: 34),

new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 40, milliseconds: 261),

new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 37, milliseconds: 61),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 5, milliseconds: 155),

new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 7, milliseconds: 288),

new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 16, milliseconds: 451),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 37, milliseconds: 51),

new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 17, milliseconds: 363),

new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 4, milliseconds: 499),

new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 56, milliseconds: 451),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 57, milliseconds: 630),

new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 35, milliseconds: 554),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 28, milliseconds: 386),

new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 19, milliseconds: 43),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 26, milliseconds: 128),

new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 5, milliseconds: 751),

new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 6, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 2, milliseconds: 432),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 31, milliseconds: 28),

new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 19, milliseconds: 158),

new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 14, milliseconds: 265),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 36, milliseconds: 314),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 45, milliseconds: 669),

new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 30, milliseconds: 770),

new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 23, milliseconds: 162),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 2, milliseconds: 841),

new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 51, milliseconds: 906),

new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 29, milliseconds: 223),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 22, milliseconds: 727),

new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 15, milliseconds: 322),

new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 12, milliseconds: 692),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 0, milliseconds: 709),

new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 29, milliseconds: 164),

new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 3, milliseconds: 243),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 46, milliseconds: 633),

new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 3, milliseconds: 544),

new TimeSpan(days: 0, hours: 9, minutes: 34, seconds: 3, milliseconds: 605),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 18, milliseconds: 950),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 25, milliseconds: 64),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 2, milliseconds: 499),

new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 33, milliseconds: 679),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 12, milliseconds: 561),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 15, milliseconds: 613),

new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 52, milliseconds: 204),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 30, milliseconds: 530),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 8, milliseconds: 560),

new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 9, milliseconds: 65),

new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 420),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 36, milliseconds: 146),

new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 41, milliseconds: 761),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 42, milliseconds: 69),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 57, milliseconds: 425),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 34, milliseconds: 79),

new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 10, milliseconds: 761),

new TimeSpan(days: 0, hours: 1, minutes: 33, seconds: 26, milliseconds: 60),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 18, milliseconds: 48),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 20, milliseconds: 872),

new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 48, milliseconds: 642),

new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 22, milliseconds: 801),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 5, milliseconds: 840),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 38, milliseconds: 485),

new TimeSpan(days: 0, hours: 6, minutes: 8, seconds: 39, milliseconds: 917),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 3, milliseconds: 973),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 24, milliseconds: 881),

new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 26, milliseconds: 29),

new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 36, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 13, milliseconds: 792),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 54, milliseconds: 254),

new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 46, milliseconds: 987),

new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 1, milliseconds: 418),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 33, milliseconds: 240),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 5, milliseconds: 735),

new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 47, milliseconds: 750),

new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 42, milliseconds: 804),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 18, seconds: 25, milliseconds: 816),

new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 50, milliseconds: 744),

new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 26, milliseconds: 668),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 14, milliseconds: 106),

new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 23, milliseconds: 320),

new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 34, milliseconds: 572),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 29, milliseconds: 398),

new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 53, milliseconds: 535),

new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 20, milliseconds: 169),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 39, milliseconds: 335),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 25, milliseconds: 734),

new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 36, milliseconds: 255),

new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 48, milliseconds: 213),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 31, milliseconds: 574),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 32, milliseconds: 484),

new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 17, milliseconds: 842),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 1, milliseconds: 358),

new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 50, milliseconds: 703),

new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 50, milliseconds: 298),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 48, milliseconds: 716),

new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 31, milliseconds: 312),

new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 35, milliseconds: 358),

new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 57, milliseconds: 969),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 10, milliseconds: 377),

new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 57, milliseconds: 124),

new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 10, milliseconds: 807),

new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 8, milliseconds: 622),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 20, milliseconds: 403),

new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 33, milliseconds: 214),

new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 39, milliseconds: 611),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 6, milliseconds: 864),

new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 3, milliseconds: 995),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 46, milliseconds: 676),

new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 52, milliseconds: 265),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 4, milliseconds: 795),

new TimeSpan(days: 0, hours: 6, minutes: 28, seconds: 32, milliseconds: 719),

new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 28, milliseconds: 991),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 54, milliseconds: 473),

new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 31, milliseconds: 105),

new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 10, milliseconds: 440),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 13, milliseconds: 104),

new TimeSpan(days: 0, hours: 18, minutes: 14, seconds: 5, milliseconds: 436),

new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 43, milliseconds: 129),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 20, milliseconds: 304),

new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 33, milliseconds: 92),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 57, milliseconds: 966),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 4, milliseconds: 101),

new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 17, milliseconds: 235),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 48, milliseconds: 980),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 29, milliseconds: 54),

new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 23, milliseconds: 926),

new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 50, milliseconds: 866),

new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 9, milliseconds: 806),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 21, seconds: 42, milliseconds: 851),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 383),

new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 5, milliseconds: 664),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 55, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 26, seconds: 54, milliseconds: 876),

new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 8, milliseconds: 272),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 3, milliseconds: 452),

new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 12, milliseconds: 664),

new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 46, milliseconds: 119),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 7, milliseconds: 22),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 45, milliseconds: 882),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 22, milliseconds: 447),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 14, milliseconds: 649),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 43, milliseconds: 5),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 13, milliseconds: 39),

new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 3, milliseconds: 46),

new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 2, milliseconds: 375),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 22, milliseconds: 757),

new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 58, milliseconds: 513),

new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 9, milliseconds: 358),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 0, milliseconds: 647),

new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 53, milliseconds: 309),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 36, milliseconds: 281),

new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 0, milliseconds: 374),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 10, milliseconds: 631),

new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 53, milliseconds: 590),

new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 36, milliseconds: 19),

new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 27, milliseconds: 564),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 19, milliseconds: 732),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 19, milliseconds: 461),

new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 3, milliseconds: 405),

new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 44, milliseconds: 598),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 24, milliseconds: 519),

new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 33, milliseconds: 773),

new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 8, milliseconds: 40),

new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 10, milliseconds: 774),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 9, milliseconds: 568),

new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 5, milliseconds: 83),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 54, milliseconds: 545),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 14, milliseconds: 928),

new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 18, milliseconds: 619),

new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 17, milliseconds: 987),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 14, milliseconds: 803),

new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 56, milliseconds: 593),

new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 15, milliseconds: 910),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 17, milliseconds: 318),

new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 35, milliseconds: 149),

new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 5, milliseconds: 79),

},
    ModelInner = new TimeSpanintervalListD12MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 10, seconds: 50, milliseconds: 311),

new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 0, milliseconds: 765),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 13, milliseconds: 719),

new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 37, milliseconds: 580),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 51, milliseconds: 523),

new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 18, milliseconds: 289),

new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 2, milliseconds: 57),

new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 44, milliseconds: 241),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 39, milliseconds: 625),

new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 57, milliseconds: 248),

new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 41, milliseconds: 523),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervallistd12mi(
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
INSERT INTO public.timespanintervallistd12mi(
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
            queryMapTypes: [typeof(TimeSpanintervalListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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

                changedRows =  ((ITimeSpanListintervalListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListintervalListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanListintervalListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListintervalListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanListintervalListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanListintervalListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervallistd1e2m(
	id,
    value,
    nullablevalue,
    timespanintervallistd12mi_id
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)), 
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
                methodParametrName: "timespanintervallistd12mi_id", 
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
                changedRows =  ((ITimeSpanListintervalListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanListintervalListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanListintervalListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanListintervalListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervallistd1e2m(
	id,
    value,
    nullablevalue,
    timespanintervallistd12mi_id
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
    timespanintervallistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervallistd1e2m(
	id,
    value,
    nullablevalue,
    timespanintervallistd12mi_id
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
    timespanintervallistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                methodParametrName: "timespanintervallistd12mi_id", 
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
                List<TimeSpanintervalListD1E2M> models = null;

                models =  ((ITimeSpanListintervalListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeSpanListintervalListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeSpanListintervalListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeSpanListintervalListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalListD1E2M> models = null;

                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanListintervalListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M), typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                ((ITimeSpanListintervalListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanListintervalListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanListintervalListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
LEFT JOIN public.timespanintervallistd12mi mi ON mi.id = m.timespanintervallistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await ((ITimeSpanListintervalListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanListintervalListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M), typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                ((ITimeSpanListintervalListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanListintervalListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanListintervalListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
LEFT JOIN public.timespanintervallistd12mi mi ON mi.id = m.timespanintervallistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await ((ITimeSpanListintervalListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanListintervalListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M), typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                await((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
LEFT JOIN public.timespanintervallistd12mi mi ON mi.id = m.timespanintervallistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await((ITimeSpanListintervalListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[1], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[2], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[3], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[4], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[5], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[6], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[7], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[8], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[9], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[10], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[11], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[12], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[22],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[23],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[24],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[25],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[26],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[27],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[28],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[29],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[30],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[31],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[32],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[6], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[7], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[8], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[9], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[10], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[11], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[12], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[22],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[23],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[24],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[25],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[26],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[27],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((ITimeSpanListintervalListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M), typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                await((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 183, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalListD1E2M>();
                var models2 = new List<FlatTimeSpanintervalListD1E2M>();
                ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var firstItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                await ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[33],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
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
FROM public.timespanintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems1 = new List<FlatTimeSpanintervalListD1E2M>();
                var secondItems2 = new List<FlatTimeSpanintervalListD1E2M>();
                 ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 74, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.timespanintervallistd1e2m m
LEFT JOIN public.timespanintervallistd12mi mi ON mi.id = m.timespanintervallistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await((ITimeSpanListintervalListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 183, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((ITimeSpanListintervalListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelBatch(connection, 67, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanListintervalListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanListintervalListD1)this).SetDbConnectionSelectModelParametrs(cmd, 174);
                var models = await ((ITimeSpanListintervalListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[32], false);
                TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[33], false);
                TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalListD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((ITimeSpanListintervalListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[16], false);
                TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[17], false);
                TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[18], false);
                TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[19], false);
                TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[20], false);
                TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[21], false);
                TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[22], false);
                TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[23], false);
                TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[24], false);
                TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[25], false);
                TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[26], false);
                TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[27], false);
                TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[28], false);
                TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[29], false);
                TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[30], false);
                TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[31], false);
                TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[32], false);
                TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[33], false);
                TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_timespanintervallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD12MIWA),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanListintervalListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanListintervalListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanListintervalListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanListintervalListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervallistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD12MI),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanListintervalListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanListintervalListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalListD1)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanListintervalListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervallistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervallistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalListD1E2M),
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
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
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
FROM public.binary_timespanintervallistd1e2m m
LEFT JOIN public.binary_timespanintervallistd12mi mi ON mi.id = m.timespanintervallistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanListintervalListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanListintervalListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanListintervalListD1)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanListintervalListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervallistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervallistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models =  ((ITimeSpanListintervalListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanListintervalListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA), typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                await ((ITimeSpanListintervalListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                ((ITimeSpanListintervalListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await ((ITimeSpanListintervalListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervallistd12mi
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
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervallistd12mi
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
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA), typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                await ((ITimeSpanListintervalListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                ((ITimeSpanListintervalListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
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
                var models = await ((ITimeSpanListintervalListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervallistd12mi
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
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervallistd12mi
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
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MI), typeof(TimeSpanintervalListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models1 = new List<TimeSpanintervalListD12MI>();
                var models2 = new List<TimeSpanintervalListD12MI>();
                await ((ITimeSpanListintervalListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD12MI>();
                var models2 = new List<TimeSpanintervalListD12MI>();
                ((ITimeSpanListintervalListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervallistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1)),
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
                var models = await ((ITimeSpanListintervalListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervallistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA), typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                await ((ITimeSpanListintervalListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD12MIWA>();
                var models2 = new List<TimeSpanintervalListD12MIWA>();
                ((ITimeSpanListintervalListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervallistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalListD1))]
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
                var models = await ((ITimeSpanListintervalListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanListintervalListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

