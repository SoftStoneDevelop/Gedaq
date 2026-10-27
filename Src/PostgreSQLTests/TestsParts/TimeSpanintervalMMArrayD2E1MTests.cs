

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
    Id = 6,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 12, minutes: 28, seconds: 41, milliseconds: 452), new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 57, milliseconds: 440), }, { new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 16, milliseconds: 201), new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 4, milliseconds: 634), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 18, milliseconds: 985), new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 32, milliseconds: 31), }, { new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 34, milliseconds: 532), new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 2, milliseconds: 388), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 23, milliseconds: 960), new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 8, milliseconds: 71), }, { new TimeSpan(days: 0, hours: 19, minutes: 2, seconds: 23, milliseconds: 186), new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 20, milliseconds: 979), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 21, milliseconds: 475), new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 36, milliseconds: 315), }, { new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 51, milliseconds: 241), new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 7, milliseconds: 881), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 48, milliseconds: 345), new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 18, milliseconds: 994), }, { new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 3, milliseconds: 543), new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 19, milliseconds: 788), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 48, milliseconds: 853), new TimeSpan(days: 0, hours: 8, minutes: 40, seconds: 28, milliseconds: 247), }, { new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 44, milliseconds: 413), new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 8, milliseconds: 452), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 47, milliseconds: 983), new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 58, milliseconds: 714), }, { new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 20, milliseconds: 144), new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 25, milliseconds: 625), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 41, milliseconds: 863), new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 31, milliseconds: 628), }, { new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 47, milliseconds: 977), new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 35, milliseconds: 469), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 11, milliseconds: 150), new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 0, milliseconds: 577), }, { new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 10, milliseconds: 59), new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 27, milliseconds: 211), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 25, seconds: 49, milliseconds: 882), new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 33, milliseconds: 583), }, { new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 21, milliseconds: 367), new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 8, milliseconds: 477), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 2, milliseconds: 324), new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 4, milliseconds: 381), }, { new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 19, milliseconds: 286), new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 35, milliseconds: 242), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 661), new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 18, milliseconds: 875), }, { new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 30, milliseconds: 691), new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 53, milliseconds: 6), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 7, milliseconds: 782), new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 48, milliseconds: 375), }, { new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 6, milliseconds: 985), new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 26, milliseconds: 410), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 54, milliseconds: 872), new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 2, milliseconds: 768), }, { new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 44, milliseconds: 423), new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 47, milliseconds: 628), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 13, milliseconds: 363), new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 20, milliseconds: 246), }, { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 0, milliseconds: 85), new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 28, milliseconds: 300), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 7, milliseconds: 695), new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 51, milliseconds: 467), }, { new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 55, milliseconds: 232), new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 7, milliseconds: 698), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 30, milliseconds: 253), new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 14, milliseconds: 162), }, { new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 34, milliseconds: 763), new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 30, milliseconds: 927), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 122), new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 0, milliseconds: 601), }, { new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 3, milliseconds: 353), new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 47), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 44, milliseconds: 917), new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 5, milliseconds: 115), }, { new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 55, milliseconds: 129), new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 19, milliseconds: 817), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 17, milliseconds: 284), new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 18, milliseconds: 812), }, { new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 12, milliseconds: 965), new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 32, milliseconds: 841), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 22, milliseconds: 502), new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 36, milliseconds: 137), }, { new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 34, milliseconds: 956), new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 36, milliseconds: 578), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 40, milliseconds: 9), new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 5, milliseconds: 169), }, { new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 18, milliseconds: 345), new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 17, milliseconds: 226), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 35, milliseconds: 80), new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 15, milliseconds: 822), }, { new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 50, milliseconds: 888), new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 12, milliseconds: 304), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 29, milliseconds: 180), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 47, milliseconds: 782), }, { new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 29, milliseconds: 902), new TimeSpan(days: 0, hours: 19, minutes: 2, seconds: 8, milliseconds: 238), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 58,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 57, milliseconds: 961), new TimeSpan(days: 0, hours: 6, minutes: 52, seconds: 22, milliseconds: 949), }, { new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 56, milliseconds: 406), new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 33, milliseconds: 832), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 52, milliseconds: 649), new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 48, milliseconds: 181), }, { new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 35, milliseconds: 713), new TimeSpan(days: 0, hours: 22, minutes: 16, seconds: 21, milliseconds: 631), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 9, milliseconds: 832), new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 26, milliseconds: 541), }, { new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 9, milliseconds: 304), new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 25, milliseconds: 859), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 51, milliseconds: 516), new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 25, milliseconds: 805), }, { new TimeSpan(days: 0, hours: 21, minutes: 15, seconds: 29, milliseconds: 375), new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 47, milliseconds: 650), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 56, milliseconds: 877), new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 18, milliseconds: 832), }, { new TimeSpan(days: 0, hours: 10, minutes: 3, seconds: 11, milliseconds: 197), new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 36, milliseconds: 455), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 15, milliseconds: 556), new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 30, milliseconds: 135), }, { new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 18, milliseconds: 828), new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 57, milliseconds: 638), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 57, milliseconds: 575), new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 35, milliseconds: 757), }, { new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 3, milliseconds: 381), new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 37, milliseconds: 78), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 22, milliseconds: 17), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 57, milliseconds: 854), }, { new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 28, milliseconds: 76), new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 19, milliseconds: 607), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 13, milliseconds: 278), new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 52, milliseconds: 644), }, { new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 36, milliseconds: 748), new TimeSpan(days: 0, hours: 9, minutes: 38, seconds: 26, milliseconds: 634), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 19, milliseconds: 591), new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 5, milliseconds: 562), }, { new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 37, milliseconds: 149), new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 39, milliseconds: 681), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 45, milliseconds: 361), new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 1, milliseconds: 122), }, { new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 45, milliseconds: 332), new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 23, milliseconds: 516), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 16, milliseconds: 499), new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 29, milliseconds: 280), }, { new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 15, milliseconds: 556), new TimeSpan(days: 0, hours: 14, minutes: 57, seconds: 52, milliseconds: 4), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 44, milliseconds: 327), new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 45, milliseconds: 370), }, { new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 18, milliseconds: 661), new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 50, milliseconds: 38), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 36, milliseconds: 434), new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 23, milliseconds: 866), }, { new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 45, milliseconds: 129), new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 49, milliseconds: 985), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 12, milliseconds: 447), new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 56, milliseconds: 525), }, { new TimeSpan(days: 0, hours: 2, minutes: 15, seconds: 40, milliseconds: 354), new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 51, milliseconds: 695), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 18, milliseconds: 905), new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 6, milliseconds: 308), }, { new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 3, milliseconds: 286), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 33, milliseconds: 54), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 5, milliseconds: 610), new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 49, milliseconds: 359), }, { new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 4, milliseconds: 74), new TimeSpan(days: 0, hours: 10, minutes: 53, seconds: 32, milliseconds: 292), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 23, milliseconds: 774), new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 0, milliseconds: 969), }, { new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 1, milliseconds: 300), new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 18, milliseconds: 768), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 3, milliseconds: 144), new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 39, milliseconds: 579), }, { new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 48, milliseconds: 409), new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 30, milliseconds: 588), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 39, milliseconds: 910), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 57, milliseconds: 628), }, { new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 7, milliseconds: 490), new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 6, milliseconds: 738), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 18, milliseconds: 559), new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 39, milliseconds: 990), }, { new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 58, milliseconds: 777), new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 25, milliseconds: 54), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 48, milliseconds: 813), new TimeSpan(days: 0, hours: 13, minutes: 8, seconds: 35, milliseconds: 968), }, { new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 19, milliseconds: 148), new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 28, milliseconds: 145), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 52, milliseconds: 50), new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 27, milliseconds: 628), }, { new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 9, milliseconds: 238), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 13, milliseconds: 344), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 1, milliseconds: 10), new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 50, milliseconds: 441), }, { new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 37, milliseconds: 976), new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 33, milliseconds: 197), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 29, milliseconds: 789), new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 52, milliseconds: 885), }, { new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 56, milliseconds: 442), new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 49, milliseconds: 504), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 39, milliseconds: 420), new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 19, milliseconds: 656), }, { new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 47, milliseconds: 133), new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 47, milliseconds: 676), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 25, milliseconds: 184), new TimeSpan(days: 0, hours: 8, minutes: 2, seconds: 22, milliseconds: 997), }, { new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 12, milliseconds: 688), new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 54, milliseconds: 703), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 39, milliseconds: 206), new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 43, milliseconds: 18), }, { new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 24, milliseconds: 746), new TimeSpan(days: 0, hours: 22, minutes: 6, seconds: 27, milliseconds: 869), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 45, milliseconds: 331), new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 23, milliseconds: 327), }, { new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 25, milliseconds: 260), new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 35, milliseconds: 319), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 48, milliseconds: 245), new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 14, milliseconds: 730), }, { new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 10, milliseconds: 512), new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 45, milliseconds: 526), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 17, milliseconds: 845), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 57, milliseconds: 326), }, { new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 15, milliseconds: 935), new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 12, milliseconds: 676), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 3, milliseconds: 48), new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 8, milliseconds: 490), }, { new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 46, milliseconds: 803), new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 31, milliseconds: 288), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 7, milliseconds: 989), new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 31, milliseconds: 62), }, { new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 0, milliseconds: 157), new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 39, milliseconds: 209), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 33, milliseconds: 583), new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 48, milliseconds: 327), }, { new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 23, milliseconds: 881), new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 23, milliseconds: 344), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 58, milliseconds: 214), new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 5, milliseconds: 0), }, { new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 48, milliseconds: 813), new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 34, milliseconds: 711), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 58, milliseconds: 443), new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 1, milliseconds: 475), }, { new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 16, milliseconds: 814), new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 37, milliseconds: 641), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 27, milliseconds: 330), new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 33, milliseconds: 577), }, { new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 23, milliseconds: 964), new TimeSpan(days: 0, hours: 12, minutes: 11, seconds: 4, milliseconds: 297), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 53, milliseconds: 603), new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 37, milliseconds: 945), }, { new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 47, milliseconds: 705), new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 17, milliseconds: 609), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 3, milliseconds: 211), new TimeSpan(days: 0, hours: 10, minutes: 3, seconds: 39, milliseconds: 107), }, { new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 33, milliseconds: 419), new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 13, milliseconds: 678), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 28, milliseconds: 374), new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 36, milliseconds: 54), }, { new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 41, milliseconds: 435), new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 41, milliseconds: 797), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 20, minutes: 43, seconds: 50, milliseconds: 171), new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 51, milliseconds: 154), }, { new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 4, milliseconds: 687), new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 39, milliseconds: 108), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 9, milliseconds: 3), new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 23, milliseconds: 827), }, { new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 20, milliseconds: 410), new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 27, milliseconds: 14), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 23, milliseconds: 218), new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 13, milliseconds: 809), }, { new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 17, milliseconds: 609), new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 49, milliseconds: 418), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 10, milliseconds: 237), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 46, milliseconds: 163), }, { new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 7, milliseconds: 63), new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 45, milliseconds: 357), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 42, milliseconds: 657), new TimeSpan(days: 0, hours: 10, minutes: 30, seconds: 8, milliseconds: 169), }, { new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 3, milliseconds: 379), new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 39, milliseconds: 286), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 14, milliseconds: 671), new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 38, milliseconds: 882), }, { new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 24, milliseconds: 872), new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 52, milliseconds: 846), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 5, milliseconds: 902), new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 53, milliseconds: 462), }, { new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 18, milliseconds: 78), new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 34, milliseconds: 860), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 19, minutes: 49, seconds: 44, milliseconds: 829), new TimeSpan(days: 0, hours: 19, minutes: 43, seconds: 35, milliseconds: 160), }, { new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 10, milliseconds: 718), new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 56, milliseconds: 793), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 17, milliseconds: 775), new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 56, milliseconds: 746), }, { new TimeSpan(days: 0, hours: 6, minutes: 28, seconds: 42, milliseconds: 572), new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 10, milliseconds: 454), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 3, minutes: 10, seconds: 14, milliseconds: 118), new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 4, milliseconds: 151), }, { new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 27, milliseconds: 633), new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 22, milliseconds: 866), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 21, milliseconds: 544), new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 49, milliseconds: 561), }, { new TimeSpan(days: 0, hours: 20, minutes: 28, seconds: 30, milliseconds: 841), new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 0, milliseconds: 860), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 47, milliseconds: 152), new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 33, milliseconds: 671), }, { new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 27, milliseconds: 837), new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 50, milliseconds: 109), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 3, milliseconds: 24), new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 13, milliseconds: 258), }, { new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 21, milliseconds: 715), new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 36, milliseconds: 995), }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 18, minutes: 28, seconds: 57, milliseconds: 669), new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 21, milliseconds: 689), }, { new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 17, milliseconds: 277), new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 33, milliseconds: 751), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 46, milliseconds: 934), new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 15, milliseconds: 653), }, { new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 46, milliseconds: 137), new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 27, milliseconds: 335), }, },
    ModelInner = new TimeSpanintervalMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 50, milliseconds: 558), new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 5, milliseconds: 862), }, { new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 15, milliseconds: 645), new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 31, milliseconds: 906), }, },
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 3, milliseconds: 13), new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 26, milliseconds: 851), }, { new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 16, milliseconds: 803), new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 57, milliseconds: 975), }, },
},
    NullableValue = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 6, milliseconds: 573), new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 15, milliseconds: 138), }, { new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 14, milliseconds: 990), new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 15, milliseconds: 578), }, },
},
            new TimeSpanintervalMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 54, milliseconds: 964), new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 11, milliseconds: 711), }, { new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 42, milliseconds: 514), new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 32, milliseconds: 943), }, },
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 13, milliseconds: 363), new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 20, milliseconds: 246), }, { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 0, milliseconds: 85), new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 28, milliseconds: 300), }, }));
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
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 44, milliseconds: 122), new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 0, milliseconds: 601), }, { new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 3, milliseconds: 353), new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 12, milliseconds: 47), }, }));
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
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 17, milliseconds: 284), new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 18, milliseconds: 812), }, { new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 12, milliseconds: 965), new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 32, milliseconds: 841), }, }));
                nullable =  ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 29, milliseconds: 180), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 47, milliseconds: 782), }, { new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 29, milliseconds: 902), new TimeSpan(days: 0, hours: 19, minutes: 2, seconds: 8, milliseconds: 238), }, }));
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
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 52, milliseconds: 649), new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 48, milliseconds: 181), }, { new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 35, milliseconds: 713), new TimeSpan(days: 0, hours: 22, minutes: 16, seconds: 21, milliseconds: 631), }, }));
                nullable = await ((ITimeSpanMArrayintervalMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,] { { new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 15, milliseconds: 556), new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 30, milliseconds: 135), }, { new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 18, milliseconds: 828), new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 57, milliseconds: 638), }, }));
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 27, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 64, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 140, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((ITimeSpanMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((ITimeSpanMArrayintervalMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                TimeSpanintervalMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                TimeSpanintervalMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 48);
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

