

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
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 4, milliseconds: 56),
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 26, milliseconds: 300),
new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 31, milliseconds: 414),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 17, milliseconds: 813),
new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 25, milliseconds: 263),
new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 25, milliseconds: 572),
},
},
            new TimeSpanintervalArray1M
{
    Id = 5,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 10, milliseconds: 677),
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 0, milliseconds: 409),
new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 57, milliseconds: 481),
new TimeSpan(days: 0, hours: 16, minutes: 51, seconds: 55, milliseconds: 696),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 6,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 17, milliseconds: 738),
new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 12, milliseconds: 54),
new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 4, milliseconds: 844),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 15, milliseconds: 819),
new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 58, milliseconds: 481),
new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 34, milliseconds: 5),
new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 43, milliseconds: 510),
},
},
            new TimeSpanintervalArray1M
{
    Id = 6,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 42, milliseconds: 91),
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 21, milliseconds: 692),
new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 8, milliseconds: 480),
new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 54, milliseconds: 434),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 12, milliseconds: 621),
new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 27, milliseconds: 597),
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 41, milliseconds: 788),
},
},
            new TimeSpanintervalArray1M
{
    Id = 7,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 40, milliseconds: 216),
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 11, milliseconds: 51),
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 41, milliseconds: 436),
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 44, milliseconds: 998),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 32, milliseconds: 794),
new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 0, milliseconds: 655),
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 52, milliseconds: 795),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 24, milliseconds: 887),
new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 51, milliseconds: 412),
new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 47, milliseconds: 289),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 13,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 25, milliseconds: 136),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 45, milliseconds: 684),
new TimeSpan(days: 0, hours: 7, minutes: 2, seconds: 22, milliseconds: 526),
new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 37, milliseconds: 902),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 46, milliseconds: 818),
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 9, milliseconds: 204),
new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 46, milliseconds: 240),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 16, milliseconds: 573),
},
},
            new TimeSpanintervalArray1M
{
    Id = 18,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 10, milliseconds: 261),
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 16, milliseconds: 319),
new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 50, milliseconds: 354),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 22,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 58, milliseconds: 468),
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 19, milliseconds: 222),
new TimeSpan(days: 0, hours: 22, minutes: 0, seconds: 11, milliseconds: 660),
new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 10, milliseconds: 534),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 22,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 36, milliseconds: 983),
new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 57, milliseconds: 490),
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 18, milliseconds: 746),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 34, milliseconds: 567),
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 7, milliseconds: 350),
new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 26, milliseconds: 394),
},
},
            new TimeSpanintervalArray1M
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 51, milliseconds: 166),
new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 23, milliseconds: 840),
new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 7, milliseconds: 685),
new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 37, milliseconds: 846),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 2, milliseconds: 846),
new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 30, milliseconds: 870),
new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 42, milliseconds: 265),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 15, milliseconds: 293),
new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 12, milliseconds: 482),
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 36, milliseconds: 875),
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 14, milliseconds: 550),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 21, milliseconds: 629),
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 39, milliseconds: 634),
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 18, milliseconds: 995),
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 38, milliseconds: 376),
},
},
            new TimeSpanintervalArray1M
{
    Id = 32,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 37, milliseconds: 274),
new TimeSpan(days: 0, hours: 9, minutes: 8, seconds: 53, milliseconds: 320),
new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 0, milliseconds: 871),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 28, milliseconds: 946),
new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 56, milliseconds: 741),
new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 58, milliseconds: 593),
},
},
            new TimeSpanintervalArray1M
{
    Id = 34,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 13, milliseconds: 736),
new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 4, milliseconds: 689),
new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 58, milliseconds: 976),
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 58, milliseconds: 283),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 29,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 42, milliseconds: 152),
new TimeSpan(days: 0, hours: 8, minutes: 38, seconds: 31, milliseconds: 29),
new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 3, milliseconds: 137),
new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 13, milliseconds: 545),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 19, seconds: 45, milliseconds: 405),
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 32, milliseconds: 806),
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 15, milliseconds: 679),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 906),
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 8, milliseconds: 396),
new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 48, milliseconds: 629),
},
},
            new TimeSpanintervalArray1M
{
    Id = 40,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 37, milliseconds: 836),
new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 17, milliseconds: 59),
new TimeSpan(days: 0, hours: 8, minutes: 40, seconds: 31, milliseconds: 878),
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 44, milliseconds: 982),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 46,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 28, milliseconds: 541),
new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 55, milliseconds: 871),
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 43, milliseconds: 465),
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 52, milliseconds: 443),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 35,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 25, milliseconds: 233),
new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 42, milliseconds: 179),
new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 57, milliseconds: 92),
new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 24, milliseconds: 154),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 4, milliseconds: 508),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 31, milliseconds: 18),
new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 19, milliseconds: 695),
new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 32, milliseconds: 630),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 45, milliseconds: 402),
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 35, milliseconds: 192),
new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 5, milliseconds: 411),
},
},
            new TimeSpanintervalArray1M
{
    Id = 55,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 49, milliseconds: 83),
new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 19, milliseconds: 329),
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 48, milliseconds: 874),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 6, milliseconds: 785),
new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 37, milliseconds: 362),
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 38, milliseconds: 887),
new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 24, milliseconds: 815),
},
},
            new TimeSpanintervalArray1M
{
    Id = 59,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 25, milliseconds: 533),
new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 21, milliseconds: 820),
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 10, milliseconds: 660),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 26, milliseconds: 791),
new TimeSpan(days: 0, hours: 2, minutes: 45, seconds: 58, milliseconds: 239),
new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 37, milliseconds: 447),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 23, milliseconds: 13),
new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 45, milliseconds: 43),
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 22, milliseconds: 995),
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 36, milliseconds: 958),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 58, milliseconds: 229),
new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 28, milliseconds: 485),
new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 11, milliseconds: 490),
},
},
            new TimeSpanintervalArray1M
{
    Id = 63,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 35, milliseconds: 655),
new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 57, milliseconds: 777),
new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 43, milliseconds: 439),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 69,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 57, milliseconds: 837),
new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 10, milliseconds: 477),
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 40, milliseconds: 235),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 42,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 44, milliseconds: 728),
new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 42, milliseconds: 719),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 23, milliseconds: 523),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 14, milliseconds: 910),
new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 10, milliseconds: 363),
new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 52, milliseconds: 274),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 74,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 55, milliseconds: 612),
new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 22, milliseconds: 105),
new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 33, milliseconds: 809),
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 40, milliseconds: 592),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 40, milliseconds: 428),
new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 9, milliseconds: 873),
new TimeSpan(days: 0, hours: 4, minutes: 0, seconds: 53, milliseconds: 981),
},
},
            new TimeSpanintervalArray1M
{
    Id = 81,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 51, milliseconds: 688),
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 30, milliseconds: 550),
new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 10, milliseconds: 594),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 43,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 32, milliseconds: 610),
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 27, milliseconds: 480),
new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 1, milliseconds: 264),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 86,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 52, milliseconds: 832),
new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 44, milliseconds: 114),
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 22, milliseconds: 151),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 20, milliseconds: 522),
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 52, milliseconds: 223),
new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 56, milliseconds: 365),
},
},
            new TimeSpanintervalArray1M
{
    Id = 90,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 57, milliseconds: 415),
new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 33, milliseconds: 114),
new TimeSpan(days: 0, hours: 6, minutes: 22, seconds: 8, milliseconds: 747),
new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 35, milliseconds: 615),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 51,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 27, seconds: 54, milliseconds: 785),
new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 40, milliseconds: 867),
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 45, milliseconds: 724),
new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 43, milliseconds: 520),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 25, milliseconds: 611),
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 4, milliseconds: 353),
new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 9, milliseconds: 784),
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 46, milliseconds: 848),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 11, milliseconds: 937),
new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 54, milliseconds: 489),
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 55, milliseconds: 612),
},
},
            new TimeSpanintervalArray1M
{
    Id = 93,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 33, milliseconds: 333),
new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 48, milliseconds: 246),
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 11, milliseconds: 886),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 50, milliseconds: 173),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 20, milliseconds: 207),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 52, milliseconds: 797),
},
},
            new TimeSpanintervalArray1M
{
    Id = 102,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 21, milliseconds: 902),
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 18, milliseconds: 82),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 52, milliseconds: 622),
new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 31, milliseconds: 556),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 56,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 54, milliseconds: 473),
new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 8, milliseconds: 435),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 30, milliseconds: 174),
new TimeSpan(days: 0, hours: 19, minutes: 6, seconds: 56, milliseconds: 410),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 103,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 37, milliseconds: 535),
new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 33, milliseconds: 706),
new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 41, milliseconds: 575),
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 16, milliseconds: 378),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 109,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 44, milliseconds: 200),
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 50, milliseconds: 336),
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 627),
new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 37, milliseconds: 46),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 61,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 46, milliseconds: 633),
new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 10, milliseconds: 334),
new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 1, milliseconds: 820),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 110,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 53, milliseconds: 292),
new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 46, milliseconds: 995),
new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 44, milliseconds: 416),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 116,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 11, milliseconds: 560),
new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 33, milliseconds: 948),
new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 51, milliseconds: 794),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 68,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 26, milliseconds: 322),
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 20, milliseconds: 204),
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 34, milliseconds: 161),
new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 44, milliseconds: 206),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 50, milliseconds: 471),
new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 45, milliseconds: 76),
new TimeSpan(days: 0, hours: 16, minutes: 3, seconds: 31, milliseconds: 767),
new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 0, milliseconds: 713),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 20, milliseconds: 754),
new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 50, milliseconds: 304),
new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 40, milliseconds: 435),
},
},
            new TimeSpanintervalArray1M
{
    Id = 119,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 40, milliseconds: 440),
new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 19, milliseconds: 52),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 32, milliseconds: 292),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 33, milliseconds: 679),
new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 56, milliseconds: 541),
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 9, milliseconds: 845),
},
},
            new TimeSpanintervalArray1M
{
    Id = 122,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 13, seconds: 12, milliseconds: 836),
new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 15, milliseconds: 481),
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 32, milliseconds: 829),
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 23, milliseconds: 783),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 70,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 49, milliseconds: 591),
new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 27, milliseconds: 656),
new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 24, milliseconds: 741),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 13, milliseconds: 209),
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 9, milliseconds: 770),
new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 20, milliseconds: 713),
},
},
            new TimeSpanintervalArray1M
{
    Id = 127,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 22, milliseconds: 639),
new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 57, milliseconds: 281),
new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 12, milliseconds: 358),
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 6, milliseconds: 305),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 54, milliseconds: 513),
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 1, milliseconds: 521),
new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 51, milliseconds: 358),
},
},
            new TimeSpanintervalArray1M
{
    Id = 128,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 49, milliseconds: 692),
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 2, milliseconds: 710),
new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 21, milliseconds: 125),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 72,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 28, milliseconds: 14),
new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 10, milliseconds: 933),
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 28, milliseconds: 762),
new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 7, milliseconds: 545),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 135,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 57, milliseconds: 123),
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 15, milliseconds: 146),
new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 54, milliseconds: 631),
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 35, milliseconds: 124),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 140,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 8, milliseconds: 582),
new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 38, milliseconds: 938),
new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 41, milliseconds: 967),
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 9, milliseconds: 71),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 80,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 47, milliseconds: 637),
new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 19, milliseconds: 907),
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 30, milliseconds: 842),
new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 34, milliseconds: 956),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 145,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 17, milliseconds: 844),
new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 35, milliseconds: 817),
new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 10, milliseconds: 247),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 29, milliseconds: 119),
new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 24, milliseconds: 989),
new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 38, milliseconds: 406),
new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 22, milliseconds: 525),
},
},
            new TimeSpanintervalArray1M
{
    Id = 151,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 36, milliseconds: 58),
new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 7, milliseconds: 331),
new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 45, milliseconds: 824),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 85,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 14, milliseconds: 243),
new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 39, milliseconds: 235),
new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 48, milliseconds: 433),
new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 36, milliseconds: 651),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 157,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 56, milliseconds: 31),
new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 18, milliseconds: 261),
new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 25, milliseconds: 382),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 46, milliseconds: 818),
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 9, milliseconds: 204),
new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 46, milliseconds: 240),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 16, milliseconds: 573),
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 34, milliseconds: 567),
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 7, milliseconds: 350),
new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 26, milliseconds: 394),
}));
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
new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 21, milliseconds: 629),
new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 39, milliseconds: 634),
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 18, milliseconds: 995),
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 38, milliseconds: 376),
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
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 28, milliseconds: 946),
new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 56, milliseconds: 741),
new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 58, milliseconds: 593),
}));
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 45, milliseconds: 906),
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 8, milliseconds: 396),
new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 48, milliseconds: 629),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 45, milliseconds: 402),
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 35, milliseconds: 192),
new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 5, milliseconds: 411),
}));
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
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 2, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 145, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[34], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[27],_testData[34], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 127, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[34], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[27], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[28], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[29], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[30], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[31], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[32], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[33], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[29], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[30], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[31], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[32], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[33], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanArrayintervalArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanArrayintervalArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(TimeSpanintervalArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI), typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray1MI>();
                var models2 = new List<TimeSpanintervalArray1MI>();
                await ((ITimeSpanArrayintervalArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MI>();
                var models2 = new List<TimeSpanintervalArray1MI>();
                ((ITimeSpanArrayintervalArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

