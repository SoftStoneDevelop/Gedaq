

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
    Id = 5,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 35, seconds: 57, milliseconds: 131),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 32, milliseconds: 274),
new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 22, milliseconds: 316),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 37, milliseconds: 391),
new TimeSpan(days: 0, hours: 14, minutes: 17, seconds: 12, milliseconds: 600),
new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 5, milliseconds: 760),
new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 48, milliseconds: 205),
},
},
            new TimeSpanintervalArray1M
{
    Id = 9,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 48, milliseconds: 560),
new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 25, milliseconds: 238),
new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 41, milliseconds: 594),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 7,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 26, milliseconds: 15),
new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 22, milliseconds: 2),
new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 31, milliseconds: 869),
new TimeSpan(days: 0, hours: 16, minutes: 45, seconds: 1, milliseconds: 378),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 9, seconds: 43, milliseconds: 809),
new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 41, milliseconds: 724),
new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 27, milliseconds: 507),
},
},
            new TimeSpanintervalArray1M
{
    Id = 16,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 33, milliseconds: 918),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 1, milliseconds: 489),
new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 31, milliseconds: 227),
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
new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 46, milliseconds: 208),
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 53, milliseconds: 996),
new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 16, milliseconds: 796),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 16,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 49, milliseconds: 714),
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 3, milliseconds: 602),
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 49, milliseconds: 258),
new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 15, milliseconds: 668),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 47, seconds: 23, milliseconds: 949),
new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 23, milliseconds: 217),
new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 53, milliseconds: 523),
},
},
            new TimeSpanintervalArray1M
{
    Id = 32,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 44, milliseconds: 261),
new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 2, milliseconds: 556),
new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 31, milliseconds: 389),
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
new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 23, milliseconds: 16),
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 37, milliseconds: 452),
new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 21, milliseconds: 899),
new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 11, milliseconds: 572),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 22,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 26, milliseconds: 552),
new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 44, milliseconds: 556),
new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 10, milliseconds: 144),
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 38, milliseconds: 384),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 37, milliseconds: 617),
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 8, milliseconds: 148),
new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 54, milliseconds: 279),
new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 10, milliseconds: 518),
},
},
            new TimeSpanintervalArray1M
{
    Id = 39,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 33, milliseconds: 468),
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 13, milliseconds: 404),
new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 33, milliseconds: 649),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 1, milliseconds: 438),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 58, milliseconds: 373),
new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 25, milliseconds: 982),
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 26, milliseconds: 865),
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 35, milliseconds: 991),
},
},
            new TimeSpanintervalArray1M
{
    Id = 46,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 10, milliseconds: 627),
new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 47, milliseconds: 766),
new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 52, milliseconds: 710),
new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 40, milliseconds: 550),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 46, milliseconds: 886),
new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 4, milliseconds: 366),
new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 25, milliseconds: 666),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 32, milliseconds: 38),
new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 44, milliseconds: 379),
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 19, milliseconds: 371),
new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 20, milliseconds: 935),
},
},
            new TimeSpanintervalArray1M
{
    Id = 53,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 40, milliseconds: 515),
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 7, milliseconds: 307),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 43, milliseconds: 384),
new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 56, milliseconds: 121),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 406),
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 52, milliseconds: 5),
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 49, milliseconds: 210),
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 29, milliseconds: 853),
},
},
            new TimeSpanintervalArray1M
{
    Id = 54,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 45, milliseconds: 964),
new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 54, milliseconds: 513),
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 17, milliseconds: 0),
new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 42, milliseconds: 557),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 35,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 36, milliseconds: 228),
new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 29, milliseconds: 278),
new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 5, milliseconds: 849),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 2, milliseconds: 899),
new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 56, milliseconds: 613),
new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 10, milliseconds: 417),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 59,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 1, milliseconds: 439),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 24, milliseconds: 809),
new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 54, milliseconds: 766),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 66,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 12, milliseconds: 994),
new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 26, milliseconds: 647),
new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 5, milliseconds: 222),
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 48, milliseconds: 891),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 44,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 13, milliseconds: 473),
new TimeSpan(days: 0, hours: 9, minutes: 7, seconds: 37, milliseconds: 978),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 54, milliseconds: 434),
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 35, milliseconds: 13),
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
new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 2, milliseconds: 800),
new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 8, milliseconds: 139),
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 13, milliseconds: 803),
new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 46, milliseconds: 234),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 0, milliseconds: 918),
new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 6, milliseconds: 950),
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 18, milliseconds: 184),
},
},
            new TimeSpanintervalArray1M
{
    Id = 84,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 23, milliseconds: 900),
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 4, milliseconds: 273),
new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 21, milliseconds: 135),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 7, milliseconds: 736),
new TimeSpan(days: 0, hours: 13, minutes: 20, seconds: 14, milliseconds: 34),
new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 19, milliseconds: 868),
new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 17, milliseconds: 26),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 32, milliseconds: 982),
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 5, milliseconds: 219),
new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 55, milliseconds: 604),
},
},
            new TimeSpanintervalArray1M
{
    Id = 86,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 40, milliseconds: 108),
new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 26, milliseconds: 240),
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 48, milliseconds: 330),
new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 10, milliseconds: 37),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 13, milliseconds: 102),
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 30, milliseconds: 617),
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 23, milliseconds: 179),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 43, milliseconds: 295),
},
},
            new TimeSpanintervalArray1M
{
    Id = 94,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 55, milliseconds: 67),
new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 53, milliseconds: 270),
new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 17, milliseconds: 460),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 51,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 55, milliseconds: 308),
new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 13, milliseconds: 204),
new TimeSpan(days: 0, hours: 0, minutes: 11, seconds: 24, milliseconds: 235),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 17, milliseconds: 173),
new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 8, milliseconds: 875),
new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 31, milliseconds: 873),
},
},
            new TimeSpanintervalArray1M
{
    Id = 99,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 31, milliseconds: 842),
new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 42, milliseconds: 549),
new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 3, milliseconds: 312),
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 45, milliseconds: 912),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 104,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 25, milliseconds: 158),
new TimeSpan(days: 0, hours: 15, minutes: 58, seconds: 16, milliseconds: 667),
new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 7, milliseconds: 737),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 54,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 14, milliseconds: 170),
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 26, milliseconds: 833),
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 53, milliseconds: 355),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 18, milliseconds: 801),
new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 9, milliseconds: 295),
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 44, milliseconds: 710),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 105,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 28, milliseconds: 889),
new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 4, milliseconds: 992),
new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 57, milliseconds: 433),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 29, milliseconds: 259),
new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 8, milliseconds: 477),
new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 23, milliseconds: 390),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 4, milliseconds: 72),
},
},
            new TimeSpanintervalArray1M
{
    Id = 114,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 28, milliseconds: 441),
new TimeSpan(days: 0, hours: 12, minutes: 36, seconds: 15, milliseconds: 340),
new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 38, milliseconds: 891),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 25, milliseconds: 494),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 63,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 53, milliseconds: 536),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 55, milliseconds: 319),
new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 12, milliseconds: 912),
new TimeSpan(days: 0, hours: 5, minutes: 37, seconds: 46, milliseconds: 502),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 23, milliseconds: 462),
new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 54, milliseconds: 12),
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 39, milliseconds: 582),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 41, milliseconds: 147),
new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 55, milliseconds: 624),
new TimeSpan(days: 0, hours: 21, minutes: 53, seconds: 38, milliseconds: 818),
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 43, milliseconds: 899),
},
},
            new TimeSpanintervalArray1M
{
    Id = 121,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 51, milliseconds: 314),
new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 10, milliseconds: 794),
new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 3, milliseconds: 759),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 7, milliseconds: 648),
new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 47, milliseconds: 326),
new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 23, milliseconds: 272),
new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 39, milliseconds: 270),
},
},
            new TimeSpanintervalArray1M
{
    Id = 126,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 25, milliseconds: 968),
new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 16, milliseconds: 766),
new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 55, milliseconds: 159),
new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 21, milliseconds: 667),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 44, milliseconds: 45),
new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 40, milliseconds: 791),
new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 27, milliseconds: 529),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 10, milliseconds: 364),
new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 46, milliseconds: 370),
new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 25, milliseconds: 658),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 130,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 30, milliseconds: 447),
new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 49, milliseconds: 616),
new TimeSpan(days: 0, hours: 6, minutes: 32, seconds: 12, milliseconds: 406),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 51, milliseconds: 362),
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 11, milliseconds: 949),
new TimeSpan(days: 0, hours: 3, minutes: 46, seconds: 55, milliseconds: 767),
},
},
            new TimeSpanintervalArray1M
{
    Id = 136,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 29, milliseconds: 887),
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 29, milliseconds: 874),
new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 56, milliseconds: 97),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 42, seconds: 36, milliseconds: 919),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 51, milliseconds: 113),
new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 17, milliseconds: 985),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 137,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 52, milliseconds: 394),
new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 13, milliseconds: 603),
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 221),
new TimeSpan(days: 0, hours: 6, minutes: 37, seconds: 55, milliseconds: 788),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 50, milliseconds: 612),
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 50, milliseconds: 202),
new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 27, milliseconds: 493),
},
},
            new TimeSpanintervalArray1M
{
    Id = 145,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 58, milliseconds: 905),
new TimeSpan(days: 0, hours: 1, minutes: 18, seconds: 7, milliseconds: 433),
new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 24, milliseconds: 122),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 76,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 56, milliseconds: 44),
new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 24, milliseconds: 8),
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 58, milliseconds: 179),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 147,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 25, milliseconds: 828),
new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 11, milliseconds: 456),
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 20, milliseconds: 101),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 12, milliseconds: 930),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 43, milliseconds: 853),
new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 10, milliseconds: 255),
new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 42, milliseconds: 996),
new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 35, milliseconds: 852),
},
},
            new TimeSpanintervalArray1M
{
    Id = 148,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 36, milliseconds: 690),
new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 23, milliseconds: 881),
new TimeSpan(days: 0, hours: 5, minutes: 37, seconds: 32, milliseconds: 987),
new TimeSpan(days: 0, hours: 0, minutes: 26, seconds: 58, milliseconds: 827),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 80,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 46, milliseconds: 930),
new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 46, milliseconds: 318),
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 6, milliseconds: 237),
new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 56, milliseconds: 901),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 19, milliseconds: 253),
new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 13, milliseconds: 738),
new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 41, milliseconds: 579),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 24, milliseconds: 348),
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 23, milliseconds: 998),
new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 3, milliseconds: 376),
},
},
            new TimeSpanintervalArray1M
{
    Id = 149,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 47, seconds: 47, milliseconds: 520),
new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 42, milliseconds: 787),
new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 33, milliseconds: 994),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 154,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 48, milliseconds: 909),
new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 8, milliseconds: 871),
new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 31, milliseconds: 141),
new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 23, milliseconds: 586),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 81,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 46, milliseconds: 869),
new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 36, milliseconds: 426),
new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 25, milliseconds: 705),
new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 23, milliseconds: 241),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 37, milliseconds: 582),
new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 34, milliseconds: 799),
new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 3, milliseconds: 669),
new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 52, milliseconds: 712),
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
new TimeSpan(days: 0, hours: 17, minutes: 23, seconds: 37, milliseconds: 617),
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 8, milliseconds: 148),
new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 54, milliseconds: 279),
new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 10, milliseconds: 518),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 58, milliseconds: 373),
new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 25, milliseconds: 982),
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 26, milliseconds: 865),
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 35, milliseconds: 991),
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
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 32, milliseconds: 38),
new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 44, milliseconds: 379),
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 19, milliseconds: 371),
new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 20, milliseconds: 935),
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
new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 47, milliseconds: 406),
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 52, milliseconds: 5),
new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 49, milliseconds: 210),
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 29, milliseconds: 853),
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[3], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[4], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[5], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[26],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 136, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 24, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 126, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 136, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 39, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 137, 137))
                {
                    if(++resultIndex == 1)
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[5], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[6], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[23],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
        private void ImportModelInnerConfig()
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

