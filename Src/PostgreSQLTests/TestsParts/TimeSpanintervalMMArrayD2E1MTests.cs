

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
    internal partial interface ITimeSpanMArrayintervalMMArrayD2
    {
    }
    
    internal partial class TimeSpanMArrayintervalMMArrayD2 : ITimeSpanMArrayintervalMMArrayD2
    {


#region TestData

        private readonly TimeSpanintervalMMArrayD2E1M[] _testData = new TimeSpanintervalMMArrayD2E1M[]
        {
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 1,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 6, milliseconds: 239), new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 15, milliseconds: 98), }, { new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 0, milliseconds: 389), new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 8, milliseconds: 949), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 2,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 15, milliseconds: 378), new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 3, milliseconds: 959), }, { new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 22, milliseconds: 543), new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 53, milliseconds: 977), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 32, milliseconds: 458), new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 1, milliseconds: 57), }, { new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 3, milliseconds: 475), new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 39, milliseconds: 493), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 58, milliseconds: 890), new TimeSpan(days: 0, hours: 13, minutes: 35, seconds: 53, milliseconds: 144), }, { new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 37, milliseconds: 144), new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 5, milliseconds: 186), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 3, milliseconds: 91), new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 2, milliseconds: 815), }, { new TimeSpan(days: 0, hours: 2, minutes: 35, seconds: 11, milliseconds: 748), new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 31, milliseconds: 455), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 23, milliseconds: 500), new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 44, milliseconds: 623), }, { new TimeSpan(days: 0, hours: 5, minutes: 13, seconds: 13, milliseconds: 922), new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 36, milliseconds: 205), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 1, milliseconds: 302), new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 16, milliseconds: 577), }, { new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 3, milliseconds: 186), new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 55, milliseconds: 460), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 58, milliseconds: 975), new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 17, milliseconds: 656), }, { new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 9, milliseconds: 478), new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 42, milliseconds: 546), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 35, milliseconds: 583), new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 19, milliseconds: 47), }, { new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 5, milliseconds: 350), new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 28, milliseconds: 890), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 48, seconds: 42, milliseconds: 284), new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 9, milliseconds: 76), }, { new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 2, milliseconds: 778), new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 15, milliseconds: 133), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 30, seconds: 27, milliseconds: 457), new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 56, milliseconds: 462), }, { new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 51, milliseconds: 332), new TimeSpan(days: 0, hours: 18, minutes: 22, seconds: 46, milliseconds: 373), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 56, milliseconds: 702), new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 22, milliseconds: 351), }, { new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 15, milliseconds: 248), new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 30, milliseconds: 684), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 46, milliseconds: 15), new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 11, milliseconds: 227), }, { new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 31, milliseconds: 859), new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 25, milliseconds: 475), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 22, milliseconds: 467), new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 29, milliseconds: 206), }, { new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 58, milliseconds: 314), new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 37, milliseconds: 766), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 13, milliseconds: 177), new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 33, milliseconds: 900), }, { new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 5, milliseconds: 633), new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 9, milliseconds: 510), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 30, milliseconds: 793), new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 35, milliseconds: 545), }, { new TimeSpan(days: 0, hours: 15, minutes: 8, seconds: 37, milliseconds: 685), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 32, milliseconds: 912), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 36, milliseconds: 304), new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 11, milliseconds: 656), }, { new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 15, milliseconds: 212), new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 52, milliseconds: 239), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 7, milliseconds: 853), new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 30, milliseconds: 428), }, { new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 17, milliseconds: 255), new TimeSpan(days: 0, hours: 8, minutes: 26, seconds: 8, milliseconds: 30), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 47, milliseconds: 469), new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 33, milliseconds: 465), }, { new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 57, milliseconds: 511), new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 48, milliseconds: 361), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 30, milliseconds: 789), new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 4, milliseconds: 6), }, { new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 386), new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 2, milliseconds: 782), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 54, milliseconds: 920), new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 18, milliseconds: 55), }, { new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 33, milliseconds: 241), new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 16, milliseconds: 581), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 3, milliseconds: 83), new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 18, milliseconds: 561), }, { new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 44, milliseconds: 402), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 12, milliseconds: 333), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 35, seconds: 2, milliseconds: 196), new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 9, milliseconds: 542), }, { new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 25, milliseconds: 594), new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 10, milliseconds: 830), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 29, milliseconds: 809), new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 40, milliseconds: 556), }, { new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 22, milliseconds: 435), new TimeSpan(days: 0, hours: 11, minutes: 8, seconds: 17, milliseconds: 612), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 1, milliseconds: 280), new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 51, milliseconds: 656), }, { new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 26, milliseconds: 14), new TimeSpan(days: 0, hours: 5, minutes: 50, seconds: 51, milliseconds: 793), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 1, milliseconds: 586), new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 43, milliseconds: 668), }, { new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 5, milliseconds: 582), new TimeSpan(days: 0, hours: 10, minutes: 38, seconds: 35, milliseconds: 401), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 895), new TimeSpan(days: 0, hours: 0, minutes: 24, seconds: 35, milliseconds: 5), }, { new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 8, milliseconds: 203), new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 46, milliseconds: 528), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 20, minutes: 40, seconds: 56, milliseconds: 886), new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 13, milliseconds: 831), }, { new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 41, milliseconds: 350), new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 48, milliseconds: 344), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 32, milliseconds: 838), new TimeSpan(days: 0, hours: 7, minutes: 35, seconds: 31, milliseconds: 283), }, { new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 8, milliseconds: 231), new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 22, milliseconds: 3), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 57, milliseconds: 154), new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 27, milliseconds: 967), }, { new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 35, milliseconds: 477), new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 56, milliseconds: 80), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 7, milliseconds: 261), new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 33, milliseconds: 915), }, { new TimeSpan(days: 0, hours: 0, minutes: 17, seconds: 8, milliseconds: 964), new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 28, milliseconds: 409), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 10, milliseconds: 499), new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 48, milliseconds: 637), }, { new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 766), new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 0, milliseconds: 326), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 70,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 11, seconds: 11, milliseconds: 1), new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 45, milliseconds: 15), }, { new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 41, milliseconds: 20), new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 17, milliseconds: 169), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 32, milliseconds: 442), new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 87), }, { new TimeSpan(days: 0, hours: 22, minutes: 11, seconds: 20, milliseconds: 340), new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 13, milliseconds: 514), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 35, seconds: 47, milliseconds: 437), new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 1, milliseconds: 731), }, { new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 9, milliseconds: 559), new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 39, milliseconds: 294), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 4, minutes: 5, seconds: 7, milliseconds: 211), new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 51, milliseconds: 739), }, { new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 11, milliseconds: 410), new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 15, milliseconds: 276), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 47, milliseconds: 463), new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 44, milliseconds: 614), }, { new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 29, milliseconds: 138), new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 36, milliseconds: 50), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 36, milliseconds: 519), new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 3, milliseconds: 399), }, { new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 30, milliseconds: 151), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 14, milliseconds: 301), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 23, milliseconds: 536), new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 5, milliseconds: 472), }, { new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 39, milliseconds: 934), new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 37, milliseconds: 694), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 56, milliseconds: 673), new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 39, milliseconds: 485), }, { new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 32, milliseconds: 648), new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 55, milliseconds: 933), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 2, milliseconds: 511), new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 35, milliseconds: 498), }, { new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 36, milliseconds: 109), new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 34, milliseconds: 126), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 6, milliseconds: 331), new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 19, milliseconds: 645), }, { new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 50, milliseconds: 464), new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 32, milliseconds: 418), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 15, milliseconds: 534), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 56, milliseconds: 596), }, { new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 27, milliseconds: 542), new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 48, milliseconds: 109), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 31, milliseconds: 57), new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 32, milliseconds: 385), }, { new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 2, milliseconds: 505), new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 20, milliseconds: 731), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 47, milliseconds: 909), new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 4, milliseconds: 612), }, { new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 8, milliseconds: 222), new TimeSpan(days: 0, hours: 3, minutes: 18, seconds: 43, milliseconds: 213), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 10, milliseconds: 529), new TimeSpan(days: 0, hours: 10, minutes: 48, seconds: 17, milliseconds: 253), }, { new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 21, milliseconds: 947), new TimeSpan(days: 0, hours: 5, minutes: 56, seconds: 38, milliseconds: 94), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 6, milliseconds: 748), new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 49, milliseconds: 139), }, { new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 33, milliseconds: 229), new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 36, milliseconds: 469), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 20, milliseconds: 862), new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 12, milliseconds: 86), }, { new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 9, milliseconds: 764), new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 26, milliseconds: 327), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 15, milliseconds: 290), new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 42, milliseconds: 675), }, { new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 28, milliseconds: 27), new TimeSpan(days: 0, hours: 17, minutes: 50, seconds: 6, milliseconds: 896), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 116,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 26, milliseconds: 567), new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 22, milliseconds: 351), }, { new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 58, milliseconds: 828), new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 10, milliseconds: 471), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 56, milliseconds: 197), new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 0, milliseconds: 127), }, { new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 32, milliseconds: 898), new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 46, milliseconds: 111), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 54, milliseconds: 179), new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 9, milliseconds: 633), }, { new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 42, milliseconds: 416), new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 14, milliseconds: 285), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 52, milliseconds: 620), new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 46, milliseconds: 172), }, { new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 43, milliseconds: 928), new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 52, milliseconds: 454), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 48, milliseconds: 93), new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 7, milliseconds: 571), }, { new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 11, milliseconds: 643), new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 49, milliseconds: 945), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 21, milliseconds: 13), new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 32, milliseconds: 613), }, { new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 8, milliseconds: 951), new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 47, milliseconds: 408), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 31, milliseconds: 928), new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 0, milliseconds: 227), }, { new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 43, milliseconds: 624), new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 4, milliseconds: 15), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 25, milliseconds: 246), new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 58, milliseconds: 968), }, { new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 55, milliseconds: 622), new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 39, milliseconds: 882), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 22, milliseconds: 114), new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 21, milliseconds: 293), }, { new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 13, milliseconds: 904), new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 0, milliseconds: 953), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 46, milliseconds: 948), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 20, milliseconds: 205), }, { new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 20, milliseconds: 545), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 56, milliseconds: 7), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 52, milliseconds: 410), new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 56, milliseconds: 454), }, { new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 0, milliseconds: 723), new TimeSpan(days: 0, hours: 4, minutes: 54, seconds: 31, milliseconds: 715), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 601), new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 14, milliseconds: 824), }, { new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 28, milliseconds: 270), new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 240), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 20, milliseconds: 502), new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 41, milliseconds: 199), }, { new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 31, milliseconds: 585), new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 40, milliseconds: 748), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 7, milliseconds: 713), new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 57, milliseconds: 797), }, { new TimeSpan(days: 0, hours: 1, minutes: 54, seconds: 50, milliseconds: 781), new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 47, milliseconds: 456), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 2, milliseconds: 32), new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 7, milliseconds: 713), }, { new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 38, milliseconds: 328), new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 46, milliseconds: 512), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 147,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 7, milliseconds: 810), new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 43, milliseconds: 409), }, { new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 26, milliseconds: 227), new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 4, milliseconds: 563), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 31, milliseconds: 899), new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 6, milliseconds: 580), }, { new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 5, milliseconds: 208), new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 2, milliseconds: 629), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 16, milliseconds: 308), new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 25, milliseconds: 196), }, { new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 9, milliseconds: 688), new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 19, milliseconds: 308), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 30, milliseconds: 643), new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 2, milliseconds: 668), }, { new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 33, milliseconds: 988), new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 4, milliseconds: 150), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 44, milliseconds: 149), new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 8, milliseconds: 520), }, { new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 25, milliseconds: 285), new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 32, milliseconds: 225), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 5, milliseconds: 264), new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 52, milliseconds: 861), }, { new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 3, milliseconds: 681), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 19, milliseconds: 675), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 9, milliseconds: 121), new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 28, milliseconds: 935), }, { new TimeSpan(days: 0, hours: 16, minutes: 18, seconds: 23, milliseconds: 318), new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 20, milliseconds: 222), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 44, milliseconds: 30), new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 14, milliseconds: 791), }, { new TimeSpan(days: 0, hours: 10, minutes: 3, seconds: 5, milliseconds: 184), new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 3, milliseconds: 13), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 26, milliseconds: 504), new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 7, milliseconds: 984), }, { new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 25, milliseconds: 874), new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 14, milliseconds: 563), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 36, milliseconds: 460), new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 33, milliseconds: 728), }, { new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 43, milliseconds: 547), new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 18, milliseconds: 455), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 30, milliseconds: 675), new TimeSpan(days: 0, hours: 4, minutes: 57, seconds: 38, milliseconds: 682), }, { new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 23, milliseconds: 546), new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 8, milliseconds: 109), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 1, milliseconds: 86), new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 46, milliseconds: 52), }, { new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 4, milliseconds: 117), new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 19, milliseconds: 979), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 28, milliseconds: 53), new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 9, milliseconds: 597), }, { new TimeSpan(days: 0, hours: 11, minutes: 19, seconds: 49, milliseconds: 168), new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 27, milliseconds: 884), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 44, milliseconds: 179), new TimeSpan(days: 0, hours: 20, minutes: 53, seconds: 55, milliseconds: 583), }, { new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 19, milliseconds: 90), new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 3, milliseconds: 579), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 36, milliseconds: 237), new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 41, milliseconds: 594), }, { new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 54, milliseconds: 871), new TimeSpan(days: 0, hours: 7, minutes: 36, seconds: 42, milliseconds: 789), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 51, milliseconds: 480), new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 25, milliseconds: 504), }, { new TimeSpan(days: 0, hours: 5, minutes: 21, seconds: 9, milliseconds: 506), new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 50, milliseconds: 807), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 178,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 43, milliseconds: 54), new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 51, milliseconds: 415), }, { new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 43, milliseconds: 289), new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 19, milliseconds: 631), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd2e1mi(
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd2e1mi(
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
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]), 
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

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd2e1mi_id
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd2e1mi_id", 
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
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd2e1mi_id
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
    timespanintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                System.TimeSpan[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,]>();
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 35, milliseconds: 583), new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 19, milliseconds: 47), }, { new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 5, milliseconds: 350), new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 28, milliseconds: 890), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,]>();
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 46, milliseconds: 15), new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 11, milliseconds: 227), }, { new TimeSpan(days: 0, hours: 7, minutes: 3, seconds: 31, milliseconds: 859), new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 25, milliseconds: 475), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,]>();
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,]>();
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 7, milliseconds: 853), new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 30, milliseconds: 428), }, { new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 17, milliseconds: 255), new TimeSpan(days: 0, hours: 8, minutes: 26, seconds: 8, milliseconds: 30), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd2e1mi_id
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
    timespanintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd2e1mi_id", 
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
                System.TimeSpan[,] nullable = null;
                nullable =  ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 30, milliseconds: 789), new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 4, milliseconds: 6), }, { new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 4, milliseconds: 386), new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 2, milliseconds: 782), }, }));
                nullable =  ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[,] nullable = null;
                nullable = await ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 21, seconds: 1, milliseconds: 280), new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 51, milliseconds: 656), }, { new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 26, milliseconds: 14), new TimeSpan(days: 0, hours: 5, minutes: 50, seconds: 51, milliseconds: 793), }, }));
                nullable = await ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD2E1M> models = null;

                models =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD2E1M> models = null;

                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M), typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
LEFT JOIN public.timespanintervalmmarrayd2e1mi mi ON mi.id = m.timespanintervalmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M), typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
LEFT JOIN public.timespanintervalmmarrayd2e1mi mi ON mi.id = m.timespanintervalmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M), typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
LEFT JOIN public.timespanintervalmmarrayd2e1mi mi ON mi.id = m.timespanintervalmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M), typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 1, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 156, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 2, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 124, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 126, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
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
FROM public.timespanintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD2E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 166, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.timespanintervalmmarrayd2e1m m
LEFT JOIN public.timespanintervalmmarrayd2e1mi mi ON mi.id = m.timespanintervalmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 135, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 168, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanMArrayintervalMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((ITimeSpanMArrayintervalMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_timespanintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD2E1MIWA),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD2E1MI),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalMMArrayD2E1M),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
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
FROM public.binary_timespanintervalmmarrayd2e1m m
LEFT JOIN public.binary_timespanintervalmmarrayd2e1mi mi ON mi.id = m.timespanintervalmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models =  ((ITimeSpanMArrayintervalMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA), typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
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
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
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
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA), typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
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
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd2e1mi
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
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MI), typeof(TimeSpanintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MI>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MI>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA), typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD2E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD2))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

