

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 9, milliseconds: 78),

new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 5, milliseconds: 737),

new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 31, milliseconds: 588),

new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 3, milliseconds: 17),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 21, milliseconds: 234),

new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 43, milliseconds: 654),

new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 24, milliseconds: 870),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 20, seconds: 43, milliseconds: 953),

new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 22, milliseconds: 170),

new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 53, milliseconds: 269),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 5, milliseconds: 283),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 16, milliseconds: 941),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 21, milliseconds: 310),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 44, milliseconds: 541),

new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 8, milliseconds: 456),

new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 38, milliseconds: 207),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 14, milliseconds: 716),

new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 19, milliseconds: 81),

new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 26, milliseconds: 613),

new TimeSpan(days: 0, hours: 5, minutes: 13, seconds: 49, milliseconds: 328),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 21, milliseconds: 803),

new TimeSpan(days: 0, hours: 2, minutes: 15, seconds: 11, milliseconds: 425),

new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 42, milliseconds: 585),

new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 1, milliseconds: 282),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 25, milliseconds: 276),

new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 13, milliseconds: 268),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 13, milliseconds: 381),

new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 15, milliseconds: 899),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 40, milliseconds: 519),

new TimeSpan(days: 0, hours: 2, minutes: 41, seconds: 52, milliseconds: 528),

new TimeSpan(days: 0, hours: 15, minutes: 21, seconds: 44, milliseconds: 48),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 28, milliseconds: 225),

new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 14, milliseconds: 816),

new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 8, milliseconds: 710),

new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 34, milliseconds: 919),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 6, milliseconds: 197),

new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 11, milliseconds: 352),

new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 12, milliseconds: 736),

new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 6, milliseconds: 97),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 4, milliseconds: 424),

new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 15, milliseconds: 969),

new TimeSpan(days: 0, hours: 10, minutes: 17, seconds: 48, milliseconds: 384),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 41, seconds: 4, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 10, milliseconds: 411),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 916),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 46, milliseconds: 447),

new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 16, milliseconds: 944),

new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 50, milliseconds: 331),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 29, milliseconds: 763),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 12, milliseconds: 968),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 45, milliseconds: 244),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 37, milliseconds: 846),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 1, milliseconds: 930),

new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 58, milliseconds: 298),

new TimeSpan(days: 0, hours: 4, minutes: 0, seconds: 1, milliseconds: 692),

new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 53, milliseconds: 526),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 56, milliseconds: 487),

new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 28, milliseconds: 494),

new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 53, milliseconds: 174),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 21, milliseconds: 398),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 53, milliseconds: 472),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 2, milliseconds: 626),

new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 1, milliseconds: 583),

new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 27, milliseconds: 900),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 46, milliseconds: 223),

new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 16, milliseconds: 997),

new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 3, milliseconds: 982),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 58, milliseconds: 820),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 48, seconds: 37, milliseconds: 942),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 40, milliseconds: 794),

new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 29, milliseconds: 712),

new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 51, milliseconds: 203),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 21, milliseconds: 81),

new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 49, milliseconds: 300),

new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 4, milliseconds: 319),

new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 27, milliseconds: 887),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 50, milliseconds: 407),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 46, milliseconds: 680),

new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 11, milliseconds: 219),

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
new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 5, milliseconds: 674),

new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 28, milliseconds: 465),

new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 30, milliseconds: 338),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 31, milliseconds: 987),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 30, milliseconds: 101),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 56, milliseconds: 976),

new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 48, milliseconds: 426),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 10, milliseconds: 400),

new TimeSpan(days: 0, hours: 19, minutes: 52, seconds: 47, milliseconds: 908),

new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 52, milliseconds: 78),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 11, milliseconds: 90),

new TimeSpan(days: 0, hours: 10, minutes: 5, seconds: 51, milliseconds: 136),

new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 14, milliseconds: 673),

new TimeSpan(days: 0, hours: 8, minutes: 11, seconds: 31, milliseconds: 104),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 24, milliseconds: 132),

new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 56, milliseconds: 765),

new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 14, milliseconds: 524),

new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 58, milliseconds: 47),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 0, milliseconds: 618),

new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 11, milliseconds: 398),

new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 8, milliseconds: 230),

new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 53, milliseconds: 616),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 37, milliseconds: 695),

new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 34, milliseconds: 657),

new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 9, milliseconds: 495),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 23, milliseconds: 374),

new TimeSpan(days: 0, hours: 8, minutes: 27, seconds: 32, milliseconds: 72),

new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 45, milliseconds: 263),

new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 35, milliseconds: 654),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 26, milliseconds: 235),

new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 47, milliseconds: 900),

new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 11, milliseconds: 168),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 47, milliseconds: 219),

new TimeSpan(days: 0, hours: 13, minutes: 21, seconds: 50, milliseconds: 235),

new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 21, milliseconds: 880),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 32, milliseconds: 962),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 15, milliseconds: 216),

new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 34, milliseconds: 146),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 40, milliseconds: 393),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 46, milliseconds: 560),

new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 4, milliseconds: 653),

new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 51, milliseconds: 552),

new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 31, milliseconds: 843),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 21, milliseconds: 546),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 47, milliseconds: 781),

new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 48, milliseconds: 580),

new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 39, milliseconds: 754),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 58, milliseconds: 108),

new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 39, milliseconds: 179),

new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 18, milliseconds: 894),

new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 47, milliseconds: 424),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 31, milliseconds: 837),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 5, milliseconds: 896),

new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 21, milliseconds: 486),

new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 21, milliseconds: 912),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 16, milliseconds: 515),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 43, milliseconds: 949),

new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 2, milliseconds: 309),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 4, milliseconds: 410),

new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 39, milliseconds: 434),

new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 4, milliseconds: 910),

new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 2, milliseconds: 320),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 37, milliseconds: 352),

new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 47, milliseconds: 651),

new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 20, milliseconds: 945),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 45, milliseconds: 86),

new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 1, milliseconds: 805),

new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 16, milliseconds: 981),

new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 35, milliseconds: 50),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 17, seconds: 53, milliseconds: 196),

new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 3, milliseconds: 636),

new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 7, milliseconds: 697),

new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 55, milliseconds: 753),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 11, milliseconds: 49),

new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 27, milliseconds: 146),

new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 2, milliseconds: 634),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 48, milliseconds: 964),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 20, milliseconds: 637),

new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 5, milliseconds: 931),

new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 407),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 20, milliseconds: 665),

new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 39, milliseconds: 899),

new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 27, milliseconds: 130),

new TimeSpan(days: 0, hours: 16, minutes: 45, seconds: 0, milliseconds: 334),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 34, milliseconds: 897),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 42, milliseconds: 919),

new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 13, milliseconds: 170),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 34, milliseconds: 454),

new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 36, milliseconds: 940),

new TimeSpan(days: 0, hours: 0, minutes: 4, seconds: 13, milliseconds: 321),

new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 44, milliseconds: 356),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 23, milliseconds: 805),

new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 44, milliseconds: 249),

new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 45, milliseconds: 294),

new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 33, milliseconds: 880),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 0, milliseconds: 209),

new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 40, milliseconds: 873),

new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 9, milliseconds: 933),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 16, milliseconds: 699),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 8, milliseconds: 992),

new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 39, milliseconds: 793),

new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 32, milliseconds: 904),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 7, milliseconds: 662),

new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 1, milliseconds: 760),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 24, milliseconds: 576),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 28, milliseconds: 84),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 46, milliseconds: 899),

new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 42, milliseconds: 298),

new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 28, milliseconds: 996),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 8, milliseconds: 284),

new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 46, milliseconds: 293),

new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 1, milliseconds: 427),

new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 36, milliseconds: 689),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 5, milliseconds: 655),

new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 7, milliseconds: 698),

new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 33, milliseconds: 638),

new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 49, milliseconds: 23),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 48, milliseconds: 128),

new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 48, milliseconds: 158),

new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 45, milliseconds: 610),

new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 47, milliseconds: 610),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 0, milliseconds: 258),

new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 3, milliseconds: 114),

new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 55, milliseconds: 548),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 35, milliseconds: 77),

new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 25, milliseconds: 70),

new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 11, milliseconds: 511),

new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 38, milliseconds: 323),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 13, milliseconds: 791),

new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 48, milliseconds: 225),

new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 52, milliseconds: 660),

new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 1, milliseconds: 542),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 32, milliseconds: 986),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 32, milliseconds: 996),

new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 47, milliseconds: 874),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 45, milliseconds: 306),

new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 27, milliseconds: 743),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 32, milliseconds: 31),

},
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 13, milliseconds: 564),

new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 35, milliseconds: 138),

new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 31, milliseconds: 158),

new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 46, milliseconds: 576),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 47, milliseconds: 106),

new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 0, milliseconds: 410),

new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 17, milliseconds: 292),

new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 14, milliseconds: 934),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 39, milliseconds: 537),

new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 40, milliseconds: 896),

new TimeSpan(days: 0, hours: 10, minutes: 3, seconds: 4, milliseconds: 380),

new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 17, milliseconds: 746),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 51, milliseconds: 947),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 37, milliseconds: 361),

new TimeSpan(days: 0, hours: 22, minutes: 48, seconds: 19, milliseconds: 404),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 17, milliseconds: 940),

new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 40, milliseconds: 704),

new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 11, milliseconds: 70),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 45, milliseconds: 20),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 57, milliseconds: 194),

new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 42, milliseconds: 975),

new TimeSpan(days: 0, hours: 2, minutes: 15, seconds: 20, milliseconds: 542),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 49, milliseconds: 91),

new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 58, milliseconds: 256),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 49, milliseconds: 932),

new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 8, milliseconds: 69),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 22, milliseconds: 670),

new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 39, milliseconds: 893),

new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 17, milliseconds: 862),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 53, seconds: 35, milliseconds: 974),

new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 36, milliseconds: 843),

new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 0, milliseconds: 834),

new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 25, milliseconds: 280),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 55, milliseconds: 358),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 3, milliseconds: 595),

new TimeSpan(days: 0, hours: 11, minutes: 28, seconds: 50, milliseconds: 688),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 24, milliseconds: 536),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 45, milliseconds: 631),

new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 41, milliseconds: 419),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 40, milliseconds: 870),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 7, milliseconds: 312),

new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 32, milliseconds: 171),

new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 9, milliseconds: 383),

new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 2, milliseconds: 611),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 57, milliseconds: 31),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 33, milliseconds: 826),

new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 16, milliseconds: 208),

new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 0, milliseconds: 283),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 33, milliseconds: 937),

new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 33, milliseconds: 886),

new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 39, milliseconds: 394),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 3, seconds: 22, milliseconds: 756),

new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 31, milliseconds: 50),

new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 1, milliseconds: 230),

new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 13, milliseconds: 874),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 14, milliseconds: 391),

new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 36, milliseconds: 969),

new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 27, milliseconds: 905),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 51, milliseconds: 229),

new TimeSpan(days: 0, hours: 0, minutes: 11, seconds: 44, milliseconds: 673),

new TimeSpan(days: 0, hours: 13, minutes: 8, seconds: 49, milliseconds: 665),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 45, milliseconds: 544),

new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 5, milliseconds: 688),

new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 28, milliseconds: 528),

new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 30, milliseconds: 648),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 6, milliseconds: 148),

new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 16, milliseconds: 694),

new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 35, milliseconds: 815),

new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 35, milliseconds: 824),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 47, milliseconds: 289),

new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 54, milliseconds: 111),

new TimeSpan(days: 0, hours: 12, minutes: 51, seconds: 49, milliseconds: 414),

},
    ModelInner = new TimeSpanintervalListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 15, milliseconds: 973),

new TimeSpan(days: 0, hours: 21, minutes: 39, seconds: 57, milliseconds: 233),

new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 6, milliseconds: 280),

new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 27, milliseconds: 617),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 29, milliseconds: 609),

new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 15, milliseconds: 474),

new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 10, milliseconds: 695),

new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 52, milliseconds: 986),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 42, seconds: 51, milliseconds: 623),

new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 43, milliseconds: 471),

new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 13, milliseconds: 747),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 14, milliseconds: 865),

},
},
            new TimeSpanintervalListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 54, seconds: 17, milliseconds: 438),

new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 6, milliseconds: 1),

new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 4, milliseconds: 99),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 53, milliseconds: 711),

new TimeSpan(days: 0, hours: 22, minutes: 16, seconds: 47, milliseconds: 921),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 28, milliseconds: 894),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervallistd1e2mi(
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
INSERT INTO public.timespanintervallistd1e2mi(
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
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MI)],
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
    timespanintervallistd1e2mi_id
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
                methodParametrName: "timespanintervallistd1e2mi_id", 
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
    timespanintervallistd1e2mi_id
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
    timespanintervallistd1e2mi_id,
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
    timespanintervallistd1e2mi_id
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
    timespanintervallistd1e2mi_id,
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
                methodParametrName: "timespanintervallistd1e2mi_id", 
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
LEFT JOIN public.timespanintervallistd1e2mi mi ON mi.id = m.timespanintervallistd1e2mi_id
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
LEFT JOIN public.timespanintervallistd1e2mi mi ON mi.id = m.timespanintervallistd1e2mi_id
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
LEFT JOIN public.timespanintervallistd1e2mi mi ON mi.id = m.timespanintervallistd1e2mi_id
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[9], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[10], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[11], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[12], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[22],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[23],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[24],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[10], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[11], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[12], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[22],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[23],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[34], false);
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
                await ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 103, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
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
                 ((ITimeSpanListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 55, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((ITimeSpanListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 24, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[34], false);
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
                await ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpanintervalListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(models[29],_testData[34], false);
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
                 ((ITimeSpanListintervalListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatTimeSpanintervalListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
LEFT JOIN public.timespanintervallistd1e2mi mi ON mi.id = m.timespanintervallistd1e2mi_id
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
                foreach(var batchResult in await ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[4], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[5], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[6], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[7], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[4],_testData[8], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[5],_testData[9], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[6],_testData[10], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[7],_testData[11], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[8],_testData[12], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[9],_testData[13], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[10],_testData[14], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[11],_testData[15], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[12],_testData[16], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[13],_testData[17], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[14],_testData[18], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[15],_testData[19], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[16],_testData[20], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[17],_testData[21], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[18],_testData[22], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[19],_testData[23], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[20],_testData[24], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[21],_testData[25], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[22],_testData[26], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[23],_testData[27], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[24],_testData[28], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[25],_testData[29], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[26],_testData[30], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[27],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[28],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[29],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[30],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanListintervalListD1)this).DbConnectionSTSelectModelBatch(connection, 82, 160))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[31], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[32], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[2],_testData[33], false);
                        TimeSpanintervalListD1E2M.AssertModel(models[3],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(2));

                TimeSpanintervalListD1E2M.AssertModel(models[0],_testData[33], false);
                TimeSpanintervalListD1E2M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanListintervalListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalListD1)this).SetDbConnectionSelectModelParametrs(cmd, 82);
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
FROM public.binary_timespanintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
            queryMapType: typeof(TimeSpanintervalListD1E2MIWA),
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
            queryMapType: typeof(TimeSpanintervalListD1E2MIWA),
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanListintervalListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanListintervalListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MI)],
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
COPY public.binary_timespanintervallistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD1E2MI),
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
                var importCollection = new List<TimeSpanintervalListD1E2MI>(2);
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
                    TimeSpanintervalListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD1E2MI>(2);
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
                    TimeSpanintervalListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
COPY public.binary_timespanintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalListD1E2MIWA),
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalListD1E2MIWA
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(actual, expect, false);
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
timespanintervallistd1e2mi_id,
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
LEFT JOIN public.binary_timespanintervallistd1e2mi mi ON mi.id = m.timespanintervallistd1e2mi_id
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
    timespanintervallistd1e2mi_id,
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
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA), typeof(TimeSpanintervalListD1E2MIWA)],
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA), typeof(TimeSpanintervalListD1E2MIWA)],
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_timespanintervallistd1e2mi
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MI), typeof(TimeSpanintervalListD1E2MI)],
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
                var models1 = new List<TimeSpanintervalListD1E2MI>();
                var models2 = new List<TimeSpanintervalListD1E2MI>();
                await ((ITimeSpanListintervalListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD1E2MI>();
                var models2 = new List<TimeSpanintervalListD1E2MI>();
                ((ITimeSpanListintervalListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervallistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MI)],
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
                    TimeSpanintervalListD1E2MI.AssertModel(model, expectedModel, false);
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
                    TimeSpanintervalListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA), typeof(TimeSpanintervalListD1E2MIWA)],
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
                await ((ITimeSpanListintervalListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalListD1E2MIWA>();
                var models2 = new List<TimeSpanintervalListD1E2MIWA>();
                ((ITimeSpanListintervalListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalListD1E2MIWA)],
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                    TimeSpanintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

