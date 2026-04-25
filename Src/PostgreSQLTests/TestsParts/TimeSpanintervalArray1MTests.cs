

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
    Id = 7,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 0, milliseconds: 239),
new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 40, milliseconds: 333),
new TimeSpan(days: 0, hours: 17, minutes: 2, seconds: 10, milliseconds: 179),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 13, milliseconds: 2),
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 39, milliseconds: 278),
new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 4, milliseconds: 830),
},
},
            new TimeSpanintervalArray1M
{
    Id = 15,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 282),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 45, milliseconds: 352),
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 5, milliseconds: 213),
new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 16, milliseconds: 231),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 7,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 24, milliseconds: 552),
new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 42, milliseconds: 160),
new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 31, milliseconds: 739),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 10, milliseconds: 724),
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 58, milliseconds: 179),
new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 21, milliseconds: 464),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 19,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 21, milliseconds: 256),
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 5, milliseconds: 723),
new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 20, milliseconds: 138),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 24,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 48, seconds: 4, milliseconds: 856),
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 40, milliseconds: 475),
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 4, milliseconds: 721),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 13,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 36, milliseconds: 389),
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 4, milliseconds: 46),
new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 25, milliseconds: 492),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 33,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 36, milliseconds: 502),
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 43, milliseconds: 87),
new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 12, milliseconds: 916),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 58, milliseconds: 43),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 16, milliseconds: 341),
new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 43, milliseconds: 206),
new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 8, milliseconds: 71),
},
},
            new TimeSpanintervalArray1M
{
    Id = 35,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 44, milliseconds: 682),
new TimeSpan(days: 0, hours: 1, minutes: 5, seconds: 14, milliseconds: 310),
new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 43, milliseconds: 104),
new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 34, milliseconds: 635),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 39, milliseconds: 900),
new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 35, milliseconds: 370),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 43, milliseconds: 857),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 16, milliseconds: 847),
new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 43, milliseconds: 210),
new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 11, milliseconds: 449),
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 9, milliseconds: 950),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 57, milliseconds: 642),
new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 23, milliseconds: 940),
new TimeSpan(days: 0, hours: 7, minutes: 52, seconds: 18, milliseconds: 921),
},
},
            new TimeSpanintervalArray1M
{
    Id = 43,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 29, milliseconds: 63),
new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 1, milliseconds: 723),
new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 29, milliseconds: 166),
new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 22, milliseconds: 891),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 52,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 16, milliseconds: 970),
new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 33, milliseconds: 294),
new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 43, milliseconds: 598),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 56, milliseconds: 341),
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 16, milliseconds: 872),
new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 2, milliseconds: 308),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 45, milliseconds: 645),
new TimeSpan(days: 0, hours: 13, minutes: 17, seconds: 9, milliseconds: 96),
new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 47, milliseconds: 228),
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 41, milliseconds: 796),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 12, milliseconds: 370),
new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 32, milliseconds: 429),
new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 3, milliseconds: 340),
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 29, milliseconds: 605),
},
},
            new TimeSpanintervalArray1M
{
    Id = 54,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 43, milliseconds: 497),
new TimeSpan(days: 0, hours: 12, minutes: 41, seconds: 32, milliseconds: 205),
new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 31, milliseconds: 777),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 5, milliseconds: 786),
new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 17, milliseconds: 192),
new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 33, milliseconds: 380),
},
},
            new TimeSpanintervalArray1M
{
    Id = 61,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 48, milliseconds: 419),
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 36, milliseconds: 714),
new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 19, milliseconds: 879),
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 41, milliseconds: 123),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 20, milliseconds: 297),
new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 24, milliseconds: 34),
new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 52, milliseconds: 823),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 27, milliseconds: 759),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 35, milliseconds: 599),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 37, milliseconds: 942),
},
},
            new TimeSpanintervalArray1M
{
    Id = 68,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 39, milliseconds: 722),
new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 27, milliseconds: 912),
new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 0, milliseconds: 839),
new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 43, milliseconds: 923),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 74,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 20, milliseconds: 492),
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 18, milliseconds: 99),
new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 31, milliseconds: 945),
new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 32, milliseconds: 472),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 27,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 23, milliseconds: 700),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 52, milliseconds: 505),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 36, milliseconds: 897),
new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 48, milliseconds: 766),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 75,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 32, milliseconds: 723),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 36, milliseconds: 417),
new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 51, milliseconds: 953),
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 31, milliseconds: 270),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 82,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 24, milliseconds: 673),
new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 34, milliseconds: 983),
new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 50, milliseconds: 567),
new TimeSpan(days: 0, hours: 10, minutes: 30, seconds: 47, milliseconds: 153),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 44, milliseconds: 419),
new TimeSpan(days: 0, hours: 6, minutes: 52, seconds: 47, milliseconds: 928),
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 17, milliseconds: 712),
new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 47, milliseconds: 804),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 31, milliseconds: 813),
new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 42, milliseconds: 485),
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 36, milliseconds: 700),
},
},
            new TimeSpanintervalArray1M
{
    Id = 87,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 51, seconds: 46, milliseconds: 238),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 34, milliseconds: 119),
new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 9, milliseconds: 630),
new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 45, milliseconds: 780),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 5, milliseconds: 240),
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 3, milliseconds: 184),
new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 21, milliseconds: 247),
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 18, milliseconds: 466),
},
},
            new TimeSpanintervalArray1M
{
    Id = 89,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 4, milliseconds: 456),
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 46, milliseconds: 395),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 12, milliseconds: 688),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 31,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 20, milliseconds: 970),
new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 45, milliseconds: 550),
new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 31, milliseconds: 934),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 38, milliseconds: 631),
new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 10, milliseconds: 407),
new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 17, milliseconds: 273),
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 3, milliseconds: 788),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 49, milliseconds: 284),
new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 9, milliseconds: 291),
new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 26, milliseconds: 60),
},
},
            new TimeSpanintervalArray1M
{
    Id = 98,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 56, seconds: 16, milliseconds: 995),
new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 2, milliseconds: 357),
new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 24, milliseconds: 132),
new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 44, milliseconds: 930),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 101,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 29, milliseconds: 600),
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 22, milliseconds: 85),
new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 41, milliseconds: 532),
new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 34, milliseconds: 373),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 41, seconds: 43, milliseconds: 410),
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 49, milliseconds: 222),
new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 13, milliseconds: 197),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 13, milliseconds: 478),
new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 39, milliseconds: 29),
new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 44, milliseconds: 22),
new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 58, milliseconds: 625),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 23, milliseconds: 344),
new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 43, milliseconds: 962),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 54, milliseconds: 648),
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 25, milliseconds: 667),
},
},
            new TimeSpanintervalArray1M
{
    Id = 109,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 29, milliseconds: 388),
new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 27, milliseconds: 997),
new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 33, milliseconds: 380),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 113,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 33, milliseconds: 86),
new TimeSpan(days: 0, hours: 3, minutes: 10, seconds: 6, milliseconds: 55),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 16, milliseconds: 600),
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 27, milliseconds: 263),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 43,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 6, milliseconds: 435),
new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 32, milliseconds: 803),
new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 43, milliseconds: 248),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 48, milliseconds: 526),
new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 18, milliseconds: 813),
new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 6, milliseconds: 483),
},
},
            new TimeSpanintervalArray1M
{
    Id = 121,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 55, milliseconds: 267),
new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 51, milliseconds: 289),
new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 47, milliseconds: 533),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 1, milliseconds: 55),
new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 32, milliseconds: 213),
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 27, milliseconds: 592),
new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 2, milliseconds: 886),
},
},
            new TimeSpanintervalArray1M
{
    Id = 122,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 9, milliseconds: 177),
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 20, milliseconds: 533),
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 57, milliseconds: 894),
new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 46, milliseconds: 764),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 48,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 19, milliseconds: 126),
new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 4, milliseconds: 308),
new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 8, milliseconds: 370),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 29, milliseconds: 644),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 54, milliseconds: 511),
new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 48, milliseconds: 427),
new TimeSpan(days: 0, hours: 22, minutes: 26, seconds: 7, milliseconds: 911),
},
},
            new TimeSpanintervalArray1M
{
    Id = 126,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 12, milliseconds: 367),
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 35, milliseconds: 42),
new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 19, milliseconds: 400),
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 51, milliseconds: 687),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 57, milliseconds: 525),
new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 52, milliseconds: 272),
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 1, milliseconds: 324),
new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 38, milliseconds: 104),
},
},
            new TimeSpanintervalArray1M
{
    Id = 132,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 45, milliseconds: 674),
new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 56, milliseconds: 72),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 47, milliseconds: 102),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 52,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 39, milliseconds: 922),
new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 25, milliseconds: 38),
new TimeSpan(days: 0, hours: 19, minutes: 27, seconds: 13, milliseconds: 189),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 23, milliseconds: 108),
new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 0, milliseconds: 962),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 29, milliseconds: 954),
},
},
            new TimeSpanintervalArray1M
{
    Id = 133,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 53, milliseconds: 285),
new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 7, milliseconds: 950),
new TimeSpan(days: 0, hours: 12, minutes: 36, seconds: 46, milliseconds: 120),
new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 55, milliseconds: 990),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 9, milliseconds: 848),
new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 33, milliseconds: 753),
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 13, milliseconds: 561),
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 32, milliseconds: 107),
},
},
            new TimeSpanintervalArray1M
{
    Id = 139,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 12, seconds: 21, milliseconds: 656),
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 33, milliseconds: 234),
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 44, milliseconds: 727),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 53,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 39, milliseconds: 28),
new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 36, milliseconds: 198),
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 53, milliseconds: 37),
new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 3, milliseconds: 717),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 141,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 38, milliseconds: 472),
new TimeSpan(days: 0, hours: 22, minutes: 16, seconds: 24, milliseconds: 55),
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 16, milliseconds: 255),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 143,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 14, milliseconds: 939),
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 58, milliseconds: 432),
new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 34, milliseconds: 892),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 62,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 28, milliseconds: 373),
new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 57, milliseconds: 202),
new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 56, milliseconds: 292),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 148,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 33, milliseconds: 949),
new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 45, milliseconds: 242),
new TimeSpan(days: 0, hours: 2, minutes: 16, seconds: 48, milliseconds: 708),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 156,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 13, milliseconds: 15),
new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 44, milliseconds: 602),
new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 10, milliseconds: 46),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 40, milliseconds: 619),
new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 15, milliseconds: 40),
new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 46, milliseconds: 509),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 44, milliseconds: 319),
new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 11, milliseconds: 826),
new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 29, milliseconds: 473),
},
},
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
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 58, milliseconds: 43),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 16, milliseconds: 341),
new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 43, milliseconds: 206),
new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 8, milliseconds: 71),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 57, milliseconds: 642),
new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 23, milliseconds: 940),
new TimeSpan(days: 0, hours: 7, minutes: 52, seconds: 18, milliseconds: 921),
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
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 12, milliseconds: 370),
new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 32, milliseconds: 429),
new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 3, milliseconds: 340),
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 29, milliseconds: 605),
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
new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 5, milliseconds: 786),
new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 17, milliseconds: 192),
new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 33, milliseconds: 380),
}));
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 27, milliseconds: 759),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 35, milliseconds: 599),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 37, milliseconds: 942),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ITimeSpanArrayintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanArrayintervalArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ITimeSpanArrayintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
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

                var models =  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
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
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[1], false);FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[2], false);FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[3], false);FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[4], false);FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[5], false);FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[6], false);FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[7], false);FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[8], false);FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[9], false);FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[10], false);FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[11], false);FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[12], false);FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[13], false);FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[14], false);FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[15], false);FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[16], false);FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[17], false);FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[18], false);FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[19], false);FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[20], false);FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[21], false);FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[22], false);FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[23], false);FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[24], false);FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[25], false);FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[26], false);FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[27], false);FlatTimeSpanintervalArray1M.AssertModel(models[27],_testData[28], false);FlatTimeSpanintervalArray1M.AssertModel(models[28],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 132, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[2], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[3], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[4], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[5], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[6], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[23],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[24],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[25],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[26],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 54, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[29], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[29], false);
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

