

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
    internal partial interface ITimeSpanMArrayintervalMMArrayD3
    {
    }
    
    internal partial class TimeSpanMArrayintervalMMArrayD3 : ITimeSpanMArrayintervalMMArrayD3
    {


#region TestData

        private readonly TimeSpanintervalMMArrayD3E1M[] _testData = new TimeSpanintervalMMArrayD3E1M[]
        {
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 7,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 24, milliseconds: 134), new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 53, milliseconds: 952), new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 9, milliseconds: 255), }, { new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 37, milliseconds: 950), new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 36, milliseconds: 399), new TimeSpan(days: 0, hours: 21, minutes: 20, seconds: 54, milliseconds: 954), }, { new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 1, milliseconds: 681), new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 21, milliseconds: 267), new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 5, milliseconds: 231), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 43, milliseconds: 315), new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 8, milliseconds: 810), new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 58, milliseconds: 369), }, { new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 15, milliseconds: 171), new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 56, milliseconds: 94), new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 13, milliseconds: 516), }, { new TimeSpan(days: 0, hours: 11, minutes: 30, seconds: 30, milliseconds: 902), new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 43, milliseconds: 643), new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 18, milliseconds: 45), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 50, milliseconds: 847), new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 45, milliseconds: 837), new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 20, milliseconds: 172), }, { new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 40, milliseconds: 516), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 4, milliseconds: 918), new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 23, milliseconds: 947), }, { new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 18, milliseconds: 994), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 22, milliseconds: 885), new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 45, milliseconds: 71), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 12,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 47, milliseconds: 89), new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 22, milliseconds: 490), new TimeSpan(days: 0, hours: 21, minutes: 11, seconds: 54, milliseconds: 126), }, { new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 2, milliseconds: 357), new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 49, milliseconds: 748), new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 49, milliseconds: 698), }, { new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 21, milliseconds: 268), new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 20, milliseconds: 466), new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 56, milliseconds: 430), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 9, milliseconds: 455), new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 36, milliseconds: 837), new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 5, milliseconds: 85), }, { new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 4, milliseconds: 641), new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 2, milliseconds: 181), new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 38, milliseconds: 18), }, { new TimeSpan(days: 0, hours: 5, minutes: 5, seconds: 3, milliseconds: 858), new TimeSpan(days: 0, hours: 20, minutes: 46, seconds: 22, milliseconds: 940), new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 32, milliseconds: 300), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 16, milliseconds: 788), new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 1, milliseconds: 942), new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 28, milliseconds: 156), }, { new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 51, milliseconds: 188), new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 38, milliseconds: 199), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 53, milliseconds: 569), }, { new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 43, milliseconds: 199), new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 45, milliseconds: 18), new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 5, milliseconds: 867), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 36, milliseconds: 243), new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 15, milliseconds: 635), new TimeSpan(days: 0, hours: 5, minutes: 49, seconds: 43, milliseconds: 195), }, { new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 47, milliseconds: 299), new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 13, milliseconds: 658), new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 26, milliseconds: 298), }, { new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 33, milliseconds: 490), new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 35, milliseconds: 503), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 39, milliseconds: 424), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 41, milliseconds: 569), new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 46, milliseconds: 398), new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 10, milliseconds: 576), }, { new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 52, milliseconds: 588), new TimeSpan(days: 0, hours: 13, minutes: 16, seconds: 15, milliseconds: 687), new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 43, milliseconds: 491), }, { new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 49, milliseconds: 889), new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 13, milliseconds: 665), new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 47, milliseconds: 339), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 11, milliseconds: 493), new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 12, milliseconds: 842), new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 47, milliseconds: 569), }, { new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 34, milliseconds: 119), new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 42, milliseconds: 530), new TimeSpan(days: 0, hours: 2, minutes: 22, seconds: 48, milliseconds: 528), }, { new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 1, milliseconds: 937), new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 44, milliseconds: 924), new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 49, milliseconds: 940), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 16, milliseconds: 386), new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 27, milliseconds: 330), new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 13, milliseconds: 365), }, { new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 28, milliseconds: 959), new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 50, milliseconds: 172), new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 56, milliseconds: 335), }, { new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 11, milliseconds: 327), new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 12, milliseconds: 363), new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 14, milliseconds: 964), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 19, milliseconds: 435), new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 19, milliseconds: 776), new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 50, milliseconds: 840), }, { new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 9, milliseconds: 811), new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 34, milliseconds: 788), new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 24, milliseconds: 18), }, { new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 28, milliseconds: 868), new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 47, milliseconds: 673), new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 20, milliseconds: 608), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 58, milliseconds: 226), new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 58, milliseconds: 686), new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 36, milliseconds: 329), }, { new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 25, milliseconds: 277), new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 19, milliseconds: 42), new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 33, milliseconds: 135), }, { new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 33, milliseconds: 714), new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 20, milliseconds: 699), new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 56, milliseconds: 341), }, }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 18,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 11, milliseconds: 197), new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 47, milliseconds: 88), new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 49, milliseconds: 254), }, { new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 42, milliseconds: 375), new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 14, milliseconds: 169), new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 18, milliseconds: 853), }, { new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 57, milliseconds: 300), new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 56, milliseconds: 621), new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 50, milliseconds: 847), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 50, milliseconds: 125), new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 28, milliseconds: 894), new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 29, milliseconds: 798), }, { new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 41, milliseconds: 41), new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 20, milliseconds: 1), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 33, milliseconds: 214), }, { new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 14, milliseconds: 482), new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 8, milliseconds: 181), new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 42, milliseconds: 956), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 52, milliseconds: 858), new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 46, milliseconds: 757), new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 55, milliseconds: 536), }, { new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 49, milliseconds: 952), new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 50, milliseconds: 318), new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 17, milliseconds: 621), }, { new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 3, milliseconds: 218), new TimeSpan(days: 0, hours: 19, minutes: 11, seconds: 5, milliseconds: 592), new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 58, milliseconds: 769), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 25, milliseconds: 0), new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 7, milliseconds: 136), new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 2, milliseconds: 555), }, { new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 57, milliseconds: 8), new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 22, milliseconds: 86), new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 19, milliseconds: 241), }, { new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 1, milliseconds: 633), new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 34, milliseconds: 172), new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 56, milliseconds: 976), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 39, milliseconds: 205), new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 46, milliseconds: 339), new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 48, milliseconds: 574), }, { new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 18, milliseconds: 359), new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 35, milliseconds: 469), new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 31, milliseconds: 613), }, { new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 32, milliseconds: 231), new TimeSpan(days: 0, hours: 10, minutes: 17, seconds: 23, milliseconds: 618), new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 43, milliseconds: 141), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 56, milliseconds: 317), new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 45, milliseconds: 55), new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 29, milliseconds: 675), }, { new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 38, milliseconds: 34), new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 12, milliseconds: 745), new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 37, milliseconds: 486), }, { new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 24, milliseconds: 276), new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 24, milliseconds: 442), new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 54, milliseconds: 327), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 26,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 36, milliseconds: 898), new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 43, milliseconds: 131), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 50, milliseconds: 246), }, { new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 13, milliseconds: 172), new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 6, milliseconds: 534), new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 58, milliseconds: 605), }, { new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 50, milliseconds: 851), new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 56, milliseconds: 91), new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 874), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 47, milliseconds: 959), new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 22, milliseconds: 638), new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 33, milliseconds: 407), }, { new TimeSpan(days: 0, hours: 12, minutes: 19, seconds: 15, milliseconds: 40), new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 52, milliseconds: 522), new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 51, milliseconds: 17), }, { new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 10, milliseconds: 84), new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 35, milliseconds: 303), new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 10, milliseconds: 292), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 20, milliseconds: 311), new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 22, milliseconds: 487), new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 8, milliseconds: 219), }, { new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 3, milliseconds: 735), new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 3, milliseconds: 408), new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 25, milliseconds: 938), }, { new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 43, milliseconds: 31), new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 32, milliseconds: 287), new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 49, milliseconds: 42), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 29, milliseconds: 340), new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 9, milliseconds: 279), new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 54, milliseconds: 716), }, { new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 22, milliseconds: 245), new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 11, milliseconds: 644), new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 50, milliseconds: 557), }, { new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 2, milliseconds: 267), new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 40, milliseconds: 734), new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 15, milliseconds: 355), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 7, milliseconds: 286), new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 19, milliseconds: 739), new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 11, milliseconds: 787), }, { new TimeSpan(days: 0, hours: 4, minutes: 17, seconds: 6, milliseconds: 289), new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 55, milliseconds: 308), new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 4, milliseconds: 41), }, { new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 41, milliseconds: 113), new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 26, milliseconds: 822), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 52, milliseconds: 397), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 24, seconds: 20, milliseconds: 566), new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 19, milliseconds: 457), new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 22, milliseconds: 42), }, { new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 37, milliseconds: 707), new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 58, milliseconds: 573), new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 56, milliseconds: 129), }, { new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 35, milliseconds: 548), new TimeSpan(days: 0, hours: 22, minutes: 35, seconds: 47, milliseconds: 269), new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 50, milliseconds: 105), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 4, milliseconds: 215), new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 52, milliseconds: 580), new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 57, milliseconds: 845), }, { new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 4, milliseconds: 374), new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 17, milliseconds: 125), new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 52, milliseconds: 817), }, { new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 43, milliseconds: 973), new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 15, milliseconds: 742), new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 11, milliseconds: 514), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 13, milliseconds: 345), new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 39, milliseconds: 11), new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 57, milliseconds: 514), }, { new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 55, milliseconds: 981), new TimeSpan(days: 0, hours: 4, minutes: 39, seconds: 39, milliseconds: 536), new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 22, milliseconds: 207), }, { new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 10, milliseconds: 680), new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 4, milliseconds: 225), new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 16, milliseconds: 997), }, }, { { new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 22, milliseconds: 212), new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 55, milliseconds: 122), new TimeSpan(days: 0, hours: 21, minutes: 50, seconds: 42, milliseconds: 749), }, { new TimeSpan(days: 0, hours: 20, minutes: 45, seconds: 17, milliseconds: 574), new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 10, milliseconds: 692), new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 54, milliseconds: 555), }, { new TimeSpan(days: 0, hours: 16, minutes: 29, seconds: 7, milliseconds: 287), new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 27, milliseconds: 361), new TimeSpan(days: 0, hours: 20, minutes: 13, seconds: 0, milliseconds: 779), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 35, milliseconds: 82), new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 2, milliseconds: 420), new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 40, milliseconds: 315), }, { new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 8, milliseconds: 19), new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 3, milliseconds: 975), new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 34, milliseconds: 659), }, { new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 15, milliseconds: 248), new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 4, milliseconds: 672), new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 22, milliseconds: 134), }, }, { { new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 17, milliseconds: 720), new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 44, milliseconds: 12), new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 27, milliseconds: 692), }, { new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 4, milliseconds: 586), new TimeSpan(days: 0, hours: 1, minutes: 26, seconds: 29, milliseconds: 248), new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 41, milliseconds: 993), }, { new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 34, milliseconds: 754), new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 36, milliseconds: 905), new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 13, milliseconds: 946), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 41, milliseconds: 585), new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 20, milliseconds: 499), new TimeSpan(days: 0, hours: 21, minutes: 14, seconds: 53, milliseconds: 93), }, { new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 50, milliseconds: 765), new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 45, milliseconds: 488), new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 14, milliseconds: 996), }, { new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 3, milliseconds: 111), new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 29, milliseconds: 507), new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 57, milliseconds: 533), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 33,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 18, minutes: 5, seconds: 20, milliseconds: 712), new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 35, milliseconds: 550), new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 32, milliseconds: 998), }, { new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 31, milliseconds: 23), new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 15, milliseconds: 685), new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 18, milliseconds: 404), }, { new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 37, milliseconds: 966), new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 41, milliseconds: 439), new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 19, milliseconds: 433), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 43, milliseconds: 772), new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 50, milliseconds: 129), new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 40, milliseconds: 115), }, { new TimeSpan(days: 0, hours: 4, minutes: 31, seconds: 5, milliseconds: 735), new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 47, milliseconds: 675), new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 14, milliseconds: 725), }, { new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 31, milliseconds: 862), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 3, milliseconds: 690), new TimeSpan(days: 0, hours: 7, minutes: 52, seconds: 57, milliseconds: 27), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 48, milliseconds: 779), new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 28, milliseconds: 654), new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 56, milliseconds: 287), }, { new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 33, milliseconds: 690), new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 45, milliseconds: 50), new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 31, milliseconds: 100), }, { new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 52, milliseconds: 803), new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 9, milliseconds: 96), new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 0, milliseconds: 68), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 40,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 50, milliseconds: 459), new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 37, milliseconds: 96), new TimeSpan(days: 0, hours: 12, minutes: 0, seconds: 25, milliseconds: 109), }, { new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 21, milliseconds: 401), new TimeSpan(days: 0, hours: 14, minutes: 6, seconds: 47, milliseconds: 696), new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 2, milliseconds: 351), }, { new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 2, milliseconds: 163), new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 45, milliseconds: 768), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 45, milliseconds: 209), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 35, milliseconds: 982), new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 8, milliseconds: 149), new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 36, milliseconds: 926), }, { new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 17, milliseconds: 162), new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 22, milliseconds: 612), new TimeSpan(days: 0, hours: 14, minutes: 36, seconds: 36, milliseconds: 780), }, { new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 20, milliseconds: 144), new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 33, milliseconds: 875), new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 49, milliseconds: 478), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 4, milliseconds: 797), new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 35, milliseconds: 280), new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 2, milliseconds: 215), }, { new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 29, milliseconds: 258), new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 42, milliseconds: 188), new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 24, milliseconds: 587), }, { new TimeSpan(days: 0, hours: 1, minutes: 17, seconds: 55, milliseconds: 840), new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 15, milliseconds: 270), new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 49, milliseconds: 552), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 17,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 19, milliseconds: 548), new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 18, milliseconds: 500), new TimeSpan(days: 0, hours: 4, minutes: 17, seconds: 38, milliseconds: 282), }, { new TimeSpan(days: 0, hours: 9, minutes: 34, seconds: 4, milliseconds: 708), new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 6, milliseconds: 912), new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 27, milliseconds: 181), }, { new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 0, milliseconds: 609), new TimeSpan(days: 0, hours: 17, minutes: 36, seconds: 2, milliseconds: 244), new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 47, milliseconds: 485), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 51, milliseconds: 588), new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 24, milliseconds: 521), new TimeSpan(days: 0, hours: 22, minutes: 48, seconds: 3, milliseconds: 968), }, { new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 36, milliseconds: 277), new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 17, milliseconds: 833), new TimeSpan(days: 0, hours: 19, minutes: 9, seconds: 55, milliseconds: 425), }, { new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 29, milliseconds: 779), new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 10, milliseconds: 356), new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 35, milliseconds: 565), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 19, seconds: 2, milliseconds: 980), new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 31, milliseconds: 595), new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 51, milliseconds: 281), }, { new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 19, milliseconds: 565), new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 3, milliseconds: 756), new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 32, milliseconds: 952), }, { new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 7, milliseconds: 701), new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 58, milliseconds: 544), new TimeSpan(days: 0, hours: 22, minutes: 6, seconds: 24, milliseconds: 918), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 5, milliseconds: 45), new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 13, milliseconds: 995), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 0, milliseconds: 689), }, { new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 3, milliseconds: 345), new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 27, milliseconds: 37), new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 46, milliseconds: 183), }, { new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 38, milliseconds: 730), new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 22, milliseconds: 226), new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 4, milliseconds: 6), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 19, milliseconds: 871), new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 25, milliseconds: 606), new TimeSpan(days: 0, hours: 6, minutes: 8, seconds: 44, milliseconds: 842), }, { new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 2, milliseconds: 98), new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 17, milliseconds: 523), new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 55, milliseconds: 195), }, { new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 32, milliseconds: 645), new TimeSpan(days: 0, hours: 5, minutes: 49, seconds: 25, milliseconds: 55), new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 12, milliseconds: 321), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 27, milliseconds: 572), new TimeSpan(days: 0, hours: 3, minutes: 14, seconds: 58, milliseconds: 856), new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 7, milliseconds: 497), }, { new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 14, milliseconds: 836), new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 3, milliseconds: 0), new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 4, milliseconds: 322), }, { new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 23, milliseconds: 445), new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 46, milliseconds: 519), new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 4, milliseconds: 564), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 23, milliseconds: 842), new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 44, milliseconds: 195), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 40, milliseconds: 970), }, { new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 11, milliseconds: 325), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 14, milliseconds: 226), new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 16, milliseconds: 941), }, { new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 19, milliseconds: 33), new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 37, milliseconds: 119), new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 211), }, }, { { new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 41, milliseconds: 551), new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 31, milliseconds: 745), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 17, milliseconds: 715), }, { new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 47, milliseconds: 612), new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 19, milliseconds: 891), new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 43, milliseconds: 460), }, { new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 55, milliseconds: 36), new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 56, milliseconds: 824), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 53, milliseconds: 291), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 43, milliseconds: 42), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 40, milliseconds: 605), new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 30, milliseconds: 767), }, { new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 6, milliseconds: 937), new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 3, milliseconds: 744), new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 40, milliseconds: 354), }, { new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 30, milliseconds: 744), new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 28, milliseconds: 325), new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 36, milliseconds: 799), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 41,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 27, milliseconds: 634), new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 35, milliseconds: 932), new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 45, milliseconds: 821), }, { new TimeSpan(days: 0, hours: 9, minutes: 42, seconds: 12, milliseconds: 255), new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 12, milliseconds: 318), new TimeSpan(days: 0, hours: 22, minutes: 53, seconds: 16, milliseconds: 177), }, { new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 53, milliseconds: 893), new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 37, milliseconds: 56), new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 35, milliseconds: 279), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 48, milliseconds: 6), new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 19, milliseconds: 449), new TimeSpan(days: 0, hours: 16, minutes: 33, seconds: 33, milliseconds: 265), }, { new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 19, milliseconds: 436), new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 36, milliseconds: 355), new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 46, milliseconds: 136), }, { new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 30, milliseconds: 331), new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 26, milliseconds: 171), new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 1, milliseconds: 872), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 43, milliseconds: 609), new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 14, milliseconds: 329), new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 1, milliseconds: 968), }, { new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 31, milliseconds: 450), new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 3, milliseconds: 580), new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 24, milliseconds: 269), }, { new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 19, milliseconds: 161), new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 29, milliseconds: 371), new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 37, milliseconds: 629), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 45,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 56, milliseconds: 75), new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 38, milliseconds: 188), new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 23, milliseconds: 543), }, { new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 8, milliseconds: 440), new TimeSpan(days: 0, hours: 5, minutes: 32, seconds: 14, milliseconds: 0), new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 44, milliseconds: 524), }, { new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 24, milliseconds: 489), new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 27, milliseconds: 783), new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 4, milliseconds: 731), }, }, { { new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 41, milliseconds: 420), new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 21, milliseconds: 295), new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 35, milliseconds: 888), }, { new TimeSpan(days: 0, hours: 19, minutes: 25, seconds: 24, milliseconds: 895), new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 12, milliseconds: 866), new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 57, milliseconds: 312), }, { new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 1, milliseconds: 403), new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 5, milliseconds: 137), new TimeSpan(days: 0, hours: 17, minutes: 45, seconds: 26, milliseconds: 696), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 27, milliseconds: 859), new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 49, milliseconds: 453), new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 14, milliseconds: 680), }, { new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 48, milliseconds: 593), new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 18, milliseconds: 334), new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 45, milliseconds: 516), }, { new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 33, milliseconds: 886), new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 0, milliseconds: 82), new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 9, milliseconds: 532), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 20,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 42, milliseconds: 61), new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 35, milliseconds: 927), new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 58, milliseconds: 490), }, { new TimeSpan(days: 0, hours: 12, minutes: 37, seconds: 2, milliseconds: 511), new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 46, milliseconds: 137), new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 27, milliseconds: 325), }, { new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 41, milliseconds: 828), new TimeSpan(days: 0, hours: 0, minutes: 7, seconds: 27, milliseconds: 160), new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 22, milliseconds: 853), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 38, milliseconds: 984), new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 36, milliseconds: 819), new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 56, milliseconds: 34), }, { new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 49, milliseconds: 124), new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 49, milliseconds: 541), new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 43, milliseconds: 991), }, { new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 37, milliseconds: 536), new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 54, milliseconds: 126), new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 9, milliseconds: 581), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 43, milliseconds: 393), new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 18, milliseconds: 353), new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 30, milliseconds: 20), }, { new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 18, milliseconds: 320), new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 1, milliseconds: 576), new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 43, milliseconds: 313), }, { new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 0, milliseconds: 347), new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 13, milliseconds: 615), new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 56, milliseconds: 90), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 55, milliseconds: 445), new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 30, milliseconds: 882), new TimeSpan(days: 0, hours: 18, minutes: 22, seconds: 17, milliseconds: 41), }, { new TimeSpan(days: 0, hours: 18, minutes: 33, seconds: 32, milliseconds: 924), new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 25, milliseconds: 41), new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 10, milliseconds: 882), }, { new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 26, milliseconds: 641), new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 7, milliseconds: 977), new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 55, milliseconds: 539), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 20, milliseconds: 66), new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 37, milliseconds: 797), new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 7, milliseconds: 818), }, { new TimeSpan(days: 0, hours: 5, minutes: 19, seconds: 53, milliseconds: 916), new TimeSpan(days: 0, hours: 12, minutes: 8, seconds: 5, milliseconds: 785), new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 58, milliseconds: 625), }, { new TimeSpan(days: 0, hours: 2, minutes: 56, seconds: 13, milliseconds: 265), new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 43, milliseconds: 221), new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 39, milliseconds: 820), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 34, seconds: 7, milliseconds: 301), new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 7, milliseconds: 240), new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 45, milliseconds: 110), }, { new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 23, milliseconds: 112), new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 22, milliseconds: 566), new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 18, milliseconds: 642), }, { new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 5, milliseconds: 810), new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 37, milliseconds: 224), new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 34, milliseconds: 154), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 53, milliseconds: 686), new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 42, milliseconds: 414), new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 2, milliseconds: 208), }, { new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 16, milliseconds: 522), new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 58, milliseconds: 117), new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 7, milliseconds: 51), }, { new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 30, milliseconds: 280), new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 50, milliseconds: 175), new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 22, milliseconds: 469), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 26, milliseconds: 862), new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 14, milliseconds: 435), new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 37, milliseconds: 799), }, { new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 49, milliseconds: 711), new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 48, milliseconds: 580), new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 9, milliseconds: 186), }, { new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 4, milliseconds: 418), new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 4, milliseconds: 306), new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 38, milliseconds: 645), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 13, milliseconds: 181), new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 18, milliseconds: 818), new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 9, milliseconds: 711), }, { new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 6, milliseconds: 145), new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 12, milliseconds: 186), new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 0, milliseconds: 981), }, { new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 19, milliseconds: 334), new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 48, milliseconds: 329), new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 1, milliseconds: 163), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 46,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 29, milliseconds: 694), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 52, milliseconds: 253), new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 57, milliseconds: 95), }, { new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 13, milliseconds: 98), new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 34, milliseconds: 391), new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 24, milliseconds: 89), }, { new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 51, milliseconds: 381), new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 17, milliseconds: 78), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 15, milliseconds: 414), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 13, milliseconds: 700), new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 57, milliseconds: 900), new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 8, milliseconds: 244), }, { new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 38, milliseconds: 369), new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 10, milliseconds: 6), new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 45, milliseconds: 549), }, { new TimeSpan(days: 0, hours: 6, minutes: 8, seconds: 26, milliseconds: 766), new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 42, milliseconds: 969), new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 21, milliseconds: 82), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 18, milliseconds: 710), new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 38, milliseconds: 701), new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 46, milliseconds: 483), }, { new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 10, milliseconds: 495), new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 57, milliseconds: 881), new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 48, milliseconds: 724), }, { new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 7, milliseconds: 292), new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 16, milliseconds: 356), new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 36, milliseconds: 77), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 55,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 6, milliseconds: 25), new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 53, milliseconds: 613), new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 50, milliseconds: 301), }, { new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 52, milliseconds: 345), new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 20, milliseconds: 320), new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 56, milliseconds: 881), }, { new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 42, milliseconds: 355), new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 56, milliseconds: 296), new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 58, milliseconds: 111), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 3, seconds: 1, milliseconds: 319), new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 39, milliseconds: 45), new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 46, milliseconds: 142), }, { new TimeSpan(days: 0, hours: 14, minutes: 50, seconds: 19, milliseconds: 587), new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 8, milliseconds: 608), new TimeSpan(days: 0, hours: 10, minutes: 5, seconds: 56, milliseconds: 443), }, { new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 43, milliseconds: 131), new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 12, milliseconds: 687), new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 3, milliseconds: 940), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 20, milliseconds: 610), new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 48, milliseconds: 961), new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 12, milliseconds: 909), }, { new TimeSpan(days: 0, hours: 18, minutes: 20, seconds: 35, milliseconds: 50), new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 11, milliseconds: 746), new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 51, milliseconds: 36), }, { new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 9, milliseconds: 329), new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 50, milliseconds: 978), new TimeSpan(days: 0, hours: 18, minutes: 28, seconds: 32, milliseconds: 822), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 29,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 20, milliseconds: 311), new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 45, milliseconds: 857), new TimeSpan(days: 0, hours: 18, minutes: 48, seconds: 57, milliseconds: 320), }, { new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 35, milliseconds: 615), new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 2, milliseconds: 401), new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 4, milliseconds: 117), }, { new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 11, milliseconds: 601), new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 58, milliseconds: 265), new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 44, milliseconds: 849), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 14, milliseconds: 372), new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 20, milliseconds: 130), new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 28, milliseconds: 398), }, { new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 27, milliseconds: 145), new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 38, milliseconds: 186), new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 30, milliseconds: 758), }, { new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 46, milliseconds: 19), new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 38, milliseconds: 456), new TimeSpan(days: 0, hours: 9, minutes: 34, seconds: 43, milliseconds: 759), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 45, seconds: 4, milliseconds: 278), new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 3, milliseconds: 440), new TimeSpan(days: 0, hours: 14, minutes: 41, seconds: 2, milliseconds: 279), }, { new TimeSpan(days: 0, hours: 5, minutes: 26, seconds: 56, milliseconds: 693), new TimeSpan(days: 0, hours: 13, minutes: 24, seconds: 12, milliseconds: 272), new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 37, milliseconds: 89), }, { new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 16, milliseconds: 149), new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 55, milliseconds: 54), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 30, milliseconds: 966), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 0, milliseconds: 887), new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 40, milliseconds: 804), new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 57, milliseconds: 215), }, { new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 45, milliseconds: 257), new TimeSpan(days: 0, hours: 0, minutes: 54, seconds: 38, milliseconds: 937), new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 39, milliseconds: 522), }, { new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 9, milliseconds: 713), new TimeSpan(days: 0, hours: 16, minutes: 49, seconds: 57, milliseconds: 864), new TimeSpan(days: 0, hours: 1, minutes: 29, seconds: 23, milliseconds: 458), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 11, milliseconds: 238), new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 25, milliseconds: 180), new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 35, milliseconds: 443), }, { new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 54, milliseconds: 169), new TimeSpan(days: 0, hours: 14, minutes: 14, seconds: 40, milliseconds: 361), new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 55, milliseconds: 186), }, { new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 44, milliseconds: 155), new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 52, milliseconds: 135), new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 0, milliseconds: 718), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 2, milliseconds: 348), new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 49, milliseconds: 722), new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 19, milliseconds: 467), }, { new TimeSpan(days: 0, hours: 12, minutes: 58, seconds: 40, milliseconds: 250), new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 58, milliseconds: 790), new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 8, milliseconds: 579), }, { new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 9, milliseconds: 101), new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 57, milliseconds: 712), new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 53, milliseconds: 863), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 50, milliseconds: 679), new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 54, milliseconds: 252), new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 6, milliseconds: 454), }, { new TimeSpan(days: 0, hours: 14, minutes: 36, seconds: 40, milliseconds: 13), new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 34, milliseconds: 548), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 16, milliseconds: 16), }, { new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 6, milliseconds: 653), new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 17, milliseconds: 506), new TimeSpan(days: 0, hours: 0, minutes: 42, seconds: 49, milliseconds: 466), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 49, seconds: 17, milliseconds: 782), new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 24, milliseconds: 395), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 57, milliseconds: 963), }, { new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 26, milliseconds: 831), new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 56, milliseconds: 808), new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 43, milliseconds: 359), }, { new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 13, milliseconds: 944), new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 37, milliseconds: 772), new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 17, milliseconds: 529), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 20, milliseconds: 373), new TimeSpan(days: 0, hours: 9, minutes: 8, seconds: 16, milliseconds: 17), new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 17, milliseconds: 643), }, { new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 35, milliseconds: 892), new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 53, milliseconds: 987), new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 22, milliseconds: 879), }, { new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 31, milliseconds: 199), new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 43, milliseconds: 482), new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 22, milliseconds: 171), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 62,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 20, minutes: 54, seconds: 55, milliseconds: 91), new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 6, milliseconds: 582), new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 45, milliseconds: 677), }, { new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 1, milliseconds: 376), new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 29, milliseconds: 736), new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 42, milliseconds: 664), }, { new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 18, milliseconds: 420), new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 41, milliseconds: 601), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 56, milliseconds: 280), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 19, milliseconds: 960), new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 21, milliseconds: 803), new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 29, milliseconds: 388), }, { new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 50, milliseconds: 221), new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 54, milliseconds: 159), new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 10, milliseconds: 28), }, { new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 58, milliseconds: 889), new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 3, milliseconds: 135), new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 5, milliseconds: 317), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 41, seconds: 13, milliseconds: 124), new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 30, milliseconds: 201), new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 34, milliseconds: 92), }, { new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 17, milliseconds: 596), new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 10, milliseconds: 474), new TimeSpan(days: 0, hours: 22, minutes: 50, seconds: 6, milliseconds: 852), }, { new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 17, milliseconds: 144), new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 50, milliseconds: 488), new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 36, milliseconds: 779), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 69,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 26, milliseconds: 132), new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 46, milliseconds: 43), new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 3, milliseconds: 817), }, { new TimeSpan(days: 0, hours: 0, minutes: 19, seconds: 32, milliseconds: 405), new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 9, milliseconds: 525), new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 5, milliseconds: 765), }, { new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 12, milliseconds: 150), new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 41, milliseconds: 814), new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 20, milliseconds: 260), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 2, seconds: 0, milliseconds: 203), new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 57, milliseconds: 860), new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 50, milliseconds: 579), }, { new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 32, milliseconds: 290), new TimeSpan(days: 0, hours: 3, minutes: 8, seconds: 27, milliseconds: 376), new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 48, milliseconds: 577), }, { new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 12, milliseconds: 310), new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 13, milliseconds: 278), new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 29, milliseconds: 967), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 0, milliseconds: 977), new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 18, milliseconds: 87), new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 46, milliseconds: 42), }, { new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 18, milliseconds: 782), new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 31, milliseconds: 738), new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 45, milliseconds: 313), }, { new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 13, milliseconds: 541), new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 26, milliseconds: 533), new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 35, milliseconds: 791), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 33,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 13, milliseconds: 793), new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 12, milliseconds: 840), new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 17, milliseconds: 160), }, { new TimeSpan(days: 0, hours: 19, minutes: 34, seconds: 12, milliseconds: 594), new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 38, milliseconds: 660), new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 33, milliseconds: 404), }, { new TimeSpan(days: 0, hours: 2, minutes: 6, seconds: 41, milliseconds: 245), new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 19, milliseconds: 696), new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 11, milliseconds: 105), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 19, milliseconds: 817), new TimeSpan(days: 0, hours: 0, minutes: 8, seconds: 13, milliseconds: 437), new TimeSpan(days: 0, hours: 15, minutes: 24, seconds: 24, milliseconds: 304), }, { new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 2, milliseconds: 457), new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 10, milliseconds: 159), new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 58, milliseconds: 685), }, { new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 45, milliseconds: 614), new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 18, milliseconds: 473), new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 8, milliseconds: 468), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 8, milliseconds: 300), new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 30, milliseconds: 193), new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 6, milliseconds: 14), }, { new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 44, milliseconds: 316), new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 4, milliseconds: 803), new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 46, milliseconds: 785), }, { new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 21, milliseconds: 632), new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 26, milliseconds: 161), new TimeSpan(days: 0, hours: 22, minutes: 35, seconds: 43, milliseconds: 328), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 15, milliseconds: 336), new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 28, milliseconds: 286), new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 24, milliseconds: 780), }, { new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 4, milliseconds: 283), new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 1, milliseconds: 48), new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 42, milliseconds: 688), }, { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 37, milliseconds: 523), new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 8, milliseconds: 269), new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 2, milliseconds: 72), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 22, milliseconds: 309), new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 47, milliseconds: 406), new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 20, milliseconds: 600), }, { new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 37, milliseconds: 75), new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 11, milliseconds: 629), new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 34, milliseconds: 948), }, { new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 20, milliseconds: 150), new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 11, milliseconds: 815), new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 39, milliseconds: 568), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 29, milliseconds: 417), new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 30, milliseconds: 810), new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 29, milliseconds: 157), }, { new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 25, milliseconds: 287), new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 42, milliseconds: 336), new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 47, milliseconds: 832), }, { new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 20, milliseconds: 786), new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 29, milliseconds: 459), new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 4, milliseconds: 838), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 76,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 22, milliseconds: 72), new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 38, milliseconds: 403), new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 5, milliseconds: 374), }, { new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 32, milliseconds: 803), new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 29, milliseconds: 190), new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 20, milliseconds: 287), }, { new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 22, milliseconds: 824), new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 25, milliseconds: 866), new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 8, milliseconds: 787), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 45, milliseconds: 282), new TimeSpan(days: 0, hours: 14, minutes: 38, seconds: 41, milliseconds: 579), new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 50, milliseconds: 504), }, { new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 50, milliseconds: 870), new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 53, milliseconds: 556), new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 47, milliseconds: 826), }, { new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 50, milliseconds: 969), new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 55, milliseconds: 224), new TimeSpan(days: 0, hours: 19, minutes: 50, seconds: 45, milliseconds: 209), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 39, milliseconds: 943), new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 45, milliseconds: 840), new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 24, milliseconds: 710), }, { new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 12, milliseconds: 808), new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 24, milliseconds: 870), new TimeSpan(days: 0, hours: 18, minutes: 34, seconds: 46, milliseconds: 291), }, { new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 58, milliseconds: 495), new TimeSpan(days: 0, hours: 6, minutes: 16, seconds: 36, milliseconds: 506), new TimeSpan(days: 0, hours: 3, minutes: 1, seconds: 5, milliseconds: 20), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 81,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 18, minutes: 26, seconds: 3, milliseconds: 57), new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 18, milliseconds: 524), new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 26, milliseconds: 598), }, { new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 0, milliseconds: 680), new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 41, milliseconds: 786), new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 37, milliseconds: 871), }, { new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 36, milliseconds: 244), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 21, milliseconds: 485), new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 29, milliseconds: 736), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 49, milliseconds: 221), new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 11, milliseconds: 203), new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 28, milliseconds: 553), }, { new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 25, milliseconds: 372), new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 37, milliseconds: 867), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 36, milliseconds: 112), }, { new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 34, milliseconds: 761), new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 51, milliseconds: 236), new TimeSpan(days: 0, hours: 5, minutes: 39, seconds: 47, milliseconds: 328), }, }, { { new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 58, milliseconds: 574), new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 8, milliseconds: 654), new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 1, milliseconds: 123), }, { new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 34, milliseconds: 104), new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 34, milliseconds: 692), new TimeSpan(days: 0, hours: 1, minutes: 8, seconds: 10, milliseconds: 389), }, { new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 39, milliseconds: 54), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 47, milliseconds: 521), new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 42, milliseconds: 205), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 58, milliseconds: 279), new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 27, milliseconds: 702), new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 46, milliseconds: 726), }, { new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 11, milliseconds: 361), new TimeSpan(days: 0, hours: 22, minutes: 6, seconds: 49, milliseconds: 145), new TimeSpan(days: 0, hours: 10, minutes: 5, seconds: 3, milliseconds: 380), }, { new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 38, milliseconds: 103), new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 41, milliseconds: 444), new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 55, milliseconds: 344), }, }, { { new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 56, milliseconds: 354), new TimeSpan(days: 0, hours: 7, minutes: 31, seconds: 29, milliseconds: 871), new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 4, milliseconds: 698), }, { new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 22, milliseconds: 844), new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 7, milliseconds: 124), new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 54, milliseconds: 727), }, { new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 6, milliseconds: 58), new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 44, milliseconds: 754), new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 3, milliseconds: 35), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 46, milliseconds: 979), new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 21, milliseconds: 192), new TimeSpan(days: 0, hours: 19, minutes: 19, seconds: 12, milliseconds: 872), }, { new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 23, milliseconds: 860), new TimeSpan(days: 0, hours: 11, minutes: 53, seconds: 15, milliseconds: 476), new TimeSpan(days: 0, hours: 15, minutes: 47, seconds: 47, milliseconds: 75), }, { new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 19, milliseconds: 135), new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 38, milliseconds: 673), new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 8, milliseconds: 584), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 32, milliseconds: 215), new TimeSpan(days: 0, hours: 21, minutes: 56, seconds: 9, milliseconds: 54), new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 14, milliseconds: 337), }, { new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 30, milliseconds: 940), new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 39, milliseconds: 261), new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 50, milliseconds: 180), }, { new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 58, milliseconds: 744), new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 0, milliseconds: 773), new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 52, milliseconds: 449), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 25, milliseconds: 583), new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 2, milliseconds: 728), new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 56, milliseconds: 921), }, { new TimeSpan(days: 0, hours: 8, minutes: 11, seconds: 11, milliseconds: 816), new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 56, milliseconds: 261), new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 23, milliseconds: 5), }, { new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 36, milliseconds: 151), new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 20, milliseconds: 391), new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 9, milliseconds: 798), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 1, milliseconds: 561), new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 48, milliseconds: 944), new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 30, milliseconds: 141), }, { new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 45, milliseconds: 906), new TimeSpan(days: 0, hours: 7, minutes: 1, seconds: 24, milliseconds: 684), new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 34, milliseconds: 259), }, { new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 31, milliseconds: 624), new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 45, milliseconds: 859), new TimeSpan(days: 0, hours: 16, minutes: 46, seconds: 32, milliseconds: 645), }, }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 33, milliseconds: 809), new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 47, milliseconds: 330), new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 29, milliseconds: 816), }, { new TimeSpan(days: 0, hours: 3, minutes: 29, seconds: 22, milliseconds: 383), new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 54, milliseconds: 761), new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 2, milliseconds: 664), }, { new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 29, milliseconds: 875), new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 29, milliseconds: 194), new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 35, milliseconds: 94), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 12, milliseconds: 239), new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 15, milliseconds: 602), new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 24, milliseconds: 535), }, { new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 28, milliseconds: 52), new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 45, milliseconds: 141), new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 39, milliseconds: 581), }, { new TimeSpan(days: 0, hours: 11, minutes: 9, seconds: 16, milliseconds: 969), new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 44, milliseconds: 923), new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 17, milliseconds: 793), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 28, seconds: 17, milliseconds: 365), new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 28, milliseconds: 647), new TimeSpan(days: 0, hours: 6, minutes: 13, seconds: 14, milliseconds: 484), }, { new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 3, milliseconds: 521), new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 49, milliseconds: 263), new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 51, milliseconds: 872), }, { new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 57, milliseconds: 503), new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 53, milliseconds: 574), new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 32, milliseconds: 283), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 90,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 40, milliseconds: 659), new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 1, milliseconds: 516), new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 23, milliseconds: 985), }, { new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 40, milliseconds: 34), new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 15, milliseconds: 671), new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 51, milliseconds: 777), }, { new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 8, milliseconds: 491), new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 22, milliseconds: 153), new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 36, milliseconds: 752), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 26, milliseconds: 604), new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 12, milliseconds: 400), new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 34, milliseconds: 812), }, { new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 40, milliseconds: 996), new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 55, milliseconds: 828), new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 14, milliseconds: 525), }, { new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 32, milliseconds: 502), new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 42, milliseconds: 626), new TimeSpan(days: 0, hours: 12, minutes: 36, seconds: 29, milliseconds: 880), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 31, milliseconds: 524), new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 16, milliseconds: 484), new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 2, milliseconds: 883), }, { new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 54, milliseconds: 591), new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 9, milliseconds: 934), new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 32, milliseconds: 355), }, { new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 46, milliseconds: 25), new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 6, milliseconds: 848), new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 29, milliseconds: 860), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 43,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 13, minutes: 29, seconds: 13, milliseconds: 403), new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 43, milliseconds: 17), new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 17, milliseconds: 573), }, { new TimeSpan(days: 0, hours: 10, minutes: 32, seconds: 49, milliseconds: 913), new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 54, milliseconds: 949), new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 55, milliseconds: 216), }, { new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 38, milliseconds: 215), new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 16, milliseconds: 814), new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 6, milliseconds: 941), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 20, seconds: 42, milliseconds: 613), new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 51, milliseconds: 623), new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 43, milliseconds: 848), }, { new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 19, milliseconds: 629), new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 57, milliseconds: 845), new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 37, milliseconds: 675), }, { new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 28, milliseconds: 712), new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 58, milliseconds: 689), new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 11, milliseconds: 46), }, }, { { new TimeSpan(days: 0, hours: 21, minutes: 23, seconds: 46, milliseconds: 652), new TimeSpan(days: 0, hours: 10, minutes: 33, seconds: 0, milliseconds: 909), new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 21, milliseconds: 632), }, { new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 36, milliseconds: 843), new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 10, milliseconds: 364), new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 13, milliseconds: 15), }, { new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 19, milliseconds: 488), new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 50, milliseconds: 856), new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 3, milliseconds: 706), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 9, milliseconds: 439), new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 8, milliseconds: 805), new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 54, milliseconds: 42), }, { new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 23, milliseconds: 639), new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 37, milliseconds: 207), new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 1, milliseconds: 574), }, { new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 3, milliseconds: 142), new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 54, milliseconds: 352), new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 11, milliseconds: 769), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 24, milliseconds: 484), new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 48, milliseconds: 521), new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 56, milliseconds: 10), }, { new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 58, milliseconds: 467), new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 27, milliseconds: 158), new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 7, milliseconds: 679), }, { new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 10, milliseconds: 908), new TimeSpan(days: 0, hours: 0, minutes: 40, seconds: 17, milliseconds: 870), new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 32, milliseconds: 593), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 3, milliseconds: 666), new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 9, milliseconds: 611), new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 50, milliseconds: 459), }, { new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 10, milliseconds: 599), new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 39, milliseconds: 20), new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 51, milliseconds: 466), }, { new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 3, milliseconds: 410), new TimeSpan(days: 0, hours: 8, minutes: 15, seconds: 30, milliseconds: 840), new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 0, milliseconds: 767), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 91,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 37, milliseconds: 228), new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 39, milliseconds: 310), new TimeSpan(days: 0, hours: 19, minutes: 23, seconds: 41, milliseconds: 487), }, { new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 37, milliseconds: 788), new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 15, milliseconds: 895), new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 22, milliseconds: 17), }, { new TimeSpan(days: 0, hours: 20, minutes: 1, seconds: 25, milliseconds: 313), new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 0, milliseconds: 760), new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 26, milliseconds: 502), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 25, seconds: 19, milliseconds: 380), new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 12, milliseconds: 533), new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 47, milliseconds: 941), }, { new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 7, milliseconds: 451), new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 28, milliseconds: 731), new TimeSpan(days: 0, hours: 20, minutes: 10, seconds: 41, milliseconds: 698), }, { new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 53, milliseconds: 765), new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 15, milliseconds: 214), new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 25, milliseconds: 626), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 38, milliseconds: 930), new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 27, milliseconds: 492), new TimeSpan(days: 0, hours: 4, minutes: 1, seconds: 20, milliseconds: 182), }, { new TimeSpan(days: 0, hours: 2, minutes: 3, seconds: 16, milliseconds: 424), new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 34, milliseconds: 455), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 15, milliseconds: 425), }, { new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 37, milliseconds: 677), new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 965), new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 31, milliseconds: 560), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 11, milliseconds: 261), new TimeSpan(days: 0, hours: 22, minutes: 35, seconds: 39, milliseconds: 782), new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 55, milliseconds: 989), }, { new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 9, milliseconds: 616), new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 28, milliseconds: 908), new TimeSpan(days: 0, hours: 5, minutes: 3, seconds: 38, milliseconds: 368), }, { new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 0, milliseconds: 433), new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 16, milliseconds: 78), new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 57, milliseconds: 938), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 20, milliseconds: 237), new TimeSpan(days: 0, hours: 6, minutes: 55, seconds: 43, milliseconds: 148), new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 11, milliseconds: 562), }, { new TimeSpan(days: 0, hours: 10, minutes: 32, seconds: 32, milliseconds: 676), new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 15, milliseconds: 356), new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 55, milliseconds: 860), }, { new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 29, milliseconds: 631), new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 24, milliseconds: 626), new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 19, milliseconds: 448), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 13, milliseconds: 737), new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 4, milliseconds: 257), new TimeSpan(days: 0, hours: 19, minutes: 27, seconds: 15, milliseconds: 788), }, { new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 27, milliseconds: 603), new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 30, milliseconds: 419), new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 13, milliseconds: 356), }, { new TimeSpan(days: 0, hours: 17, minutes: 5, seconds: 36, milliseconds: 787), new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 40, milliseconds: 835), new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 20, milliseconds: 50), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 99,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 44, milliseconds: 463), new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 47, milliseconds: 589), new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 58, milliseconds: 224), }, { new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 27, milliseconds: 542), new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 49, milliseconds: 724), new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 43, milliseconds: 923), }, { new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 18, milliseconds: 292), new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 49, milliseconds: 806), new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 2, milliseconds: 520), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 22, milliseconds: 686), new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 37, milliseconds: 203), new TimeSpan(days: 0, hours: 15, minutes: 48, seconds: 57, milliseconds: 702), }, { new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 32, milliseconds: 581), new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 19, milliseconds: 176), new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 27, milliseconds: 728), }, { new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 32, milliseconds: 347), new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 32, milliseconds: 364), new TimeSpan(days: 0, hours: 9, minutes: 27, seconds: 33, milliseconds: 235), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 14, milliseconds: 251), new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 14, milliseconds: 474), new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 16, milliseconds: 405), }, { new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 26, milliseconds: 635), new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 45, milliseconds: 996), new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 30, milliseconds: 192), }, { new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 0, milliseconds: 778), new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 14, milliseconds: 225), new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 12, milliseconds: 970), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 50,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 8, minutes: 58, seconds: 22, milliseconds: 137), new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 53, milliseconds: 448), new TimeSpan(days: 0, hours: 7, minutes: 56, seconds: 55, milliseconds: 502), }, { new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 20, milliseconds: 820), new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 17, milliseconds: 922), new TimeSpan(days: 0, hours: 7, minutes: 11, seconds: 27, milliseconds: 65), }, { new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 49, milliseconds: 465), new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 10, milliseconds: 855), new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 9, milliseconds: 489), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 56, milliseconds: 752), new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 34, milliseconds: 376), new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 52, milliseconds: 934), }, { new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 58, milliseconds: 258), new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 43, milliseconds: 917), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 10, milliseconds: 976), }, { new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 7, milliseconds: 533), new TimeSpan(days: 0, hours: 7, minutes: 28, seconds: 4, milliseconds: 761), new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 33, milliseconds: 788), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 44, milliseconds: 377), new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 27, milliseconds: 394), new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 32, milliseconds: 211), }, { new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 28, milliseconds: 742), new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 34, milliseconds: 635), new TimeSpan(days: 0, hours: 19, minutes: 11, seconds: 36, milliseconds: 379), }, { new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 17, milliseconds: 222), new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 1, milliseconds: 48), new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 17, milliseconds: 87), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 100,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 13, minutes: 26, seconds: 17, milliseconds: 771), new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 4, milliseconds: 20), new TimeSpan(days: 0, hours: 20, minutes: 36, seconds: 53, milliseconds: 81), }, { new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 23, milliseconds: 635), new TimeSpan(days: 0, hours: 22, minutes: 18, seconds: 12, milliseconds: 558), new TimeSpan(days: 0, hours: 10, minutes: 28, seconds: 46, milliseconds: 513), }, { new TimeSpan(days: 0, hours: 21, minutes: 17, seconds: 50, milliseconds: 521), new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 15, milliseconds: 334), new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 38, milliseconds: 252), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 34, milliseconds: 712), new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 46, milliseconds: 793), new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 26, milliseconds: 632), }, { new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 54, milliseconds: 519), new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 10, milliseconds: 729), new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 29, milliseconds: 350), }, { new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 15, milliseconds: 256), new TimeSpan(days: 0, hours: 17, minutes: 47, seconds: 13, milliseconds: 652), new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 55, milliseconds: 923), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 13, milliseconds: 293), new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 0, milliseconds: 794), new TimeSpan(days: 0, hours: 13, minutes: 30, seconds: 43, milliseconds: 140), }, { new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 9, milliseconds: 829), new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 22, milliseconds: 666), new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 39, milliseconds: 490), }, { new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 52, milliseconds: 786), new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 5, milliseconds: 329), new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 26, milliseconds: 485), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 101,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 13, milliseconds: 311), new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 55, milliseconds: 893), new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 50, milliseconds: 575), }, { new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 20, milliseconds: 359), new TimeSpan(days: 0, hours: 15, minutes: 43, seconds: 5, milliseconds: 312), new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 36, milliseconds: 411), }, { new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 6, milliseconds: 745), new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 51, milliseconds: 629), new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 5, milliseconds: 287), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 48, milliseconds: 17), new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 29, milliseconds: 242), new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 6, milliseconds: 907), }, { new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 33, milliseconds: 789), new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 0, milliseconds: 607), new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 27, milliseconds: 873), }, { new TimeSpan(days: 0, hours: 3, minutes: 38, seconds: 43, milliseconds: 229), new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 26, milliseconds: 837), new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 47, milliseconds: 182), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 42, milliseconds: 482), new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 55, milliseconds: 746), new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 4, milliseconds: 240), }, { new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 48, milliseconds: 685), new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 43, milliseconds: 411), new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 36, milliseconds: 594), }, { new TimeSpan(days: 0, hours: 13, minutes: 6, seconds: 55, milliseconds: 257), new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 46, milliseconds: 161), new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 3, milliseconds: 594), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 51,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 54, milliseconds: 962), new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 39, milliseconds: 623), new TimeSpan(days: 0, hours: 12, minutes: 51, seconds: 3, milliseconds: 290), }, { new TimeSpan(days: 0, hours: 0, minutes: 24, seconds: 4, milliseconds: 254), new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 10, milliseconds: 253), new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 26, milliseconds: 439), }, { new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 31, milliseconds: 792), new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 29, milliseconds: 195), new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 11, milliseconds: 578), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 42, seconds: 33, milliseconds: 125), new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 3, milliseconds: 344), new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 19, milliseconds: 67), }, { new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 31, milliseconds: 637), new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 9, milliseconds: 631), new TimeSpan(days: 0, hours: 22, minutes: 30, seconds: 29, milliseconds: 951), }, { new TimeSpan(days: 0, hours: 16, minutes: 41, seconds: 11, milliseconds: 373), new TimeSpan(days: 0, hours: 22, minutes: 24, seconds: 43, milliseconds: 422), new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 49, milliseconds: 552), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 38, milliseconds: 908), new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 48, milliseconds: 573), new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 27, milliseconds: 426), }, { new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 34, milliseconds: 231), new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 4, milliseconds: 569), new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 32, milliseconds: 774), }, { new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 47, milliseconds: 754), new TimeSpan(days: 0, hours: 4, minutes: 55, seconds: 51, milliseconds: 65), new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 47, milliseconds: 985), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 54, seconds: 36, milliseconds: 462), new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 52, milliseconds: 880), new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 6, milliseconds: 659), }, { new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 49, milliseconds: 539), new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 12, milliseconds: 204), new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 9, milliseconds: 839), }, { new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 16, milliseconds: 315), new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 17, milliseconds: 610), new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 29, milliseconds: 739), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 9, milliseconds: 663), new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 0, milliseconds: 387), new TimeSpan(days: 0, hours: 2, minutes: 47, seconds: 6, milliseconds: 737), }, { new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 47, milliseconds: 213), new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 24, milliseconds: 791), new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 43, milliseconds: 996), }, { new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 58, milliseconds: 329), new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 3, milliseconds: 955), new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 2, milliseconds: 760), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 41, milliseconds: 177), new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 47, milliseconds: 139), new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 55, milliseconds: 972), }, { new TimeSpan(days: 0, hours: 19, minutes: 50, seconds: 57, milliseconds: 293), new TimeSpan(days: 0, hours: 15, minutes: 16, seconds: 13, milliseconds: 261), new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 40, milliseconds: 278), }, { new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 39, milliseconds: 810), new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 17, milliseconds: 168), new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 32, milliseconds: 299), }, }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 103,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 20, milliseconds: 337), new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 57, milliseconds: 854), new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 51, milliseconds: 111), }, { new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 12, milliseconds: 105), new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 35, milliseconds: 80), new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 35, milliseconds: 530), }, { new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 40, milliseconds: 234), new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 52, milliseconds: 565), new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 2, milliseconds: 579), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 43, milliseconds: 15), new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 33, milliseconds: 304), new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 26, milliseconds: 622), }, { new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 43, milliseconds: 422), new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 11, milliseconds: 205), new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 22, milliseconds: 93), }, { new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 25, milliseconds: 263), new TimeSpan(days: 0, hours: 0, minutes: 34, seconds: 57, milliseconds: 411), new TimeSpan(days: 0, hours: 3, minutes: 52, seconds: 47, milliseconds: 288), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 41, milliseconds: 149), new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 44, milliseconds: 914), new TimeSpan(days: 0, hours: 6, minutes: 8, seconds: 32, milliseconds: 406), }, { new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 35, milliseconds: 593), new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 53, milliseconds: 23), new TimeSpan(days: 0, hours: 17, minutes: 44, seconds: 18, milliseconds: 837), }, { new TimeSpan(days: 0, hours: 2, minutes: 48, seconds: 53, milliseconds: 291), new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 2, milliseconds: 932), new TimeSpan(days: 0, hours: 13, minutes: 56, seconds: 9, milliseconds: 305), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 107,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 23, milliseconds: 129), new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 29, milliseconds: 178), new TimeSpan(days: 0, hours: 18, minutes: 23, seconds: 46, milliseconds: 343), }, { new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 46, milliseconds: 113), new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 3, milliseconds: 466), new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 19, milliseconds: 486), }, { new TimeSpan(days: 0, hours: 7, minutes: 0, seconds: 10, milliseconds: 663), new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 10, milliseconds: 85), new TimeSpan(days: 0, hours: 6, minutes: 57, seconds: 48, milliseconds: 534), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 3, milliseconds: 458), new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 34, milliseconds: 450), new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 28, milliseconds: 73), }, { new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 8, milliseconds: 480), new TimeSpan(days: 0, hours: 6, minutes: 1, seconds: 45, milliseconds: 950), new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 51, milliseconds: 445), }, { new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 0, milliseconds: 395), new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 38, milliseconds: 584), new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 34, milliseconds: 318), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 6, milliseconds: 635), new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 37, milliseconds: 372), new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 23, milliseconds: 972), }, { new TimeSpan(days: 0, hours: 14, minutes: 42, seconds: 42, milliseconds: 936), new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 48, milliseconds: 281), new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 3, milliseconds: 302), }, { new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 30, milliseconds: 446), new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 50, milliseconds: 829), new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 20, milliseconds: 628), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 57,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 27, milliseconds: 902), new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 47, milliseconds: 955), new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 5, milliseconds: 804), }, { new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 4, milliseconds: 674), new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 50, milliseconds: 489), new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 33, milliseconds: 820), }, { new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 37, milliseconds: 117), new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 56, milliseconds: 998), new TimeSpan(days: 0, hours: 7, minutes: 0, seconds: 38, milliseconds: 481), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 46, milliseconds: 301), new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 37, milliseconds: 562), new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 18, milliseconds: 852), }, { new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 7, milliseconds: 578), new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 53, milliseconds: 735), new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 13, milliseconds: 670), }, { new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 21, milliseconds: 984), new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 18, milliseconds: 426), new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 12, milliseconds: 473), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 6, milliseconds: 333), new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 14, milliseconds: 333), new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 13, milliseconds: 780), }, { new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 25, milliseconds: 226), new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 0, milliseconds: 718), new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 33, milliseconds: 387), }, { new TimeSpan(days: 0, hours: 7, minutes: 14, seconds: 40, milliseconds: 870), new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 20, milliseconds: 743), new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 20, milliseconds: 133), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 2, milliseconds: 449), new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 30, milliseconds: 267), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 29, milliseconds: 874), }, { new TimeSpan(days: 0, hours: 17, minutes: 17, seconds: 8, milliseconds: 290), new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 14, milliseconds: 772), new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 19, milliseconds: 19), }, { new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 20, milliseconds: 81), new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 28, milliseconds: 521), new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 38, milliseconds: 181), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 40, milliseconds: 990), new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 41, milliseconds: 662), new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 51, milliseconds: 197), }, { new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 14, milliseconds: 361), new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 14, milliseconds: 554), new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 38, milliseconds: 267), }, { new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 3, milliseconds: 752), new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 12, milliseconds: 265), new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 33, milliseconds: 945), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 56, milliseconds: 50), new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 32, milliseconds: 983), new TimeSpan(days: 0, hours: 3, minutes: 8, seconds: 40, milliseconds: 837), }, { new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 52, milliseconds: 331), new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 50, milliseconds: 318), new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 11, milliseconds: 787), }, { new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 26, milliseconds: 761), new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 34, milliseconds: 628), new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 24, milliseconds: 797), }, }, },
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 111,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 3, milliseconds: 396), new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 32, milliseconds: 993), new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 15, milliseconds: 827), }, { new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 4, milliseconds: 239), new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 18, milliseconds: 981), new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 34, milliseconds: 559), }, { new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 15, milliseconds: 527), new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 41, milliseconds: 12), new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 3, milliseconds: 632), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 13, milliseconds: 877), new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 37, milliseconds: 538), new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 30, milliseconds: 916), }, { new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 3, milliseconds: 709), new TimeSpan(days: 0, hours: 11, minutes: 57, seconds: 46, milliseconds: 217), new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 18, milliseconds: 43), }, { new TimeSpan(days: 0, hours: 16, minutes: 40, seconds: 12, milliseconds: 98), new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 26, milliseconds: 974), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 15, milliseconds: 404), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 49, milliseconds: 386), new TimeSpan(days: 0, hours: 13, minutes: 0, seconds: 20, milliseconds: 167), new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 28, milliseconds: 124), }, { new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 42, milliseconds: 157), new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 23, milliseconds: 579), new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 15, milliseconds: 205), }, { new TimeSpan(days: 0, hours: 20, minutes: 30, seconds: 22, milliseconds: 838), new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 21, milliseconds: 181), new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 50, milliseconds: 325), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 29, milliseconds: 850), new TimeSpan(days: 0, hours: 19, minutes: 7, seconds: 12, milliseconds: 489), new TimeSpan(days: 0, hours: 22, minutes: 2, seconds: 6, milliseconds: 373), }, { new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 53, milliseconds: 561), new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 36, milliseconds: 668), new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 17, milliseconds: 900), }, { new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 54, milliseconds: 147), new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 53, milliseconds: 280), new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 29, milliseconds: 843), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 57, seconds: 51, milliseconds: 161), new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 51, milliseconds: 591), new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 49, milliseconds: 474), }, { new TimeSpan(days: 0, hours: 5, minutes: 49, seconds: 29, milliseconds: 575), new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 21, milliseconds: 542), new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 54, milliseconds: 196), }, { new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 24, milliseconds: 505), new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 36, milliseconds: 202), new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 39, milliseconds: 513), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 41, milliseconds: 791), new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 15, milliseconds: 894), new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 20, milliseconds: 981), }, { new TimeSpan(days: 0, hours: 5, minutes: 40, seconds: 3, milliseconds: 578), new TimeSpan(days: 0, hours: 2, minutes: 12, seconds: 15, milliseconds: 100), new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 32, milliseconds: 901), }, { new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 3, milliseconds: 780), new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 36, milliseconds: 111), new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 37, milliseconds: 675), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 118,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 53, milliseconds: 348), new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 53, milliseconds: 652), new TimeSpan(days: 0, hours: 17, minutes: 41, seconds: 8, milliseconds: 136), }, { new TimeSpan(days: 0, hours: 18, minutes: 52, seconds: 43, milliseconds: 896), new TimeSpan(days: 0, hours: 4, minutes: 2, seconds: 12, milliseconds: 40), new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 45, milliseconds: 234), }, { new TimeSpan(days: 0, hours: 8, minutes: 13, seconds: 29, milliseconds: 781), new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 40, milliseconds: 787), new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 4, milliseconds: 571), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 6, milliseconds: 746), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 10, milliseconds: 345), new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 12, milliseconds: 391), }, { new TimeSpan(days: 0, hours: 21, minutes: 17, seconds: 7, milliseconds: 531), new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 13, milliseconds: 359), new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 28, milliseconds: 471), }, { new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 10, milliseconds: 785), new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 12, milliseconds: 503), new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 58, milliseconds: 902), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 32, milliseconds: 70), new TimeSpan(days: 0, hours: 16, minutes: 43, seconds: 17, milliseconds: 153), new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 5, milliseconds: 902), }, { new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 26, milliseconds: 796), new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 11, milliseconds: 839), new TimeSpan(days: 0, hours: 15, minutes: 10, seconds: 23, milliseconds: 125), }, { new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 16, milliseconds: 766), new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 9, milliseconds: 221), new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 37, milliseconds: 362), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 61,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 20, milliseconds: 784), new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 2, milliseconds: 99), new TimeSpan(days: 0, hours: 14, minutes: 5, seconds: 15, milliseconds: 187), }, { new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 3, milliseconds: 737), new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 24, milliseconds: 392), new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 30, milliseconds: 43), }, { new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 1, milliseconds: 201), new TimeSpan(days: 0, hours: 6, minutes: 7, seconds: 38, milliseconds: 880), new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 47, milliseconds: 20), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 28, milliseconds: 398), new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 34, milliseconds: 922), new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 36, milliseconds: 713), }, { new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 18, milliseconds: 373), new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 7, milliseconds: 139), new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 42, milliseconds: 480), }, { new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 26, milliseconds: 645), new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 45, milliseconds: 9), new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 1, milliseconds: 713), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 32, milliseconds: 843), new TimeSpan(days: 0, hours: 11, minutes: 7, seconds: 28, milliseconds: 68), new TimeSpan(days: 0, hours: 13, minutes: 28, seconds: 52, milliseconds: 581), }, { new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 10, milliseconds: 462), new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 15, milliseconds: 622), new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 56, milliseconds: 48), }, { new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 6, milliseconds: 483), new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 57, milliseconds: 461), new TimeSpan(days: 0, hours: 0, minutes: 15, seconds: 17, milliseconds: 772), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 41, milliseconds: 518), new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 53, milliseconds: 401), new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 39, milliseconds: 290), }, { new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 5, milliseconds: 60), new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 6, milliseconds: 547), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 16, milliseconds: 714), }, { new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 21, milliseconds: 666), new TimeSpan(days: 0, hours: 10, minutes: 58, seconds: 14, milliseconds: 131), new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 2, milliseconds: 812), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 34, milliseconds: 223), new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 8, milliseconds: 163), new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 35, milliseconds: 233), }, { new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 19, milliseconds: 663), new TimeSpan(days: 0, hours: 11, minutes: 22, seconds: 9, milliseconds: 501), new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 38, milliseconds: 557), }, { new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 51, milliseconds: 803), new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 47, milliseconds: 714), new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 1, milliseconds: 826), }, }, { { new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 42, milliseconds: 717), new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 13, milliseconds: 352), new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 18, milliseconds: 734), }, { new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 35, milliseconds: 415), new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 3, milliseconds: 792), new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 58, milliseconds: 31), }, { new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 31, milliseconds: 672), new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 1, milliseconds: 787), new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 25, milliseconds: 471), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 53, milliseconds: 973), new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 16, milliseconds: 622), new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 57, milliseconds: 543), }, { new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 36, milliseconds: 908), new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 10, milliseconds: 763), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 46, milliseconds: 865), }, { new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 34, milliseconds: 713), new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 24, milliseconds: 873), new TimeSpan(days: 0, hours: 6, minutes: 57, seconds: 3, milliseconds: 4), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 22, seconds: 41, milliseconds: 343), new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 39, milliseconds: 800), new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 34, milliseconds: 696), }, { new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 10, milliseconds: 423), new TimeSpan(days: 0, hours: 12, minutes: 26, seconds: 21, milliseconds: 159), new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 41, milliseconds: 64), }, { new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 36, milliseconds: 835), new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 16, milliseconds: 884), new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 49, milliseconds: 721), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 42, milliseconds: 362), new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 14, milliseconds: 699), new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 45, milliseconds: 578), }, { new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 41, milliseconds: 654), new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 41, milliseconds: 790), new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 23, milliseconds: 761), }, { new TimeSpan(days: 0, hours: 18, minutes: 22, seconds: 8, milliseconds: 847), new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 41, milliseconds: 535), new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 33, milliseconds: 56), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 126,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 50, milliseconds: 298), new TimeSpan(days: 0, hours: 8, minutes: 16, seconds: 7, milliseconds: 881), new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 40, milliseconds: 263), }, { new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 27, milliseconds: 604), new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 45, milliseconds: 93), new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 20, milliseconds: 943), }, { new TimeSpan(days: 0, hours: 20, minutes: 14, seconds: 0, milliseconds: 397), new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 57, milliseconds: 85), new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 18, milliseconds: 440), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 13, milliseconds: 89), new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 47, milliseconds: 312), new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 6, milliseconds: 302), }, { new TimeSpan(days: 0, hours: 9, minutes: 39, seconds: 7, milliseconds: 489), new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 5, milliseconds: 738), new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 29, milliseconds: 110), }, { new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 43, milliseconds: 233), new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 47, milliseconds: 199), new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 55, milliseconds: 709), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 49, milliseconds: 382), new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 50, milliseconds: 147), new TimeSpan(days: 0, hours: 9, minutes: 33, seconds: 7, milliseconds: 542), }, { new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 30, milliseconds: 576), new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 52, milliseconds: 341), new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 29, milliseconds: 950), }, { new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 5, milliseconds: 69), new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 16, milliseconds: 962), new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 0, milliseconds: 457), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 14, minutes: 33, seconds: 31, milliseconds: 516), new TimeSpan(days: 0, hours: 22, minutes: 20, seconds: 58, milliseconds: 497), new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 55, milliseconds: 959), }, { new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 8, milliseconds: 126), new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 31, milliseconds: 717), new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 11, milliseconds: 702), }, { new TimeSpan(days: 0, hours: 9, minutes: 54, seconds: 44, milliseconds: 237), new TimeSpan(days: 0, hours: 10, minutes: 13, seconds: 58, milliseconds: 663), new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 28, milliseconds: 432), }, }, { { new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 22, milliseconds: 463), new TimeSpan(days: 0, hours: 20, minutes: 27, seconds: 28, milliseconds: 943), new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 29, milliseconds: 221), }, { new TimeSpan(days: 0, hours: 9, minutes: 34, seconds: 16, milliseconds: 61), new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 18, milliseconds: 88), new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 3, milliseconds: 535), }, { new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 13, milliseconds: 366), new TimeSpan(days: 0, hours: 6, minutes: 7, seconds: 3, milliseconds: 473), new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 12, milliseconds: 204), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 51, seconds: 43, milliseconds: 245), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 42, milliseconds: 432), new TimeSpan(days: 0, hours: 19, minutes: 17, seconds: 0, milliseconds: 403), }, { new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 20, milliseconds: 981), new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 44, milliseconds: 928), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 16, milliseconds: 6), }, { new TimeSpan(days: 0, hours: 17, minutes: 57, seconds: 32, milliseconds: 193), new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 42, milliseconds: 760), new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 9, milliseconds: 567), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 130,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 4, minutes: 51, seconds: 4, milliseconds: 815), new TimeSpan(days: 0, hours: 17, minutes: 49, seconds: 42, milliseconds: 451), new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 48, milliseconds: 515), }, { new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 1, milliseconds: 392), new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 10, milliseconds: 796), new TimeSpan(days: 0, hours: 4, minutes: 46, seconds: 21, milliseconds: 169), }, { new TimeSpan(days: 0, hours: 18, minutes: 31, seconds: 1, milliseconds: 241), new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 56, milliseconds: 7), new TimeSpan(days: 0, hours: 15, minutes: 11, seconds: 23, milliseconds: 979), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 25, milliseconds: 962), new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 30, milliseconds: 97), new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 38, milliseconds: 595), }, { new TimeSpan(days: 0, hours: 7, minutes: 51, seconds: 19, milliseconds: 920), new TimeSpan(days: 0, hours: 15, minutes: 33, seconds: 49, milliseconds: 443), new TimeSpan(days: 0, hours: 10, minutes: 30, seconds: 47, milliseconds: 814), }, { new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 22, milliseconds: 583), new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 57, milliseconds: 246), new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 18, milliseconds: 900), }, }, { { new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 21, milliseconds: 149), new TimeSpan(days: 0, hours: 6, minutes: 36, seconds: 25, milliseconds: 319), new TimeSpan(days: 0, hours: 22, minutes: 0, seconds: 12, milliseconds: 619), }, { new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 15, milliseconds: 773), new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 9, milliseconds: 436), new TimeSpan(days: 0, hours: 6, minutes: 37, seconds: 3, milliseconds: 511), }, { new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 12, milliseconds: 367), new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 3, milliseconds: 605), new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 25, milliseconds: 265), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 64,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 9, minutes: 14, seconds: 7, milliseconds: 795), new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 53, milliseconds: 919), new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 36, milliseconds: 923), }, { new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 27, milliseconds: 406), new TimeSpan(days: 0, hours: 21, minutes: 54, seconds: 2, milliseconds: 926), new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 10, milliseconds: 545), }, { new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 21, milliseconds: 453), new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 25, milliseconds: 82), new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 13, milliseconds: 188), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 30, milliseconds: 335), new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 42, milliseconds: 38), new TimeSpan(days: 0, hours: 21, minutes: 41, seconds: 49, milliseconds: 36), }, { new TimeSpan(days: 0, hours: 7, minutes: 49, seconds: 57, milliseconds: 922), new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 54, milliseconds: 614), new TimeSpan(days: 0, hours: 14, minutes: 34, seconds: 27, milliseconds: 784), }, { new TimeSpan(days: 0, hours: 8, minutes: 30, seconds: 1, milliseconds: 365), new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 2, milliseconds: 881), new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 53, milliseconds: 144), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 30, milliseconds: 480), new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 3, milliseconds: 617), new TimeSpan(days: 0, hours: 8, minutes: 6, seconds: 11, milliseconds: 262), }, { new TimeSpan(days: 0, hours: 15, minutes: 48, seconds: 50, milliseconds: 326), new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 27, milliseconds: 272), new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 7, milliseconds: 506), }, { new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 1, milliseconds: 525), new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 23, milliseconds: 33), new TimeSpan(days: 0, hours: 16, minutes: 56, seconds: 13, milliseconds: 236), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 13, milliseconds: 933), new TimeSpan(days: 0, hours: 1, minutes: 12, seconds: 17, milliseconds: 52), new TimeSpan(days: 0, hours: 2, minutes: 34, seconds: 37, milliseconds: 652), }, { new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 4, milliseconds: 186), new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 13, milliseconds: 201), new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 2, milliseconds: 824), }, { new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 56, milliseconds: 444), new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 6, milliseconds: 489), new TimeSpan(days: 0, hours: 16, minutes: 42, seconds: 10, milliseconds: 951), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 13, milliseconds: 683), new TimeSpan(days: 0, hours: 16, minutes: 57, seconds: 45, milliseconds: 818), new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 27, milliseconds: 966), }, { new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 37, milliseconds: 296), new TimeSpan(days: 0, hours: 9, minutes: 20, seconds: 12, milliseconds: 463), new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 51, milliseconds: 731), }, { new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 27, milliseconds: 208), new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 986), new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 16, milliseconds: 22), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 7, seconds: 41, milliseconds: 181), new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 24, milliseconds: 133), new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 34, milliseconds: 33), }, { new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 9, milliseconds: 115), new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 7, milliseconds: 830), new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 24, milliseconds: 79), }, { new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 10, milliseconds: 95), new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 37, milliseconds: 302), new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 40, milliseconds: 409), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 21, seconds: 53, milliseconds: 694), new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 54, milliseconds: 700), new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 16, milliseconds: 671), }, { new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 1, milliseconds: 562), new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 22, milliseconds: 121), new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 34, milliseconds: 728), }, { new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 0, milliseconds: 839), new TimeSpan(days: 0, hours: 2, minutes: 53, seconds: 28, milliseconds: 171), new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 35, milliseconds: 560), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 10, seconds: 19, milliseconds: 231), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 15, milliseconds: 412), new TimeSpan(days: 0, hours: 3, minutes: 42, seconds: 18, milliseconds: 639), }, { new TimeSpan(days: 0, hours: 17, minutes: 33, seconds: 6, milliseconds: 612), new TimeSpan(days: 0, hours: 14, minutes: 49, seconds: 52, milliseconds: 18), new TimeSpan(days: 0, hours: 6, minutes: 5, seconds: 42, milliseconds: 358), }, { new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 51, milliseconds: 585), new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 35, milliseconds: 702), new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 52, milliseconds: 39), }, }, { { new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 35, milliseconds: 956), new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 34, milliseconds: 381), new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 48, milliseconds: 473), }, { new TimeSpan(days: 0, hours: 7, minutes: 0, seconds: 5, milliseconds: 523), new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 10, milliseconds: 461), new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 51, milliseconds: 248), }, { new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 42, milliseconds: 591), new TimeSpan(days: 0, hours: 2, minutes: 8, seconds: 29, milliseconds: 822), new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 38, milliseconds: 224), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 131,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 34, milliseconds: 971), new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 26, milliseconds: 649), new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 32, milliseconds: 550), }, { new TimeSpan(days: 0, hours: 16, minutes: 45, seconds: 43, milliseconds: 811), new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 29, milliseconds: 951), new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 24, milliseconds: 90), }, { new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 56, milliseconds: 973), new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 17, milliseconds: 296), new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 7, milliseconds: 939), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 53, milliseconds: 190), new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 31, milliseconds: 663), new TimeSpan(days: 0, hours: 19, minutes: 38, seconds: 18, milliseconds: 147), }, { new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 24, milliseconds: 659), new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 21, milliseconds: 164), new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 20, milliseconds: 608), }, { new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 16, milliseconds: 949), new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 35, milliseconds: 203), new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 53, milliseconds: 512), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 0, milliseconds: 94), new TimeSpan(days: 0, hours: 2, minutes: 22, seconds: 41, milliseconds: 353), new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 18, milliseconds: 162), }, { new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 48, milliseconds: 375), new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 37, milliseconds: 465), new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 21, milliseconds: 119), }, { new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 53, milliseconds: 367), new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 4, milliseconds: 305), new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 47, milliseconds: 69), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 140,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 1, milliseconds: 156), new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 16, milliseconds: 783), new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 34, milliseconds: 15), }, { new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 35, milliseconds: 860), new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 55, milliseconds: 869), new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 17, milliseconds: 153), }, { new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 13, milliseconds: 314), new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 57, milliseconds: 998), new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 18, milliseconds: 863), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 23, milliseconds: 434), new TimeSpan(days: 0, hours: 0, minutes: 4, seconds: 14, milliseconds: 413), new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 31, milliseconds: 516), }, { new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 19, milliseconds: 905), new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 23, milliseconds: 686), new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 32, milliseconds: 671), }, { new TimeSpan(days: 0, hours: 5, minutes: 10, seconds: 25, milliseconds: 432), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 34, milliseconds: 569), new TimeSpan(days: 0, hours: 21, minutes: 43, seconds: 21, milliseconds: 980), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 46, milliseconds: 902), new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 0, milliseconds: 455), new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 14, milliseconds: 982), }, { new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 25, milliseconds: 147), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 24, milliseconds: 187), new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 13, milliseconds: 858), }, { new TimeSpan(days: 0, hours: 21, minutes: 50, seconds: 56, milliseconds: 992), new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 33, milliseconds: 975), new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 23, milliseconds: 684), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 73,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 41, seconds: 8, milliseconds: 643), new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 21, milliseconds: 650), new TimeSpan(days: 0, hours: 9, minutes: 22, seconds: 49, milliseconds: 998), }, { new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 26, milliseconds: 671), new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 12, milliseconds: 591), new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 33, milliseconds: 181), }, { new TimeSpan(days: 0, hours: 12, minutes: 25, seconds: 2, milliseconds: 631), new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 7, milliseconds: 772), new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 56, milliseconds: 311), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 4, seconds: 41, milliseconds: 329), new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 44, milliseconds: 590), new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 36, milliseconds: 290), }, { new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 31, milliseconds: 556), new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 56, milliseconds: 148), new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 26, milliseconds: 681), }, { new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 5, milliseconds: 132), new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 54, milliseconds: 385), new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 21, milliseconds: 189), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 47, milliseconds: 952), new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 9, milliseconds: 303), new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 52, milliseconds: 93), }, { new TimeSpan(days: 0, hours: 16, minutes: 39, seconds: 29, milliseconds: 63), new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 34, milliseconds: 255), new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 4, milliseconds: 760), }, { new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 49, milliseconds: 838), new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 37, milliseconds: 516), new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 6, milliseconds: 691), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 22, milliseconds: 263), new TimeSpan(days: 0, hours: 22, minutes: 50, seconds: 38, milliseconds: 680), new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 55, milliseconds: 77), }, { new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 20, milliseconds: 796), new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 2, milliseconds: 943), new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 1, milliseconds: 813), }, { new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 23, milliseconds: 133), new TimeSpan(days: 0, hours: 9, minutes: 28, seconds: 46, milliseconds: 534), new TimeSpan(days: 0, hours: 5, minutes: 29, seconds: 29, milliseconds: 758), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 2, milliseconds: 46), new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 6, milliseconds: 898), new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 31, milliseconds: 863), }, { new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 7, milliseconds: 691), new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 51, milliseconds: 522), new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 28, milliseconds: 516), }, { new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 3, milliseconds: 566), new TimeSpan(days: 0, hours: 15, minutes: 14, seconds: 53, milliseconds: 909), new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 5, milliseconds: 68), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 42, milliseconds: 468), new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 28, milliseconds: 549), new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 21, milliseconds: 773), }, { new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 16, milliseconds: 217), new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 9, milliseconds: 930), new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 25, milliseconds: 775), }, { new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 24, milliseconds: 405), new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 57, milliseconds: 131), new TimeSpan(days: 0, hours: 9, minutes: 58, seconds: 35, milliseconds: 452), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 23, milliseconds: 290), new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 34, milliseconds: 316), new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 10, milliseconds: 403), }, { new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 23, milliseconds: 662), new TimeSpan(days: 0, hours: 21, minutes: 38, seconds: 30, milliseconds: 767), new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 48, milliseconds: 537), }, { new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 4, milliseconds: 639), new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 13, milliseconds: 474), new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 9, milliseconds: 981), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 27, milliseconds: 894), new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 42, milliseconds: 63), new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 18, milliseconds: 51), }, { new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 54, milliseconds: 672), new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 12, milliseconds: 852), new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 6, milliseconds: 173), }, { new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 1, milliseconds: 365), new TimeSpan(days: 0, hours: 19, minutes: 49, seconds: 15, milliseconds: 254), new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 30, milliseconds: 314), }, }, { { new TimeSpan(days: 0, hours: 13, minutes: 17, seconds: 52, milliseconds: 358), new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 43, milliseconds: 926), new TimeSpan(days: 0, hours: 19, minutes: 48, seconds: 5, milliseconds: 205), }, { new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 57, milliseconds: 11), new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 56, milliseconds: 859), new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 16, milliseconds: 605), }, { new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 47, milliseconds: 542), new TimeSpan(days: 0, hours: 9, minutes: 7, seconds: 43, milliseconds: 729), new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 10, milliseconds: 875), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 147,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 22, milliseconds: 169), new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 15, milliseconds: 440), new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 17, milliseconds: 691), }, { new TimeSpan(days: 0, hours: 22, minutes: 25, seconds: 31, milliseconds: 258), new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 52, milliseconds: 380), new TimeSpan(days: 0, hours: 2, minutes: 40, seconds: 28, milliseconds: 14), }, { new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 37, milliseconds: 646), new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 15, milliseconds: 246), new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 21, milliseconds: 684), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 51, milliseconds: 161), new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 52, milliseconds: 156), new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 42, milliseconds: 789), }, { new TimeSpan(days: 0, hours: 13, minutes: 40, seconds: 38, milliseconds: 644), new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 24, milliseconds: 149), new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 27, milliseconds: 998), }, { new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 56, milliseconds: 630), new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 5, milliseconds: 556), new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 51, milliseconds: 314), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 20, milliseconds: 687), new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 19, milliseconds: 919), new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 27, milliseconds: 196), }, { new TimeSpan(days: 0, hours: 16, minutes: 13, seconds: 40, milliseconds: 914), new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 57, milliseconds: 858), new TimeSpan(days: 0, hours: 19, minutes: 58, seconds: 19, milliseconds: 535), }, { new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 12, milliseconds: 608), new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 3, milliseconds: 7), new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 2, milliseconds: 973), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 27, milliseconds: 809), new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 32, milliseconds: 808), new TimeSpan(days: 0, hours: 11, minutes: 45, seconds: 30, milliseconds: 60), }, { new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 4, milliseconds: 594), new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 56, milliseconds: 207), new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 19, milliseconds: 575), }, { new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 56, milliseconds: 877), new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 42, milliseconds: 966), new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 43, milliseconds: 208), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 35, seconds: 8, milliseconds: 32), new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 54, milliseconds: 111), new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 20, milliseconds: 761), }, { new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 23, milliseconds: 654), new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 27, milliseconds: 136), new TimeSpan(days: 0, hours: 10, minutes: 12, seconds: 27, milliseconds: 293), }, { new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 46, milliseconds: 620), new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 7, milliseconds: 215), new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 4, milliseconds: 568), }, }, { { new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 0, milliseconds: 962), new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 23, milliseconds: 844), new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 39, milliseconds: 811), }, { new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 43, milliseconds: 749), new TimeSpan(days: 0, hours: 19, minutes: 45, seconds: 23, milliseconds: 980), new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 33, milliseconds: 16), }, { new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 47, milliseconds: 945), new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 49, milliseconds: 606), new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 49, milliseconds: 384), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 150,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 40, milliseconds: 170), new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 57, milliseconds: 931), new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 25, milliseconds: 581), }, { new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 10, milliseconds: 830), new TimeSpan(days: 0, hours: 2, minutes: 56, seconds: 0, milliseconds: 764), new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 35, milliseconds: 475), }, { new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 15, milliseconds: 348), new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 20, milliseconds: 160), new TimeSpan(days: 0, hours: 12, minutes: 51, seconds: 15, milliseconds: 102), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 23, milliseconds: 866), new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 29, milliseconds: 423), new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 36, milliseconds: 767), }, { new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 54, milliseconds: 110), new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 22, milliseconds: 576), new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 58, milliseconds: 743), }, { new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 53, milliseconds: 63), new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 34, milliseconds: 896), new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 39, milliseconds: 424), }, }, { { new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 16, milliseconds: 638), new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 2, milliseconds: 491), new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 53, milliseconds: 223), }, { new TimeSpan(days: 0, hours: 16, minutes: 41, seconds: 4, milliseconds: 778), new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 51, milliseconds: 218), new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 47, milliseconds: 174), }, { new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 37, milliseconds: 998), new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 53, milliseconds: 13), new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 33, milliseconds: 801), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 80,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 40, milliseconds: 743), new TimeSpan(days: 0, hours: 17, minutes: 4, seconds: 18, milliseconds: 679), new TimeSpan(days: 0, hours: 8, minutes: 44, seconds: 46, milliseconds: 454), }, { new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 40, milliseconds: 939), new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 17, milliseconds: 682), new TimeSpan(days: 0, hours: 8, minutes: 18, seconds: 50, milliseconds: 619), }, { new TimeSpan(days: 0, hours: 4, minutes: 19, seconds: 47, milliseconds: 594), new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 14, milliseconds: 437), new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 6, milliseconds: 591), }, }, { { new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 27, milliseconds: 651), new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 12, milliseconds: 708), new TimeSpan(days: 0, hours: 21, minutes: 30, seconds: 52, milliseconds: 195), }, { new TimeSpan(days: 0, hours: 3, minutes: 34, seconds: 57, milliseconds: 95), new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 32, milliseconds: 681), new TimeSpan(days: 0, hours: 14, minutes: 38, seconds: 14, milliseconds: 783), }, { new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 18, milliseconds: 743), new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 24, milliseconds: 210), new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 17, milliseconds: 253), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 2, milliseconds: 302), new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 8, milliseconds: 704), new TimeSpan(days: 0, hours: 15, minutes: 39, seconds: 50, milliseconds: 996), }, { new TimeSpan(days: 0, hours: 13, minutes: 56, seconds: 3, milliseconds: 664), new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 12, milliseconds: 364), new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 39, milliseconds: 741), }, { new TimeSpan(days: 0, hours: 12, minutes: 32, seconds: 39, milliseconds: 228), new TimeSpan(days: 0, hours: 11, minutes: 19, seconds: 13, milliseconds: 206), new TimeSpan(days: 0, hours: 16, minutes: 5, seconds: 33, milliseconds: 603), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 155,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 41, milliseconds: 212), new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 37, milliseconds: 784), new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 14, milliseconds: 564), }, { new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 13, milliseconds: 755), new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 7, milliseconds: 449), new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 58, milliseconds: 1), }, { new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 58, milliseconds: 203), new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 44, milliseconds: 868), new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 52, milliseconds: 609), }, }, { { new TimeSpan(days: 0, hours: 0, minutes: 20, seconds: 52, milliseconds: 242), new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 29, milliseconds: 514), new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 18, milliseconds: 981), }, { new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 58, milliseconds: 978), new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 11, milliseconds: 437), new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 28, milliseconds: 802), }, { new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 38, milliseconds: 713), new TimeSpan(days: 0, hours: 10, minutes: 46, seconds: 19, milliseconds: 505), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 15, milliseconds: 733), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 57, milliseconds: 121), new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 13, milliseconds: 617), new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 49, milliseconds: 371), }, { new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 47, milliseconds: 348), new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 1, milliseconds: 292), new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 33, milliseconds: 491), }, { new TimeSpan(days: 0, hours: 18, minutes: 18, seconds: 52, milliseconds: 170), new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 48, milliseconds: 722), new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 20, milliseconds: 397), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 12, minutes: 43, seconds: 44, milliseconds: 823), new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 43, milliseconds: 373), new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 12, milliseconds: 351), }, { new TimeSpan(days: 0, hours: 2, minutes: 51, seconds: 51, milliseconds: 919), new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 49, milliseconds: 242), new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 18, milliseconds: 616), }, { new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 14, milliseconds: 689), new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 46, milliseconds: 92), new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 14, milliseconds: 941), }, }, { { new TimeSpan(days: 0, hours: 13, minutes: 54, seconds: 58, milliseconds: 963), new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 54, milliseconds: 882), new TimeSpan(days: 0, hours: 3, minutes: 43, seconds: 33, milliseconds: 173), }, { new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 19, milliseconds: 319), new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 19, milliseconds: 814), new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 58, milliseconds: 280), }, { new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 33, milliseconds: 198), new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 33, milliseconds: 142), new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 6, milliseconds: 979), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 14, seconds: 19, milliseconds: 257), new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 21, milliseconds: 20), new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 51, milliseconds: 998), }, { new TimeSpan(days: 0, hours: 4, minutes: 17, seconds: 6, milliseconds: 401), new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 31, milliseconds: 523), new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 45, milliseconds: 103), }, { new TimeSpan(days: 0, hours: 10, minutes: 19, seconds: 4, milliseconds: 474), new TimeSpan(days: 0, hours: 12, minutes: 41, seconds: 13, milliseconds: 688), new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 33, milliseconds: 232), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 159,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 31, seconds: 12, milliseconds: 839), new TimeSpan(days: 0, hours: 10, minutes: 40, seconds: 44, milliseconds: 175), new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 12, milliseconds: 344), }, { new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 34, milliseconds: 977), new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 25, milliseconds: 451), new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 44, milliseconds: 396), }, { new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 31, milliseconds: 656), new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 47, milliseconds: 948), new TimeSpan(days: 0, hours: 9, minutes: 36, seconds: 53, milliseconds: 850), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 37, milliseconds: 14), new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 39, milliseconds: 545), new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 54, milliseconds: 16), }, { new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 24, milliseconds: 129), new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 30, milliseconds: 790), new TimeSpan(days: 0, hours: 6, minutes: 28, seconds: 36, milliseconds: 975), }, { new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 16, milliseconds: 259), new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 20, milliseconds: 712), new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 33, milliseconds: 264), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 25, milliseconds: 9), new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 2, milliseconds: 27), new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 17, milliseconds: 521), }, { new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 10, milliseconds: 913), new TimeSpan(days: 0, hours: 8, minutes: 39, seconds: 58, milliseconds: 971), new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 32, milliseconds: 244), }, { new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 3, milliseconds: 220), new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 9, milliseconds: 894), new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 29, milliseconds: 659), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 85,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 50, seconds: 20, milliseconds: 288), new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 11, milliseconds: 992), new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 4, milliseconds: 484), }, { new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 11, milliseconds: 587), new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 29, milliseconds: 341), new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 16, milliseconds: 370), }, { new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 3, milliseconds: 247), new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 57, milliseconds: 343), new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 34, milliseconds: 387), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 6, seconds: 51, milliseconds: 41), new TimeSpan(days: 0, hours: 19, minutes: 50, seconds: 44, milliseconds: 874), new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 54, milliseconds: 843), }, { new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 30, milliseconds: 101), new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 0, milliseconds: 974), new TimeSpan(days: 0, hours: 17, minutes: 49, seconds: 42, milliseconds: 987), }, { new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 5, milliseconds: 366), new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 0, milliseconds: 847), new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 10, milliseconds: 498), }, }, { { new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 29, milliseconds: 326), new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 11, milliseconds: 296), new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 22, milliseconds: 114), }, { new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 27, milliseconds: 706), new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 1, milliseconds: 956), new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 55, milliseconds: 138), }, { new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 54, milliseconds: 677), new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 42, milliseconds: 536), new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 36, milliseconds: 668), }, }, },
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 41, milliseconds: 906), new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 33, milliseconds: 675), new TimeSpan(days: 0, hours: 5, minutes: 58, seconds: 37, milliseconds: 792), }, { new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 32, milliseconds: 560), new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 49, milliseconds: 437), new TimeSpan(days: 0, hours: 1, minutes: 23, seconds: 55, milliseconds: 18), }, { new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 3, milliseconds: 170), new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 57, milliseconds: 167), new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 29, milliseconds: 516), }, }, { { new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 45, milliseconds: 604), new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 27, milliseconds: 677), new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 9, milliseconds: 661), }, { new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 11, milliseconds: 538), new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 16, milliseconds: 947), new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 18, milliseconds: 817), }, { new TimeSpan(days: 0, hours: 2, minutes: 15, seconds: 35, milliseconds: 698), new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 49, milliseconds: 325), new TimeSpan(days: 0, hours: 8, minutes: 29, seconds: 25, milliseconds: 290), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 33, milliseconds: 241), new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 46, milliseconds: 676), new TimeSpan(days: 0, hours: 12, minutes: 40, seconds: 43, milliseconds: 500), }, { new TimeSpan(days: 0, hours: 20, minutes: 22, seconds: 22, milliseconds: 526), new TimeSpan(days: 0, hours: 0, minutes: 48, seconds: 49, milliseconds: 796), new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 7, milliseconds: 966), }, { new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 53, milliseconds: 502), new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 3, milliseconds: 891), new TimeSpan(days: 0, hours: 18, minutes: 22, seconds: 12, milliseconds: 901), }, }, },
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 56, milliseconds: 284), new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 37, milliseconds: 188), new TimeSpan(days: 0, hours: 0, minutes: 7, seconds: 18, milliseconds: 155), }, { new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 55, milliseconds: 137), new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 48, milliseconds: 125), new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 58, milliseconds: 145), }, { new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 3, milliseconds: 850), new TimeSpan(days: 0, hours: 14, minutes: 24, seconds: 4, milliseconds: 601), new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 58, milliseconds: 149), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 26, seconds: 16, milliseconds: 274), new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 52, milliseconds: 277), new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 53, milliseconds: 676), }, { new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 55, milliseconds: 611), new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 37, milliseconds: 689), new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 38, milliseconds: 7), }, { new TimeSpan(days: 0, hours: 13, minutes: 21, seconds: 49, milliseconds: 564), new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 57, milliseconds: 268), new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 26, milliseconds: 57), }, }, { { new TimeSpan(days: 0, hours: 5, minutes: 45, seconds: 5, milliseconds: 754), new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 40, milliseconds: 171), new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 42, milliseconds: 960), }, { new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 33, milliseconds: 732), new TimeSpan(days: 0, hours: 15, minutes: 8, seconds: 23, milliseconds: 658), new TimeSpan(days: 0, hours: 19, minutes: 55, seconds: 8, milliseconds: 124), }, { new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 22, milliseconds: 728), new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 27, milliseconds: 282), new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 32, milliseconds: 529), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 168,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 13, minutes: 53, seconds: 10, milliseconds: 45), new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 30, milliseconds: 788), new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 33, milliseconds: 773), }, { new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 2, milliseconds: 572), new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 6, milliseconds: 990), new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 51, milliseconds: 12), }, { new TimeSpan(days: 0, hours: 7, minutes: 50, seconds: 14, milliseconds: 372), new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 45, milliseconds: 568), new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 25, milliseconds: 55), }, }, { { new TimeSpan(days: 0, hours: 10, minutes: 17, seconds: 56, milliseconds: 463), new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 8, milliseconds: 305), new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 5, milliseconds: 875), }, { new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 29, milliseconds: 750), new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 13, milliseconds: 884), new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 36, milliseconds: 278), }, { new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 31, milliseconds: 322), new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 31, milliseconds: 497), new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 45, milliseconds: 314), }, }, { { new TimeSpan(days: 0, hours: 1, minutes: 28, seconds: 9, milliseconds: 417), new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 25, milliseconds: 444), new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 4, milliseconds: 199), }, { new TimeSpan(days: 0, hours: 21, minutes: 5, seconds: 11, milliseconds: 223), new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 14, milliseconds: 15), new TimeSpan(days: 0, hours: 11, minutes: 2, seconds: 22, milliseconds: 862), }, { new TimeSpan(days: 0, hours: 9, minutes: 5, seconds: 20, milliseconds: 53), new TimeSpan(days: 0, hours: 2, minutes: 15, seconds: 33, milliseconds: 905), new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 14, milliseconds: 383), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 17, milliseconds: 79), new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 3, milliseconds: 688), new TimeSpan(days: 0, hours: 14, minutes: 24, seconds: 54, milliseconds: 816), }, { new TimeSpan(days: 0, hours: 6, minutes: 53, seconds: 53, milliseconds: 89), new TimeSpan(days: 0, hours: 21, minutes: 44, seconds: 25, milliseconds: 45), new TimeSpan(days: 0, hours: 4, minutes: 4, seconds: 31, milliseconds: 251), }, { new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 15, milliseconds: 394), new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 32, milliseconds: 42), new TimeSpan(days: 0, hours: 7, minutes: 6, seconds: 23, milliseconds: 964), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 40, seconds: 45, milliseconds: 280), new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 55, milliseconds: 379), new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 50, milliseconds: 901), }, { new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 9, milliseconds: 701), new TimeSpan(days: 0, hours: 8, minutes: 4, seconds: 16, milliseconds: 129), new TimeSpan(days: 0, hours: 10, minutes: 1, seconds: 49, milliseconds: 40), }, { new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 56, milliseconds: 787), new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 10, milliseconds: 960), new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 38, milliseconds: 737), }, }, { { new TimeSpan(days: 0, hours: 4, minutes: 36, seconds: 9, milliseconds: 869), new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 23, milliseconds: 795), new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 35, milliseconds: 927), }, { new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 10, milliseconds: 638), new TimeSpan(days: 0, hours: 6, minutes: 31, seconds: 20, milliseconds: 408), new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 21, milliseconds: 228), }, { new TimeSpan(days: 0, hours: 5, minutes: 1, seconds: 19, milliseconds: 258), new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 38, milliseconds: 790), new TimeSpan(days: 0, hours: 15, minutes: 20, seconds: 41, milliseconds: 739), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 172,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 44, milliseconds: 326), new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 1, milliseconds: 75), new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 17, milliseconds: 867), }, { new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 17, milliseconds: 215), new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 6, milliseconds: 101), new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 46, milliseconds: 147), }, { new TimeSpan(days: 0, hours: 12, minutes: 16, seconds: 20, milliseconds: 709), new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 47, milliseconds: 429), new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 56, milliseconds: 102), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 12, seconds: 31, milliseconds: 629), new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 47, milliseconds: 984), new TimeSpan(days: 0, hours: 19, minutes: 18, seconds: 15, milliseconds: 885), }, { new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 14, milliseconds: 417), new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 40, milliseconds: 265), new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 0, milliseconds: 197), }, { new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 14, milliseconds: 273), new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 58, milliseconds: 989), new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 17, milliseconds: 945), }, }, { { new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 9, milliseconds: 956), new TimeSpan(days: 0, hours: 9, minutes: 9, seconds: 42, milliseconds: 944), new TimeSpan(days: 0, hours: 11, minutes: 19, seconds: 9, milliseconds: 117), }, { new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 37, milliseconds: 154), new TimeSpan(days: 0, hours: 2, minutes: 22, seconds: 27, milliseconds: 768), new TimeSpan(days: 0, hours: 7, minutes: 44, seconds: 50, milliseconds: 567), }, { new TimeSpan(days: 0, hours: 19, minutes: 57, seconds: 15, milliseconds: 407), new TimeSpan(days: 0, hours: 3, minutes: 32, seconds: 17, milliseconds: 735), new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 55, milliseconds: 784), }, }, },
    ModelInner = new TimeSpanintervalMMArrayD3E1MI
{
    Id = 87,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 0, minutes: 22, seconds: 23, milliseconds: 339), new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 44, milliseconds: 458), new TimeSpan(days: 0, hours: 3, minutes: 39, seconds: 36, milliseconds: 208), }, { new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 5, milliseconds: 682), new TimeSpan(days: 0, hours: 15, minutes: 44, seconds: 20, milliseconds: 864), new TimeSpan(days: 0, hours: 16, minutes: 44, seconds: 57, milliseconds: 266), }, { new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 39, milliseconds: 44), new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 30, milliseconds: 679), new TimeSpan(days: 0, hours: 14, minutes: 11, seconds: 2, milliseconds: 921), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 12, seconds: 41, milliseconds: 384), new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 28, milliseconds: 588), new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 4, milliseconds: 362), }, { new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 39, milliseconds: 707), new TimeSpan(days: 0, hours: 7, minutes: 24, seconds: 57, milliseconds: 791), new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 27, milliseconds: 295), }, { new TimeSpan(days: 0, hours: 21, minutes: 17, seconds: 25, milliseconds: 972), new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 38, milliseconds: 991), new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 16, milliseconds: 729), }, }, { { new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 50, milliseconds: 296), new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 1, milliseconds: 495), new TimeSpan(days: 0, hours: 2, minutes: 19, seconds: 5, milliseconds: 99), }, { new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 35, milliseconds: 309), new TimeSpan(days: 0, hours: 15, minutes: 12, seconds: 5, milliseconds: 692), new TimeSpan(days: 0, hours: 10, minutes: 41, seconds: 27, milliseconds: 371), }, { new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 40, milliseconds: 232), new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 28, milliseconds: 251), new TimeSpan(days: 0, hours: 10, minutes: 35, seconds: 30, milliseconds: 113), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 2, milliseconds: 506), new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 37, milliseconds: 732), new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 44, milliseconds: 990), }, { new TimeSpan(days: 0, hours: 1, minutes: 56, seconds: 38, milliseconds: 696), new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 39, milliseconds: 844), new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 27, milliseconds: 971), }, { new TimeSpan(days: 0, hours: 13, minutes: 8, seconds: 20, milliseconds: 493), new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 9, milliseconds: 576), new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 38, milliseconds: 960), }, }, { { new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 45, milliseconds: 834), new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 33, milliseconds: 397), new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 36, milliseconds: 779), }, { new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 23, milliseconds: 611), new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 40, milliseconds: 639), new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 4, milliseconds: 12), }, { new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 29, milliseconds: 835), new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 8, milliseconds: 789), new TimeSpan(days: 0, hours: 10, minutes: 43, seconds: 29, milliseconds: 57), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 32, milliseconds: 377), new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 28, milliseconds: 822), new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 21, milliseconds: 504), }, { new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 53, milliseconds: 131), new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 33, milliseconds: 839), new TimeSpan(days: 0, hours: 12, minutes: 9, seconds: 36, milliseconds: 657), }, { new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 44, milliseconds: 804), new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 45, milliseconds: 884), new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 7, milliseconds: 123), }, }, },
},
            new TimeSpanintervalMMArrayD3E1M
{
    Id = 180,
    Value = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 12, minutes: 2, seconds: 40, milliseconds: 84), new TimeSpan(days: 0, hours: 16, minutes: 33, seconds: 43, milliseconds: 22), new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 14, milliseconds: 984), }, { new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 10, milliseconds: 115), new TimeSpan(days: 0, hours: 7, minutes: 27, seconds: 10, milliseconds: 449), new TimeSpan(days: 0, hours: 20, minutes: 26, seconds: 18, milliseconds: 483), }, { new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 23, milliseconds: 270), new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 21, milliseconds: 324), new TimeSpan(days: 0, hours: 18, minutes: 2, seconds: 2, milliseconds: 284), }, }, { { new TimeSpan(days: 0, hours: 15, minutes: 56, seconds: 54, milliseconds: 134), new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 35, milliseconds: 835), new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 32, milliseconds: 445), }, { new TimeSpan(days: 0, hours: 21, minutes: 51, seconds: 10, milliseconds: 771), new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 46, milliseconds: 425), new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 17, milliseconds: 845), }, { new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 22, milliseconds: 379), new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 58, milliseconds: 925), new TimeSpan(days: 0, hours: 9, minutes: 48, seconds: 13, milliseconds: 564), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 8, milliseconds: 511), new TimeSpan(days: 0, hours: 10, minutes: 7, seconds: 41, milliseconds: 666), new TimeSpan(days: 0, hours: 8, minutes: 31, seconds: 4, milliseconds: 986), }, { new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 34, milliseconds: 661), new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 55, milliseconds: 392), new TimeSpan(days: 0, hours: 8, minutes: 35, seconds: 38, milliseconds: 629), }, { new TimeSpan(days: 0, hours: 20, minutes: 16, seconds: 56, milliseconds: 497), new TimeSpan(days: 0, hours: 3, minutes: 2, seconds: 42, milliseconds: 688), new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 49, milliseconds: 486), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 6, minutes: 38, seconds: 56, milliseconds: 939), new TimeSpan(days: 0, hours: 4, minutes: 33, seconds: 30, milliseconds: 282), new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 25, milliseconds: 990), }, { new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 1, milliseconds: 9), new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 52, milliseconds: 499), new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 54, milliseconds: 175), }, { new TimeSpan(days: 0, hours: 1, minutes: 32, seconds: 26, milliseconds: 496), new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 15, milliseconds: 353), new TimeSpan(days: 0, hours: 16, minutes: 12, seconds: 12, milliseconds: 173), }, }, { { new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 32, milliseconds: 244), new TimeSpan(days: 0, hours: 20, minutes: 38, seconds: 16, milliseconds: 390), new TimeSpan(days: 0, hours: 18, minutes: 54, seconds: 29, milliseconds: 924), }, { new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 21, milliseconds: 801), new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 17, milliseconds: 425), new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 40, milliseconds: 347), }, { new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 33, milliseconds: 905), new TimeSpan(days: 0, hours: 5, minutes: 50, seconds: 33, milliseconds: 374), new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 28, milliseconds: 129), }, }, { { new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 30, milliseconds: 51), new TimeSpan(days: 0, hours: 7, minutes: 12, seconds: 41, milliseconds: 906), new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 26, milliseconds: 860), }, { new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 32, milliseconds: 582), new TimeSpan(days: 0, hours: 7, minutes: 29, seconds: 14, milliseconds: 50), new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 16, milliseconds: 685), }, { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 9, milliseconds: 703), new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 40, milliseconds: 565), new TimeSpan(days: 0, hours: 3, minutes: 7, seconds: 54, milliseconds: 758), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd3e1mi(
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd3e1mi(
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
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]), 
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

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd3e1mi_id
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd3e1mi_id", 
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
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd3e1mi_id
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
    timespanintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                System.TimeSpan[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,,]>();
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,,]>();
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 23, milliseconds: 842), new TimeSpan(days: 0, hours: 20, minutes: 57, seconds: 44, milliseconds: 195), new TimeSpan(days: 0, hours: 20, minutes: 42, seconds: 40, milliseconds: 970), }, { new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 11, milliseconds: 325), new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 14, milliseconds: 226), new TimeSpan(days: 0, hours: 20, minutes: 58, seconds: 16, milliseconds: 941), }, { new TimeSpan(days: 0, hours: 18, minutes: 17, seconds: 19, milliseconds: 33), new TimeSpan(days: 0, hours: 19, minutes: 54, seconds: 37, milliseconds: 119), new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 1, milliseconds: 211), }, }, { { new TimeSpan(days: 0, hours: 0, minutes: 31, seconds: 41, milliseconds: 551), new TimeSpan(days: 0, hours: 0, minutes: 23, seconds: 31, milliseconds: 745), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 17, milliseconds: 715), }, { new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 47, milliseconds: 612), new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 19, milliseconds: 891), new TimeSpan(days: 0, hours: 20, minutes: 34, seconds: 43, milliseconds: 460), }, { new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 55, milliseconds: 36), new TimeSpan(days: 0, hours: 3, minutes: 49, seconds: 56, milliseconds: 824), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 53, milliseconds: 291), }, }, { { new TimeSpan(days: 0, hours: 18, minutes: 29, seconds: 43, milliseconds: 42), new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 40, milliseconds: 605), new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 30, milliseconds: 767), }, { new TimeSpan(days: 0, hours: 1, minutes: 40, seconds: 6, milliseconds: 937), new TimeSpan(days: 0, hours: 17, minutes: 51, seconds: 3, milliseconds: 744), new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 40, milliseconds: 354), }, { new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 30, milliseconds: 744), new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 28, milliseconds: 325), new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 36, milliseconds: 799), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,,]>();
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[,,]>();
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 53, milliseconds: 686), new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 42, milliseconds: 414), new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 2, milliseconds: 208), }, { new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 16, milliseconds: 522), new TimeSpan(days: 0, hours: 5, minutes: 0, seconds: 58, milliseconds: 117), new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 7, milliseconds: 51), }, { new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 30, milliseconds: 280), new TimeSpan(days: 0, hours: 14, minutes: 0, seconds: 50, milliseconds: 175), new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 22, milliseconds: 469), }, }, { { new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 26, milliseconds: 862), new TimeSpan(days: 0, hours: 17, minutes: 18, seconds: 14, milliseconds: 435), new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 37, milliseconds: 799), }, { new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 49, milliseconds: 711), new TimeSpan(days: 0, hours: 17, minutes: 13, seconds: 48, milliseconds: 580), new TimeSpan(days: 0, hours: 10, minutes: 10, seconds: 9, milliseconds: 186), }, { new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 4, milliseconds: 418), new TimeSpan(days: 0, hours: 17, minutes: 26, seconds: 4, milliseconds: 306), new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 38, milliseconds: 645), }, }, { { new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 13, milliseconds: 181), new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 18, milliseconds: 818), new TimeSpan(days: 0, hours: 4, minutes: 18, seconds: 9, milliseconds: 711), }, { new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 6, milliseconds: 145), new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 12, milliseconds: 186), new TimeSpan(days: 0, hours: 21, minutes: 46, seconds: 0, milliseconds: 981), }, { new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 19, milliseconds: 334), new TimeSpan(days: 0, hours: 3, minutes: 22, seconds: 48, milliseconds: 329), new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 1, milliseconds: 163), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd3e1mi_id
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
    timespanintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd3e1mi_id", 
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
                System.TimeSpan[,,] nullable = null;
                nullable =  ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 50, milliseconds: 679), new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 54, milliseconds: 252), new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 6, milliseconds: 454), }, { new TimeSpan(days: 0, hours: 14, minutes: 36, seconds: 40, milliseconds: 13), new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 34, milliseconds: 548), new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 16, milliseconds: 16), }, { new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 6, milliseconds: 653), new TimeSpan(days: 0, hours: 5, minutes: 31, seconds: 17, milliseconds: 506), new TimeSpan(days: 0, hours: 0, minutes: 42, seconds: 49, milliseconds: 466), }, }, { { new TimeSpan(days: 0, hours: 12, minutes: 49, seconds: 17, milliseconds: 782), new TimeSpan(days: 0, hours: 18, minutes: 32, seconds: 24, milliseconds: 395), new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 57, milliseconds: 963), }, { new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 26, milliseconds: 831), new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 56, milliseconds: 808), new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 43, milliseconds: 359), }, { new TimeSpan(days: 0, hours: 4, minutes: 9, seconds: 13, milliseconds: 944), new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 37, milliseconds: 772), new TimeSpan(days: 0, hours: 4, minutes: 15, seconds: 17, milliseconds: 529), }, }, { { new TimeSpan(days: 0, hours: 9, minutes: 35, seconds: 20, milliseconds: 373), new TimeSpan(days: 0, hours: 9, minutes: 8, seconds: 16, milliseconds: 17), new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 17, milliseconds: 643), }, { new TimeSpan(days: 0, hours: 7, minutes: 18, seconds: 35, milliseconds: 892), new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 53, milliseconds: 987), new TimeSpan(days: 0, hours: 8, minutes: 53, seconds: 22, milliseconds: 879), }, { new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 31, milliseconds: 199), new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 43, milliseconds: 482), new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 22, milliseconds: 171), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[,,] nullable = null;
                nullable = await ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanMArrayintervalMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[,,] { { { new TimeSpan(days: 0, hours: 9, minutes: 37, seconds: 15, milliseconds: 336), new TimeSpan(days: 0, hours: 5, minutes: 17, seconds: 28, milliseconds: 286), new TimeSpan(days: 0, hours: 15, minutes: 54, seconds: 24, milliseconds: 780), }, { new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 4, milliseconds: 283), new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 1, milliseconds: 48), new TimeSpan(days: 0, hours: 2, minutes: 29, seconds: 42, milliseconds: 688), }, { new TimeSpan(days: 0, hours: 20, minutes: 39, seconds: 37, milliseconds: 523), new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 8, milliseconds: 269), new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 2, milliseconds: 72), }, }, { { new TimeSpan(days: 0, hours: 6, minutes: 15, seconds: 22, milliseconds: 309), new TimeSpan(days: 0, hours: 6, minutes: 3, seconds: 47, milliseconds: 406), new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 20, milliseconds: 600), }, { new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 37, milliseconds: 75), new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 11, milliseconds: 629), new TimeSpan(days: 0, hours: 17, minutes: 19, seconds: 34, milliseconds: 948), }, { new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 20, milliseconds: 150), new TimeSpan(days: 0, hours: 10, minutes: 21, seconds: 11, milliseconds: 815), new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 39, milliseconds: 568), }, }, { { new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 29, milliseconds: 417), new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 30, milliseconds: 810), new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 29, milliseconds: 157), }, { new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 25, milliseconds: 287), new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 42, milliseconds: 336), new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 47, milliseconds: 832), }, { new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 20, milliseconds: 786), new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 29, milliseconds: 459), new TimeSpan(days: 0, hours: 22, minutes: 43, seconds: 4, milliseconds: 838), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD3E1M> models = null;

                models =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD3E1M> models = null;

                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M), typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
LEFT JOIN public.timespanintervalmmarrayd3e1mi mi ON mi.id = m.timespanintervalmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M), typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
LEFT JOIN public.timespanintervalmmarrayd3e1mi mi ON mi.id = m.timespanintervalmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M), typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
LEFT JOIN public.timespanintervalmmarrayd3e1mi mi ON mi.id = m.timespanintervalmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[2], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[3], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[4], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[5], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[6], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[7], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[8], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[9], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[10], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[11], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[12], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[13], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[14], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[15], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[16], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[17], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[18], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[19], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[20], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[21], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[22], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[23], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[24], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[25],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[26],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[27],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[28],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[29],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[30],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[31],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M), typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 118, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 168, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 100, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
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
FROM public.timespanintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD3E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.timespanintervalmmarrayd3e1m m
LEFT JOIN public.timespanintervalmmarrayd3e1mi mi ON mi.id = m.timespanintervalmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 99, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        TimeSpanintervalMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanMArrayintervalMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanMArrayintervalMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((ITimeSpanMArrayintervalMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                TimeSpanintervalMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                TimeSpanintervalMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_timespanintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD3E1MIWA),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD3E1MI),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalMMArrayD3E1M),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
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
FROM public.binary_timespanintervalmmarrayd3e1m m
LEFT JOIN public.binary_timespanintervalmmarrayd3e1mi mi ON mi.id = m.timespanintervalmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models =  ((ITimeSpanMArrayintervalMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA), typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
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
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
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
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA), typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
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
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd3e1mi
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
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MI), typeof(TimeSpanintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MI>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MI>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA), typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD3E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD3))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

