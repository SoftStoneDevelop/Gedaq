

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
    internal partial interface ITimeSpanArrayintervalArray
    {
    }
    
    internal partial class TimeSpanArrayintervalArray : ITimeSpanArrayintervalArray
    {


#region TestData

        private readonly TimeSpanintervalArray1M[] _testData = new TimeSpanintervalArray1M[]
        {
            new TimeSpanintervalArray1M
{
    Id = 2,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 0, milliseconds: 352),
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 29, milliseconds: 325),
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 58, milliseconds: 665),
new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 23, milliseconds: 577),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 38, milliseconds: 981),
new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 26, milliseconds: 446),
new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 18, milliseconds: 618),
},
},
            new TimeSpanintervalArray1M
{
    Id = 11,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 12, milliseconds: 200),
new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 7, milliseconds: 432),
new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 19, milliseconds: 298),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 15, milliseconds: 690),
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 1, milliseconds: 418),
new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 5, milliseconds: 449),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 13,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 42, milliseconds: 623),
new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 55, milliseconds: 816),
new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 31, milliseconds: 967),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 30, milliseconds: 818),
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 2, milliseconds: 48),
new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 22, milliseconds: 928),
new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 6, milliseconds: 462),
},
},
            new TimeSpanintervalArray1M
{
    Id = 16,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 31, milliseconds: 399),
new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 15, milliseconds: 152),
new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 39, milliseconds: 415),
new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 34, milliseconds: 502),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 27, milliseconds: 224),
new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 14, milliseconds: 384),
new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 45, milliseconds: 171),
new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 26, milliseconds: 619),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 17,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 15, milliseconds: 310),
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 24, milliseconds: 45),
new TimeSpan(days: 0, hours: 13, minutes: 47, seconds: 13, milliseconds: 812),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 25,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 30, milliseconds: 739),
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 23, milliseconds: 325),
new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 12, milliseconds: 780),
new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 50, milliseconds: 22),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 30, milliseconds: 573),
new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 13, milliseconds: 412),
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 22, milliseconds: 118),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 13, milliseconds: 490),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 30, milliseconds: 879),
new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 50, milliseconds: 706),
new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 40, milliseconds: 238),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 0, milliseconds: 415),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 49, milliseconds: 285),
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 31, milliseconds: 686),
new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 26, milliseconds: 100),
},
},
            new TimeSpanintervalArray1M
{
    Id = 28,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 33, milliseconds: 916),
new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 39, milliseconds: 862),
new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 46, milliseconds: 2),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 35,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 17, milliseconds: 269),
new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 41, milliseconds: 985),
new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 1, milliseconds: 184),
new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 57, milliseconds: 614),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 51, milliseconds: 144),
new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 6, milliseconds: 989),
new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 1, milliseconds: 419),
new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 22, milliseconds: 844),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 48, milliseconds: 504),
new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 11, milliseconds: 983),
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 15, milliseconds: 658),
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 12, milliseconds: 403),
},
},
            new TimeSpanintervalArray1M
{
    Id = 41,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 31, milliseconds: 535),
new TimeSpan(days: 0, hours: 14, minutes: 36, seconds: 52, milliseconds: 910),
new TimeSpan(days: 0, hours: 1, minutes: 29, seconds: 26, milliseconds: 647),
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 25, milliseconds: 35),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 29, milliseconds: 24),
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 43, milliseconds: 120),
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 630),
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 11, milliseconds: 701),
},
},
            new TimeSpanintervalArray1M
{
    Id = 42,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 38, milliseconds: 705),
new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 3, milliseconds: 185),
new TimeSpan(days: 0, hours: 0, minutes: 4, seconds: 29, milliseconds: 498),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 32,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 49, milliseconds: 164),
new TimeSpan(days: 0, hours: 13, minutes: 56, seconds: 47, milliseconds: 637),
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 25, milliseconds: 601),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 44,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 8, milliseconds: 411),
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 50, milliseconds: 765),
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 7, milliseconds: 178),
new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 50, milliseconds: 509),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 7, milliseconds: 809),
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 43, milliseconds: 313),
new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 29, milliseconds: 200),
},
},
            new TimeSpanintervalArray1M
{
    Id = 51,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 22, milliseconds: 834),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 13, milliseconds: 248),
new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 43, milliseconds: 683),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 41,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 52, milliseconds: 919),
new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 45, milliseconds: 178),
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 40, milliseconds: 218),
new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 2, milliseconds: 13),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 57,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 48, milliseconds: 333),
new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 28, milliseconds: 977),
new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 5, milliseconds: 647),
new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 26, milliseconds: 479),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 59,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 10, milliseconds: 641),
new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 56, milliseconds: 828),
new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 50, milliseconds: 23),
new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 41, milliseconds: 139),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 24, milliseconds: 758),
new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 32, milliseconds: 292),
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 18, milliseconds: 626),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 49, milliseconds: 86),
new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 28, milliseconds: 346),
new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 15, milliseconds: 42),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 66,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 10, milliseconds: 438),
new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 3, milliseconds: 875),
new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 35, milliseconds: 847),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 26, milliseconds: 872),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 32, milliseconds: 659),
new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 26, milliseconds: 643),
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 31, milliseconds: 952),
new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 50, milliseconds: 741),
},
},
            new TimeSpanintervalArray1M
{
    Id = 74,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 42, milliseconds: 452),
new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 22, milliseconds: 21),
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 22, milliseconds: 415),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 55,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 28, milliseconds: 822),
new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 20, milliseconds: 653),
new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 14, milliseconds: 522),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 21, milliseconds: 172),
new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 24, milliseconds: 100),
new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 14, milliseconds: 311),
new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 2, milliseconds: 296),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 1, seconds: 35, milliseconds: 33),
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 29, milliseconds: 103),
new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 20, milliseconds: 687),
new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 9, milliseconds: 752),
},
},
            new TimeSpanintervalArray1M
{
    Id = 78,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 29, milliseconds: 816),
new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 55, milliseconds: 847),
new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 0, milliseconds: 447),
new TimeSpan(days: 0, hours: 10, minutes: 5, seconds: 13, milliseconds: 3),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 85,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 22, milliseconds: 901),
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 57, milliseconds: 445),
new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 45, milliseconds: 153),
new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 30, milliseconds: 728),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 6, milliseconds: 523),
new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 2, milliseconds: 219),
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 17, milliseconds: 332),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 21, milliseconds: 25),
new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 46, milliseconds: 876),
new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 51, milliseconds: 810),
new TimeSpan(days: 0, hours: 18, minutes: 34, seconds: 7, milliseconds: 912),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 58, milliseconds: 681),
new TimeSpan(days: 0, hours: 1, minutes: 5, seconds: 57, milliseconds: 616),
new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 34, milliseconds: 886),
},
},
            new TimeSpanintervalArray1M
{
    Id = 90,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 23, milliseconds: 779),
new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 23, milliseconds: 971),
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 11, milliseconds: 923),
new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 45, milliseconds: 121),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 27, milliseconds: 741),
new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 34, milliseconds: 948),
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 24, milliseconds: 383),
new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 14, milliseconds: 755),
},
},
            new TimeSpanintervalArray1M
{
    Id = 96,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 50, milliseconds: 655),
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 52, milliseconds: 778),
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 56, milliseconds: 371),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 59,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 40, milliseconds: 988),
new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 54, milliseconds: 643),
new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 15, milliseconds: 747),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 17, milliseconds: 393),
new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 48, milliseconds: 234),
new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 37, milliseconds: 852),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 49, milliseconds: 425),
new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 21, milliseconds: 975),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 18, milliseconds: 164),
},
},
            new TimeSpanintervalArray1M
{
    Id = 103,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 41, milliseconds: 927),
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 12, milliseconds: 903),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 46, milliseconds: 164),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 111,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 51, milliseconds: 768),
new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 27, milliseconds: 275),
new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 2, milliseconds: 281),
new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 12, milliseconds: 9),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 60,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 55, milliseconds: 532),
new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 1, milliseconds: 649),
new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 46, milliseconds: 823),
new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 43, milliseconds: 604),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 30, milliseconds: 469),
new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 42, milliseconds: 120),
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 48, milliseconds: 726),
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 35, milliseconds: 206),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 51, milliseconds: 498),
new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 50, milliseconds: 210),
new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 20, milliseconds: 678),
new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 6, milliseconds: 223),
},
},
            new TimeSpanintervalArray1M
{
    Id = 117,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 55, milliseconds: 319),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 36, milliseconds: 22),
new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 16, milliseconds: 280),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 21, milliseconds: 613),
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 50, milliseconds: 446),
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 16, milliseconds: 865),
},
},
            new TimeSpanintervalArray1M
{
    Id = 119,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 41, milliseconds: 902),
new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 34, milliseconds: 548),
new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 9, milliseconds: 419),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 33, milliseconds: 938),
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 3, milliseconds: 703),
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 40, milliseconds: 269),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 58, milliseconds: 452),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 3, milliseconds: 364),
new TimeSpan(days: 0, hours: 13, minutes: 17, seconds: 34, milliseconds: 209),
new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 28, milliseconds: 575),
new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 15, milliseconds: 940),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 9, milliseconds: 109),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 38, milliseconds: 488),
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 31, milliseconds: 944),
},
},
            new TimeSpanintervalArray1M
{
    Id = 127,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 36, milliseconds: 824),
new TimeSpan(days: 0, hours: 21, minutes: 38, seconds: 55, milliseconds: 742),
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 1, milliseconds: 608),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 6, milliseconds: 485),
new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 45, milliseconds: 180),
new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 9, milliseconds: 894),
},
},
            new TimeSpanintervalArray1M
{
    Id = 136,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 58, milliseconds: 678),
new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 14, milliseconds: 593),
new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 20, milliseconds: 116),
new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 14, milliseconds: 255),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 1, milliseconds: 21),
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 0, milliseconds: 249),
new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 34, milliseconds: 369),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 139,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 6, milliseconds: 87),
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 5, milliseconds: 756),
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 3, milliseconds: 464),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 43, milliseconds: 741),
new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 35, milliseconds: 176),
new TimeSpan(days: 0, hours: 21, minutes: 11, seconds: 2, milliseconds: 238),
new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 24, milliseconds: 345),
},
},
            new TimeSpanintervalArray1M
{
    Id = 141,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 53, milliseconds: 584),
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 45, milliseconds: 196),
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 17, milliseconds: 458),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 75,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 47, milliseconds: 509),
new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 8, milliseconds: 365),
new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 3, milliseconds: 545),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 53, milliseconds: 407),
new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 20, milliseconds: 275),
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 29, milliseconds: 240),
new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 2, milliseconds: 702),
},
},
            new TimeSpanintervalArray1M
{
    Id = 149,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 34, milliseconds: 872),
new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 18, milliseconds: 903),
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 33, milliseconds: 113),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 41, milliseconds: 284),
new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 10, milliseconds: 365),
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 48, milliseconds: 397),
new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 9, milliseconds: 634),
},
},
            new TimeSpanintervalArray1M
{
    Id = 151,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 4, milliseconds: 621),
new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 1, milliseconds: 593),
new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 51, milliseconds: 930),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 82,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 51, milliseconds: 905),
new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 49, milliseconds: 505),
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 38, milliseconds: 675),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 54, milliseconds: 425),
new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 3, milliseconds: 170),
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 16, milliseconds: 313),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 13, milliseconds: 97),
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 28, milliseconds: 155),
new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 27, milliseconds: 683),
new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 43, milliseconds: 5),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1mi(
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1mi(
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
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
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

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray1mi_id", 
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
                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 0, milliseconds: 415),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 49, milliseconds: 285),
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 31, milliseconds: 686),
new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 26, milliseconds: 100),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 48, milliseconds: 504),
new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 11, milliseconds: 983),
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 15, milliseconds: 658),
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 12, milliseconds: 403),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 29, milliseconds: 24),
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 43, milliseconds: 120),
new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 48, milliseconds: 630),
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 11, milliseconds: 701),
}));
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 7, milliseconds: 809),
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 43, milliseconds: 313),
new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 29, milliseconds: 200),
}));
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray1M> models = null;

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray1M> models = null;

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanArrayintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 139;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 2, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[1], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[2], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[3], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[4], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[5], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[26],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[27],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 66, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeSpanArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
                await ((ITimeSpanArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
FROM public.binary_timespanintervalarray1m m
LEFT JOIN public.binary_timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray1M>(15);

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
                ((ITimeSpanArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeSpanArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[14], false);
                TimeSpanintervalArray1M.AssertModel(models[15],_testData[15], false);
                TimeSpanintervalArray1M.AssertModel(models[16],_testData[16], false);
                TimeSpanintervalArray1M.AssertModel(models[17],_testData[17], false);
                TimeSpanintervalArray1M.AssertModel(models[18],_testData[18], false);
                TimeSpanintervalArray1M.AssertModel(models[19],_testData[19], false);
                TimeSpanintervalArray1M.AssertModel(models[20],_testData[20], false);
                TimeSpanintervalArray1M.AssertModel(models[21],_testData[21], false);
                TimeSpanintervalArray1M.AssertModel(models[22],_testData[22], false);
                TimeSpanintervalArray1M.AssertModel(models[23],_testData[23], false);
                TimeSpanintervalArray1M.AssertModel(models[24],_testData[24], false);
                TimeSpanintervalArray1M.AssertModel(models[25],_testData[25], false);
                TimeSpanintervalArray1M.AssertModel(models[26],_testData[26], false);
                TimeSpanintervalArray1M.AssertModel(models[27],_testData[27], false);
                TimeSpanintervalArray1M.AssertModel(models[28],_testData[28], false);
                TimeSpanintervalArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArrayintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArrayintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

