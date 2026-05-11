

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
    internal partial interface ITimeOnlyMArraytime_without_time_zoneMMArrayD3
    {
    }
    
    internal partial class TimeOnlyMArraytime_without_time_zoneMMArrayD3 : ITimeOnlyMArraytime_without_time_zoneMMArrayD3
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneMMArrayD3E1M[] _testData = new TimeOnlytime_without_time_zoneMMArrayD3E1M[]
        {
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 5,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 8, minute: 43, second: 26, millisecond: 107), new TimeOnly(hour: 10, minute: 45, second: 27, millisecond: 538), new TimeOnly(hour: 16, minute: 42, second: 39, millisecond: 71), }, { new TimeOnly(hour: 13, minute: 24, second: 28, millisecond: 785), new TimeOnly(hour: 13, minute: 52, second: 11, millisecond: 492), new TimeOnly(hour: 21, minute: 14, second: 35, millisecond: 155), }, { new TimeOnly(hour: 15, minute: 3, second: 42, millisecond: 620), new TimeOnly(hour: 1, minute: 53, second: 47, millisecond: 972), new TimeOnly(hour: 22, minute: 7, second: 22, millisecond: 825), }, }, { { new TimeOnly(hour: 18, minute: 48, second: 34, millisecond: 580), new TimeOnly(hour: 10, minute: 4, second: 45, millisecond: 151), new TimeOnly(hour: 5, minute: 26, second: 50, millisecond: 904), }, { new TimeOnly(hour: 16, minute: 52, second: 3, millisecond: 695), new TimeOnly(hour: 7, minute: 6, second: 54, millisecond: 610), new TimeOnly(hour: 7, minute: 30, second: 4, millisecond: 798), }, { new TimeOnly(hour: 18, minute: 9, second: 22, millisecond: 374), new TimeOnly(hour: 7, minute: 5, second: 6, millisecond: 533), new TimeOnly(hour: 8, minute: 44, second: 12, millisecond: 629), }, }, { { new TimeOnly(hour: 19, minute: 56, second: 13, millisecond: 13), new TimeOnly(hour: 13, minute: 46, second: 15, millisecond: 699), new TimeOnly(hour: 12, minute: 34, second: 41, millisecond: 397), }, { new TimeOnly(hour: 19, minute: 26, second: 14, millisecond: 775), new TimeOnly(hour: 19, minute: 19, second: 55, millisecond: 314), new TimeOnly(hour: 1, minute: 15, second: 5, millisecond: 525), }, { new TimeOnly(hour: 6, minute: 52, second: 5, millisecond: 717), new TimeOnly(hour: 5, minute: 35, second: 5, millisecond: 622), new TimeOnly(hour: 8, minute: 23, second: 21, millisecond: 16), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 3, minute: 46, second: 27, millisecond: 677), new TimeOnly(hour: 7, minute: 28, second: 29, millisecond: 696), new TimeOnly(hour: 20, minute: 10, second: 14, millisecond: 452), }, { new TimeOnly(hour: 21, minute: 1, second: 54, millisecond: 950), new TimeOnly(hour: 16, minute: 45, second: 11, millisecond: 675), new TimeOnly(hour: 1, minute: 13, second: 1, millisecond: 135), }, { new TimeOnly(hour: 16, minute: 21, second: 18, millisecond: 917), new TimeOnly(hour: 13, minute: 12, second: 25, millisecond: 5), new TimeOnly(hour: 9, minute: 18, second: 21, millisecond: 956), }, }, { { new TimeOnly(hour: 1, minute: 45, second: 21, millisecond: 45), new TimeOnly(hour: 9, minute: 24, second: 22, millisecond: 710), new TimeOnly(hour: 12, minute: 36, second: 57, millisecond: 428), }, { new TimeOnly(hour: 13, minute: 54, second: 15, millisecond: 608), new TimeOnly(hour: 15, minute: 40, second: 34, millisecond: 147), new TimeOnly(hour: 20, minute: 9, second: 10, millisecond: 702), }, { new TimeOnly(hour: 2, minute: 12, second: 2, millisecond: 869), new TimeOnly(hour: 22, minute: 25, second: 29, millisecond: 558), new TimeOnly(hour: 16, minute: 40, second: 50, millisecond: 219), }, }, { { new TimeOnly(hour: 19, minute: 52, second: 9, millisecond: 895), new TimeOnly(hour: 17, minute: 47, second: 58, millisecond: 443), new TimeOnly(hour: 21, minute: 4, second: 11, millisecond: 965), }, { new TimeOnly(hour: 20, minute: 41, second: 50, millisecond: 654), new TimeOnly(hour: 9, minute: 57, second: 0, millisecond: 711), new TimeOnly(hour: 16, minute: 52, second: 32, millisecond: 308), }, { new TimeOnly(hour: 22, minute: 30, second: 41, millisecond: 430), new TimeOnly(hour: 13, minute: 56, second: 26, millisecond: 683), new TimeOnly(hour: 3, minute: 37, second: 38, millisecond: 915), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 14,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 6, minute: 19, second: 12, millisecond: 648), new TimeOnly(hour: 9, minute: 14, second: 27, millisecond: 569), new TimeOnly(hour: 13, minute: 29, second: 19, millisecond: 421), }, { new TimeOnly(hour: 1, minute: 52, second: 30, millisecond: 509), new TimeOnly(hour: 2, minute: 20, second: 37, millisecond: 928), new TimeOnly(hour: 13, minute: 11, second: 32, millisecond: 697), }, { new TimeOnly(hour: 6, minute: 55, second: 31, millisecond: 348), new TimeOnly(hour: 2, minute: 34, second: 10, millisecond: 463), new TimeOnly(hour: 2, minute: 33, second: 52, millisecond: 201), }, }, { { new TimeOnly(hour: 14, minute: 28, second: 42, millisecond: 735), new TimeOnly(hour: 10, minute: 33, second: 31, millisecond: 482), new TimeOnly(hour: 19, minute: 25, second: 27, millisecond: 737), }, { new TimeOnly(hour: 12, minute: 24, second: 21, millisecond: 509), new TimeOnly(hour: 3, minute: 0, second: 10, millisecond: 55), new TimeOnly(hour: 13, minute: 40, second: 7, millisecond: 602), }, { new TimeOnly(hour: 0, minute: 55, second: 57, millisecond: 676), new TimeOnly(hour: 1, minute: 50, second: 22, millisecond: 236), new TimeOnly(hour: 11, minute: 46, second: 13, millisecond: 166), }, }, { { new TimeOnly(hour: 17, minute: 45, second: 2, millisecond: 820), new TimeOnly(hour: 9, minute: 36, second: 17, millisecond: 901), new TimeOnly(hour: 8, minute: 46, second: 17, millisecond: 63), }, { new TimeOnly(hour: 11, minute: 35, second: 15, millisecond: 84), new TimeOnly(hour: 19, minute: 34, second: 43, millisecond: 957), new TimeOnly(hour: 16, minute: 6, second: 55, millisecond: 646), }, { new TimeOnly(hour: 12, minute: 19, second: 43, millisecond: 3), new TimeOnly(hour: 18, minute: 48, second: 49, millisecond: 593), new TimeOnly(hour: 18, minute: 3, second: 53, millisecond: 663), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 9,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 5, minute: 30, second: 48, millisecond: 671), new TimeOnly(hour: 7, minute: 18, second: 50, millisecond: 153), new TimeOnly(hour: 6, minute: 34, second: 3, millisecond: 56), }, { new TimeOnly(hour: 16, minute: 5, second: 42, millisecond: 864), new TimeOnly(hour: 19, minute: 53, second: 54, millisecond: 89), new TimeOnly(hour: 9, minute: 30, second: 34, millisecond: 857), }, { new TimeOnly(hour: 18, minute: 50, second: 26, millisecond: 245), new TimeOnly(hour: 7, minute: 29, second: 25, millisecond: 32), new TimeOnly(hour: 14, minute: 53, second: 9, millisecond: 926), }, }, { { new TimeOnly(hour: 9, minute: 33, second: 5, millisecond: 787), new TimeOnly(hour: 4, minute: 19, second: 11, millisecond: 610), new TimeOnly(hour: 5, minute: 8, second: 15, millisecond: 194), }, { new TimeOnly(hour: 15, minute: 9, second: 5, millisecond: 374), new TimeOnly(hour: 2, minute: 13, second: 7, millisecond: 773), new TimeOnly(hour: 6, minute: 30, second: 29, millisecond: 90), }, { new TimeOnly(hour: 5, minute: 10, second: 56, millisecond: 169), new TimeOnly(hour: 20, minute: 9, second: 8, millisecond: 493), new TimeOnly(hour: 10, minute: 42, second: 20, millisecond: 395), }, }, { { new TimeOnly(hour: 2, minute: 6, second: 17, millisecond: 130), new TimeOnly(hour: 15, minute: 17, second: 27, millisecond: 140), new TimeOnly(hour: 0, minute: 19, second: 40, millisecond: 671), }, { new TimeOnly(hour: 16, minute: 10, second: 21, millisecond: 846), new TimeOnly(hour: 20, minute: 25, second: 12, millisecond: 215), new TimeOnly(hour: 6, minute: 10, second: 21, millisecond: 297), }, { new TimeOnly(hour: 9, minute: 38, second: 40, millisecond: 881), new TimeOnly(hour: 19, minute: 48, second: 43, millisecond: 553), new TimeOnly(hour: 7, minute: 21, second: 54, millisecond: 906), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 8, minute: 29, second: 44, millisecond: 416), new TimeOnly(hour: 17, minute: 38, second: 34, millisecond: 14), new TimeOnly(hour: 18, minute: 19, second: 28, millisecond: 733), }, { new TimeOnly(hour: 18, minute: 38, second: 22, millisecond: 700), new TimeOnly(hour: 15, minute: 34, second: 42, millisecond: 443), new TimeOnly(hour: 10, minute: 47, second: 4, millisecond: 211), }, { new TimeOnly(hour: 9, minute: 4, second: 54, millisecond: 452), new TimeOnly(hour: 4, minute: 3, second: 36, millisecond: 807), new TimeOnly(hour: 18, minute: 28, second: 37, millisecond: 353), }, }, { { new TimeOnly(hour: 7, minute: 30, second: 6, millisecond: 327), new TimeOnly(hour: 0, minute: 13, second: 42, millisecond: 323), new TimeOnly(hour: 19, minute: 7, second: 11, millisecond: 986), }, { new TimeOnly(hour: 9, minute: 56, second: 18, millisecond: 265), new TimeOnly(hour: 0, minute: 25, second: 52, millisecond: 617), new TimeOnly(hour: 2, minute: 42, second: 54, millisecond: 782), }, { new TimeOnly(hour: 19, minute: 58, second: 39, millisecond: 326), new TimeOnly(hour: 9, minute: 10, second: 2, millisecond: 221), new TimeOnly(hour: 17, minute: 57, second: 36, millisecond: 344), }, }, { { new TimeOnly(hour: 16, minute: 4, second: 20, millisecond: 863), new TimeOnly(hour: 12, minute: 7, second: 28, millisecond: 234), new TimeOnly(hour: 8, minute: 30, second: 51, millisecond: 120), }, { new TimeOnly(hour: 21, minute: 2, second: 24, millisecond: 775), new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 354), new TimeOnly(hour: 19, minute: 51, second: 18, millisecond: 299), }, { new TimeOnly(hour: 8, minute: 48, second: 10, millisecond: 644), new TimeOnly(hour: 7, minute: 58, second: 44, millisecond: 366), new TimeOnly(hour: 22, minute: 35, second: 20, millisecond: 248), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 17,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 46, second: 18, millisecond: 587), new TimeOnly(hour: 4, minute: 50, second: 4, millisecond: 823), new TimeOnly(hour: 17, minute: 4, second: 52, millisecond: 621), }, { new TimeOnly(hour: 6, minute: 37, second: 0, millisecond: 479), new TimeOnly(hour: 4, minute: 53, second: 6, millisecond: 932), new TimeOnly(hour: 19, minute: 21, second: 13, millisecond: 664), }, { new TimeOnly(hour: 8, minute: 39, second: 8, millisecond: 899), new TimeOnly(hour: 22, minute: 18, second: 10, millisecond: 401), new TimeOnly(hour: 1, minute: 54, second: 21, millisecond: 641), }, }, { { new TimeOnly(hour: 10, minute: 9, second: 50, millisecond: 368), new TimeOnly(hour: 21, minute: 23, second: 16, millisecond: 407), new TimeOnly(hour: 14, minute: 19, second: 52, millisecond: 70), }, { new TimeOnly(hour: 11, minute: 57, second: 7, millisecond: 251), new TimeOnly(hour: 10, minute: 42, second: 20, millisecond: 451), new TimeOnly(hour: 14, minute: 49, second: 26, millisecond: 696), }, { new TimeOnly(hour: 1, minute: 53, second: 49, millisecond: 700), new TimeOnly(hour: 15, minute: 1, second: 1, millisecond: 376), new TimeOnly(hour: 7, minute: 33, second: 48, millisecond: 36), }, }, { { new TimeOnly(hour: 20, minute: 25, second: 45, millisecond: 643), new TimeOnly(hour: 12, minute: 3, second: 7, millisecond: 154), new TimeOnly(hour: 9, minute: 29, second: 7, millisecond: 158), }, { new TimeOnly(hour: 4, minute: 53, second: 24, millisecond: 22), new TimeOnly(hour: 17, minute: 3, second: 13, millisecond: 819), new TimeOnly(hour: 3, minute: 39, second: 20, millisecond: 939), }, { new TimeOnly(hour: 5, minute: 18, second: 27, millisecond: 924), new TimeOnly(hour: 6, minute: 3, second: 27, millisecond: 710), new TimeOnly(hour: 19, minute: 16, second: 35, millisecond: 862), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 12, minute: 33, second: 55, millisecond: 592), new TimeOnly(hour: 16, minute: 12, second: 55, millisecond: 901), new TimeOnly(hour: 3, minute: 56, second: 57, millisecond: 248), }, { new TimeOnly(hour: 8, minute: 46, second: 6, millisecond: 334), new TimeOnly(hour: 5, minute: 32, second: 37, millisecond: 638), new TimeOnly(hour: 12, minute: 33, second: 6, millisecond: 566), }, { new TimeOnly(hour: 4, minute: 50, second: 31, millisecond: 728), new TimeOnly(hour: 16, minute: 9, second: 18, millisecond: 722), new TimeOnly(hour: 1, minute: 17, second: 11, millisecond: 741), }, }, { { new TimeOnly(hour: 12, minute: 11, second: 55, millisecond: 93), new TimeOnly(hour: 6, minute: 11, second: 42, millisecond: 168), new TimeOnly(hour: 21, minute: 58, second: 26, millisecond: 85), }, { new TimeOnly(hour: 3, minute: 21, second: 4, millisecond: 784), new TimeOnly(hour: 20, minute: 32, second: 57, millisecond: 848), new TimeOnly(hour: 9, minute: 39, second: 53, millisecond: 567), }, { new TimeOnly(hour: 22, minute: 31, second: 53, millisecond: 444), new TimeOnly(hour: 8, minute: 6, second: 55, millisecond: 902), new TimeOnly(hour: 9, minute: 20, second: 20, millisecond: 6), }, }, { { new TimeOnly(hour: 12, minute: 26, second: 50, millisecond: 94), new TimeOnly(hour: 4, minute: 14, second: 4, millisecond: 205), new TimeOnly(hour: 22, minute: 21, second: 41, millisecond: 432), }, { new TimeOnly(hour: 18, minute: 0, second: 45, millisecond: 300), new TimeOnly(hour: 6, minute: 28, second: 19, millisecond: 47), new TimeOnly(hour: 0, minute: 25, second: 56, millisecond: 931), }, { new TimeOnly(hour: 19, minute: 48, second: 34, millisecond: 252), new TimeOnly(hour: 3, minute: 26, second: 36, millisecond: 172), new TimeOnly(hour: 4, minute: 6, second: 27, millisecond: 210), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 23,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 7, minute: 47, second: 38, millisecond: 807), new TimeOnly(hour: 12, minute: 56, second: 29, millisecond: 30), new TimeOnly(hour: 22, minute: 29, second: 31, millisecond: 500), }, { new TimeOnly(hour: 7, minute: 0, second: 2, millisecond: 224), new TimeOnly(hour: 8, minute: 43, second: 33, millisecond: 525), new TimeOnly(hour: 13, minute: 44, second: 21, millisecond: 565), }, { new TimeOnly(hour: 12, minute: 31, second: 15, millisecond: 451), new TimeOnly(hour: 9, minute: 23, second: 5, millisecond: 498), new TimeOnly(hour: 5, minute: 57, second: 32, millisecond: 711), }, }, { { new TimeOnly(hour: 7, minute: 17, second: 52, millisecond: 163), new TimeOnly(hour: 11, minute: 45, second: 54, millisecond: 534), new TimeOnly(hour: 18, minute: 22, second: 16, millisecond: 860), }, { new TimeOnly(hour: 7, minute: 39, second: 20, millisecond: 545), new TimeOnly(hour: 18, minute: 0, second: 21, millisecond: 460), new TimeOnly(hour: 1, minute: 8, second: 57, millisecond: 368), }, { new TimeOnly(hour: 17, minute: 37, second: 52, millisecond: 409), new TimeOnly(hour: 1, minute: 27, second: 38, millisecond: 996), new TimeOnly(hour: 17, minute: 13, second: 53, millisecond: 728), }, }, { { new TimeOnly(hour: 18, minute: 32, second: 34, millisecond: 117), new TimeOnly(hour: 19, minute: 42, second: 15, millisecond: 106), new TimeOnly(hour: 9, minute: 31, second: 20, millisecond: 428), }, { new TimeOnly(hour: 17, minute: 8, second: 28, millisecond: 578), new TimeOnly(hour: 15, minute: 44, second: 7, millisecond: 296), new TimeOnly(hour: 10, minute: 27, second: 44, millisecond: 989), }, { new TimeOnly(hour: 0, minute: 14, second: 7, millisecond: 485), new TimeOnly(hour: 8, minute: 23, second: 37, millisecond: 738), new TimeOnly(hour: 0, minute: 13, second: 35, millisecond: 742), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 16,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 17, minute: 9, second: 38, millisecond: 424), new TimeOnly(hour: 14, minute: 0, second: 8, millisecond: 232), new TimeOnly(hour: 12, minute: 54, second: 53, millisecond: 349), }, { new TimeOnly(hour: 10, minute: 9, second: 36, millisecond: 563), new TimeOnly(hour: 4, minute: 21, second: 55, millisecond: 464), new TimeOnly(hour: 19, minute: 18, second: 54, millisecond: 810), }, { new TimeOnly(hour: 14, minute: 53, second: 55, millisecond: 313), new TimeOnly(hour: 3, minute: 55, second: 52, millisecond: 568), new TimeOnly(hour: 8, minute: 54, second: 14, millisecond: 369), }, }, { { new TimeOnly(hour: 1, minute: 34, second: 35, millisecond: 627), new TimeOnly(hour: 19, minute: 16, second: 15, millisecond: 120), new TimeOnly(hour: 9, minute: 20, second: 3, millisecond: 512), }, { new TimeOnly(hour: 15, minute: 57, second: 39, millisecond: 548), new TimeOnly(hour: 17, minute: 7, second: 18, millisecond: 190), new TimeOnly(hour: 0, minute: 36, second: 3, millisecond: 344), }, { new TimeOnly(hour: 19, minute: 34, second: 33, millisecond: 427), new TimeOnly(hour: 16, minute: 3, second: 29, millisecond: 701), new TimeOnly(hour: 18, minute: 23, second: 48, millisecond: 2), }, }, { { new TimeOnly(hour: 5, minute: 5, second: 51, millisecond: 821), new TimeOnly(hour: 14, minute: 55, second: 23, millisecond: 658), new TimeOnly(hour: 13, minute: 8, second: 50, millisecond: 247), }, { new TimeOnly(hour: 17, minute: 8, second: 58, millisecond: 769), new TimeOnly(hour: 1, minute: 51, second: 13, millisecond: 961), new TimeOnly(hour: 2, minute: 57, second: 5, millisecond: 176), }, { new TimeOnly(hour: 13, minute: 42, second: 54, millisecond: 466), new TimeOnly(hour: 16, minute: 13, second: 38, millisecond: 18), new TimeOnly(hour: 11, minute: 53, second: 37, millisecond: 328), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 171), new TimeOnly(hour: 14, minute: 2, second: 23, millisecond: 320), new TimeOnly(hour: 22, minute: 28, second: 43, millisecond: 135), }, { new TimeOnly(hour: 21, minute: 20, second: 30, millisecond: 420), new TimeOnly(hour: 19, minute: 20, second: 58, millisecond: 880), new TimeOnly(hour: 2, minute: 7, second: 48, millisecond: 698), }, { new TimeOnly(hour: 15, minute: 49, second: 10, millisecond: 440), new TimeOnly(hour: 11, minute: 39, second: 40, millisecond: 298), new TimeOnly(hour: 11, minute: 36, second: 39, millisecond: 954), }, }, { { new TimeOnly(hour: 4, minute: 30, second: 52, millisecond: 456), new TimeOnly(hour: 12, minute: 15, second: 23, millisecond: 177), new TimeOnly(hour: 14, minute: 7, second: 44, millisecond: 675), }, { new TimeOnly(hour: 14, minute: 43, second: 20, millisecond: 270), new TimeOnly(hour: 16, minute: 16, second: 37, millisecond: 974), new TimeOnly(hour: 13, minute: 20, second: 22, millisecond: 328), }, { new TimeOnly(hour: 16, minute: 19, second: 51, millisecond: 77), new TimeOnly(hour: 20, minute: 46, second: 33, millisecond: 756), new TimeOnly(hour: 18, minute: 8, second: 22, millisecond: 404), }, }, { { new TimeOnly(hour: 20, minute: 15, second: 51, millisecond: 924), new TimeOnly(hour: 18, minute: 49, second: 0, millisecond: 179), new TimeOnly(hour: 18, minute: 45, second: 31, millisecond: 9), }, { new TimeOnly(hour: 3, minute: 25, second: 1, millisecond: 994), new TimeOnly(hour: 10, minute: 50, second: 47, millisecond: 545), new TimeOnly(hour: 14, minute: 2, second: 20, millisecond: 372), }, { new TimeOnly(hour: 5, minute: 24, second: 39, millisecond: 188), new TimeOnly(hour: 16, minute: 28, second: 33, millisecond: 923), new TimeOnly(hour: 20, minute: 40, second: 47, millisecond: 165), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 12, minute: 58, second: 18, millisecond: 883), new TimeOnly(hour: 19, minute: 4, second: 30, millisecond: 224), new TimeOnly(hour: 8, minute: 33, second: 23, millisecond: 866), }, { new TimeOnly(hour: 16, minute: 32, second: 14, millisecond: 432), new TimeOnly(hour: 2, minute: 51, second: 28, millisecond: 566), new TimeOnly(hour: 15, minute: 53, second: 46, millisecond: 686), }, { new TimeOnly(hour: 10, minute: 45, second: 7, millisecond: 889), new TimeOnly(hour: 18, minute: 56, second: 52, millisecond: 307), new TimeOnly(hour: 9, minute: 27, second: 47, millisecond: 942), }, }, { { new TimeOnly(hour: 14, minute: 20, second: 34, millisecond: 85), new TimeOnly(hour: 22, minute: 51, second: 7, millisecond: 276), new TimeOnly(hour: 2, minute: 50, second: 14, millisecond: 376), }, { new TimeOnly(hour: 22, minute: 27, second: 49, millisecond: 615), new TimeOnly(hour: 9, minute: 11, second: 21, millisecond: 777), new TimeOnly(hour: 10, minute: 38, second: 38, millisecond: 661), }, { new TimeOnly(hour: 10, minute: 5, second: 0, millisecond: 610), new TimeOnly(hour: 10, minute: 27, second: 40, millisecond: 481), new TimeOnly(hour: 12, minute: 18, second: 22, millisecond: 384), }, }, { { new TimeOnly(hour: 20, minute: 24, second: 58, millisecond: 576), new TimeOnly(hour: 17, minute: 7, second: 9, millisecond: 166), new TimeOnly(hour: 0, minute: 29, second: 46, millisecond: 340), }, { new TimeOnly(hour: 21, minute: 8, second: 14, millisecond: 539), new TimeOnly(hour: 21, minute: 31, second: 42, millisecond: 926), new TimeOnly(hour: 5, minute: 43, second: 42, millisecond: 947), }, { new TimeOnly(hour: 21, minute: 47, second: 20, millisecond: 237), new TimeOnly(hour: 15, minute: 45, second: 18, millisecond: 492), new TimeOnly(hour: 15, minute: 23, second: 20, millisecond: 912), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 24,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 40, second: 37, millisecond: 421), new TimeOnly(hour: 15, minute: 36, second: 46, millisecond: 402), new TimeOnly(hour: 19, minute: 13, second: 13, millisecond: 613), }, { new TimeOnly(hour: 6, minute: 15, second: 1, millisecond: 883), new TimeOnly(hour: 5, minute: 45, second: 14, millisecond: 324), new TimeOnly(hour: 19, minute: 39, second: 0, millisecond: 788), }, { new TimeOnly(hour: 11, minute: 54, second: 42, millisecond: 746), new TimeOnly(hour: 15, minute: 15, second: 31, millisecond: 259), new TimeOnly(hour: 15, minute: 17, second: 16, millisecond: 211), }, }, { { new TimeOnly(hour: 22, minute: 32, second: 47, millisecond: 241), new TimeOnly(hour: 13, minute: 13, second: 11, millisecond: 418), new TimeOnly(hour: 10, minute: 20, second: 54, millisecond: 333), }, { new TimeOnly(hour: 11, minute: 20, second: 55, millisecond: 707), new TimeOnly(hour: 16, minute: 41, second: 5, millisecond: 174), new TimeOnly(hour: 7, minute: 12, second: 11, millisecond: 605), }, { new TimeOnly(hour: 15, minute: 12, second: 37, millisecond: 478), new TimeOnly(hour: 22, minute: 13, second: 35, millisecond: 586), new TimeOnly(hour: 21, minute: 9, second: 53, millisecond: 225), }, }, { { new TimeOnly(hour: 11, minute: 34, second: 13, millisecond: 752), new TimeOnly(hour: 6, minute: 22, second: 7, millisecond: 134), new TimeOnly(hour: 9, minute: 16, second: 24, millisecond: 923), }, { new TimeOnly(hour: 1, minute: 45, second: 17, millisecond: 883), new TimeOnly(hour: 12, minute: 3, second: 23, millisecond: 212), new TimeOnly(hour: 17, minute: 33, second: 20, millisecond: 931), }, { new TimeOnly(hour: 19, minute: 32, second: 23, millisecond: 386), new TimeOnly(hour: 3, minute: 20, second: 20, millisecond: 724), new TimeOnly(hour: 5, minute: 30, second: 29, millisecond: 932), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 44, second: 47, millisecond: 647), new TimeOnly(hour: 8, minute: 4, second: 13, millisecond: 835), new TimeOnly(hour: 6, minute: 16, second: 13, millisecond: 574), }, { new TimeOnly(hour: 5, minute: 0, second: 15, millisecond: 884), new TimeOnly(hour: 12, minute: 10, second: 13, millisecond: 809), new TimeOnly(hour: 17, minute: 14, second: 18, millisecond: 423), }, { new TimeOnly(hour: 22, minute: 41, second: 16, millisecond: 852), new TimeOnly(hour: 14, minute: 46, second: 49, millisecond: 834), new TimeOnly(hour: 16, minute: 40, second: 24, millisecond: 714), }, }, { { new TimeOnly(hour: 4, minute: 34, second: 8, millisecond: 328), new TimeOnly(hour: 19, minute: 38, second: 22, millisecond: 698), new TimeOnly(hour: 9, minute: 31, second: 24, millisecond: 372), }, { new TimeOnly(hour: 15, minute: 30, second: 26, millisecond: 569), new TimeOnly(hour: 14, minute: 54, second: 17, millisecond: 140), new TimeOnly(hour: 3, minute: 12, second: 16, millisecond: 930), }, { new TimeOnly(hour: 6, minute: 49, second: 53, millisecond: 85), new TimeOnly(hour: 14, minute: 49, second: 0, millisecond: 94), new TimeOnly(hour: 6, minute: 31, second: 48, millisecond: 547), }, }, { { new TimeOnly(hour: 16, minute: 42, second: 35, millisecond: 946), new TimeOnly(hour: 20, minute: 13, second: 40, millisecond: 880), new TimeOnly(hour: 18, minute: 8, second: 2, millisecond: 61), }, { new TimeOnly(hour: 21, minute: 1, second: 9, millisecond: 680), new TimeOnly(hour: 5, minute: 20, second: 30, millisecond: 823), new TimeOnly(hour: 7, minute: 57, second: 51, millisecond: 890), }, { new TimeOnly(hour: 11, minute: 41, second: 30, millisecond: 286), new TimeOnly(hour: 3, minute: 26, second: 50, millisecond: 574), new TimeOnly(hour: 13, minute: 41, second: 28, millisecond: 856), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 26,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 9, minute: 35, second: 48, millisecond: 519), new TimeOnly(hour: 3, minute: 11, second: 21, millisecond: 99), new TimeOnly(hour: 20, minute: 40, second: 55, millisecond: 276), }, { new TimeOnly(hour: 21, minute: 14, second: 26, millisecond: 718), new TimeOnly(hour: 16, minute: 7, second: 6, millisecond: 98), new TimeOnly(hour: 8, minute: 49, second: 36, millisecond: 687), }, { new TimeOnly(hour: 19, minute: 57, second: 54, millisecond: 804), new TimeOnly(hour: 13, minute: 18, second: 11, millisecond: 625), new TimeOnly(hour: 14, minute: 11, second: 48, millisecond: 92), }, }, { { new TimeOnly(hour: 7, minute: 20, second: 10, millisecond: 23), new TimeOnly(hour: 19, minute: 17, second: 5, millisecond: 637), new TimeOnly(hour: 16, minute: 57, second: 32, millisecond: 209), }, { new TimeOnly(hour: 8, minute: 25, second: 6, millisecond: 894), new TimeOnly(hour: 13, minute: 32, second: 25, millisecond: 189), new TimeOnly(hour: 18, minute: 0, second: 57, millisecond: 548), }, { new TimeOnly(hour: 21, minute: 28, second: 55, millisecond: 583), new TimeOnly(hour: 19, minute: 50, second: 49, millisecond: 690), new TimeOnly(hour: 12, minute: 20, second: 38, millisecond: 935), }, }, { { new TimeOnly(hour: 10, minute: 27, second: 56, millisecond: 797), new TimeOnly(hour: 6, minute: 57, second: 23, millisecond: 970), new TimeOnly(hour: 14, minute: 54, second: 30, millisecond: 40), }, { new TimeOnly(hour: 4, minute: 41, second: 10, millisecond: 891), new TimeOnly(hour: 4, minute: 7, second: 21, millisecond: 47), new TimeOnly(hour: 4, minute: 16, second: 13, millisecond: 532), }, { new TimeOnly(hour: 0, minute: 14, second: 27, millisecond: 861), new TimeOnly(hour: 7, minute: 1, second: 44, millisecond: 851), new TimeOnly(hour: 18, minute: 42, second: 37, millisecond: 87), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 23,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 40, second: 57, millisecond: 609), new TimeOnly(hour: 10, minute: 29, second: 6, millisecond: 599), new TimeOnly(hour: 21, minute: 41, second: 54, millisecond: 44), }, { new TimeOnly(hour: 13, minute: 26, second: 2, millisecond: 472), new TimeOnly(hour: 10, minute: 6, second: 37, millisecond: 926), new TimeOnly(hour: 22, minute: 28, second: 36, millisecond: 716), }, { new TimeOnly(hour: 14, minute: 41, second: 53, millisecond: 322), new TimeOnly(hour: 12, minute: 49, second: 22, millisecond: 591), new TimeOnly(hour: 14, minute: 14, second: 51, millisecond: 780), }, }, { { new TimeOnly(hour: 20, minute: 40, second: 6, millisecond: 539), new TimeOnly(hour: 4, minute: 23, second: 50, millisecond: 707), new TimeOnly(hour: 12, minute: 29, second: 31, millisecond: 27), }, { new TimeOnly(hour: 10, minute: 48, second: 10, millisecond: 517), new TimeOnly(hour: 12, minute: 23, second: 27, millisecond: 246), new TimeOnly(hour: 21, minute: 22, second: 26, millisecond: 557), }, { new TimeOnly(hour: 21, minute: 9, second: 29, millisecond: 849), new TimeOnly(hour: 18, minute: 48, second: 52, millisecond: 301), new TimeOnly(hour: 19, minute: 41, second: 17, millisecond: 36), }, }, { { new TimeOnly(hour: 18, minute: 47, second: 15, millisecond: 55), new TimeOnly(hour: 18, minute: 9, second: 39, millisecond: 146), new TimeOnly(hour: 6, minute: 20, second: 27, millisecond: 239), }, { new TimeOnly(hour: 1, minute: 42, second: 3, millisecond: 257), new TimeOnly(hour: 16, minute: 17, second: 53, millisecond: 591), new TimeOnly(hour: 22, minute: 12, second: 43, millisecond: 235), }, { new TimeOnly(hour: 16, minute: 18, second: 7, millisecond: 141), new TimeOnly(hour: 19, minute: 34, second: 36, millisecond: 53), new TimeOnly(hour: 11, minute: 54, second: 32, millisecond: 141), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 35,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 49, second: 15, millisecond: 669), new TimeOnly(hour: 22, minute: 30, second: 13, millisecond: 756), new TimeOnly(hour: 13, minute: 11, second: 3, millisecond: 590), }, { new TimeOnly(hour: 2, minute: 14, second: 51, millisecond: 658), new TimeOnly(hour: 16, minute: 44, second: 56, millisecond: 863), new TimeOnly(hour: 13, minute: 19, second: 49, millisecond: 616), }, { new TimeOnly(hour: 6, minute: 35, second: 18, millisecond: 11), new TimeOnly(hour: 16, minute: 32, second: 52, millisecond: 74), new TimeOnly(hour: 13, minute: 44, second: 19, millisecond: 500), }, }, { { new TimeOnly(hour: 13, minute: 13, second: 4, millisecond: 377), new TimeOnly(hour: 16, minute: 8, second: 23, millisecond: 651), new TimeOnly(hour: 21, minute: 40, second: 15, millisecond: 56), }, { new TimeOnly(hour: 15, minute: 7, second: 17, millisecond: 907), new TimeOnly(hour: 13, minute: 6, second: 30, millisecond: 993), new TimeOnly(hour: 20, minute: 43, second: 10, millisecond: 830), }, { new TimeOnly(hour: 21, minute: 49, second: 5, millisecond: 259), new TimeOnly(hour: 2, minute: 20, second: 41, millisecond: 460), new TimeOnly(hour: 12, minute: 46, second: 47, millisecond: 715), }, }, { { new TimeOnly(hour: 12, minute: 50, second: 53, millisecond: 715), new TimeOnly(hour: 9, minute: 46, second: 54, millisecond: 74), new TimeOnly(hour: 10, minute: 20, second: 40, millisecond: 7), }, { new TimeOnly(hour: 16, minute: 42, second: 35, millisecond: 367), new TimeOnly(hour: 2, minute: 44, second: 44, millisecond: 168), new TimeOnly(hour: 0, minute: 20, second: 29, millisecond: 300), }, { new TimeOnly(hour: 7, minute: 56, second: 41, millisecond: 116), new TimeOnly(hour: 10, minute: 43, second: 39, millisecond: 885), new TimeOnly(hour: 21, minute: 8, second: 0, millisecond: 48), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 5, minute: 21, second: 1, millisecond: 259), new TimeOnly(hour: 9, minute: 58, second: 34, millisecond: 100), new TimeOnly(hour: 22, minute: 31, second: 46, millisecond: 641), }, { new TimeOnly(hour: 21, minute: 41, second: 32, millisecond: 497), new TimeOnly(hour: 4, minute: 31, second: 52, millisecond: 404), new TimeOnly(hour: 4, minute: 5, second: 2, millisecond: 278), }, { new TimeOnly(hour: 9, minute: 21, second: 6, millisecond: 482), new TimeOnly(hour: 16, minute: 12, second: 1, millisecond: 449), new TimeOnly(hour: 11, minute: 47, second: 19, millisecond: 950), }, }, { { new TimeOnly(hour: 13, minute: 30, second: 47, millisecond: 304), new TimeOnly(hour: 12, minute: 55, second: 41, millisecond: 736), new TimeOnly(hour: 21, minute: 18, second: 0, millisecond: 928), }, { new TimeOnly(hour: 4, minute: 6, second: 28, millisecond: 922), new TimeOnly(hour: 18, minute: 3, second: 43, millisecond: 839), new TimeOnly(hour: 2, minute: 8, second: 19, millisecond: 843), }, { new TimeOnly(hour: 22, minute: 46, second: 46, millisecond: 357), new TimeOnly(hour: 1, minute: 0, second: 36, millisecond: 470), new TimeOnly(hour: 14, minute: 45, second: 11, millisecond: 530), }, }, { { new TimeOnly(hour: 20, minute: 39, second: 7, millisecond: 130), new TimeOnly(hour: 8, minute: 15, second: 51, millisecond: 636), new TimeOnly(hour: 19, minute: 24, second: 10, millisecond: 442), }, { new TimeOnly(hour: 4, minute: 24, second: 2, millisecond: 605), new TimeOnly(hour: 2, minute: 25, second: 7, millisecond: 400), new TimeOnly(hour: 1, minute: 46, second: 46, millisecond: 552), }, { new TimeOnly(hour: 12, minute: 29, second: 39, millisecond: 764), new TimeOnly(hour: 15, minute: 58, second: 37, millisecond: 381), new TimeOnly(hour: 10, minute: 13, second: 42, millisecond: 237), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 42,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 7, second: 48, millisecond: 184), new TimeOnly(hour: 8, minute: 11, second: 19, millisecond: 567), new TimeOnly(hour: 16, minute: 45, second: 0, millisecond: 159), }, { new TimeOnly(hour: 3, minute: 3, second: 47, millisecond: 843), new TimeOnly(hour: 8, minute: 16, second: 26, millisecond: 441), new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 281), }, { new TimeOnly(hour: 4, minute: 44, second: 1, millisecond: 984), new TimeOnly(hour: 12, minute: 56, second: 0, millisecond: 880), new TimeOnly(hour: 10, minute: 2, second: 47, millisecond: 865), }, }, { { new TimeOnly(hour: 22, minute: 28, second: 38, millisecond: 819), new TimeOnly(hour: 16, minute: 14, second: 43, millisecond: 479), new TimeOnly(hour: 11, minute: 55, second: 24, millisecond: 606), }, { new TimeOnly(hour: 16, minute: 26, second: 56, millisecond: 478), new TimeOnly(hour: 8, minute: 19, second: 31, millisecond: 682), new TimeOnly(hour: 21, minute: 28, second: 6, millisecond: 136), }, { new TimeOnly(hour: 10, minute: 39, second: 11, millisecond: 707), new TimeOnly(hour: 21, minute: 56, second: 43, millisecond: 806), new TimeOnly(hour: 2, minute: 30, second: 50, millisecond: 992), }, }, { { new TimeOnly(hour: 1, minute: 45, second: 22, millisecond: 527), new TimeOnly(hour: 7, minute: 1, second: 38, millisecond: 674), new TimeOnly(hour: 7, minute: 8, second: 31, millisecond: 537), }, { new TimeOnly(hour: 13, minute: 14, second: 7, millisecond: 825), new TimeOnly(hour: 19, minute: 29, second: 29, millisecond: 149), new TimeOnly(hour: 10, minute: 39, second: 53, millisecond: 57), }, { new TimeOnly(hour: 2, minute: 11, second: 14, millisecond: 935), new TimeOnly(hour: 7, minute: 8, second: 49, millisecond: 67), new TimeOnly(hour: 9, minute: 30, second: 53, millisecond: 705), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 27,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 3, minute: 13, second: 22, millisecond: 190), new TimeOnly(hour: 7, minute: 16, second: 41, millisecond: 9), new TimeOnly(hour: 2, minute: 25, second: 15, millisecond: 122), }, { new TimeOnly(hour: 10, minute: 26, second: 27, millisecond: 348), new TimeOnly(hour: 7, minute: 38, second: 55, millisecond: 390), new TimeOnly(hour: 14, minute: 28, second: 47, millisecond: 757), }, { new TimeOnly(hour: 13, minute: 41, second: 35, millisecond: 611), new TimeOnly(hour: 11, minute: 52, second: 40, millisecond: 634), new TimeOnly(hour: 20, minute: 36, second: 49, millisecond: 22), }, }, { { new TimeOnly(hour: 8, minute: 30, second: 57, millisecond: 47), new TimeOnly(hour: 17, minute: 52, second: 21, millisecond: 204), new TimeOnly(hour: 1, minute: 35, second: 7, millisecond: 428), }, { new TimeOnly(hour: 0, minute: 43, second: 17, millisecond: 717), new TimeOnly(hour: 4, minute: 50, second: 12, millisecond: 672), new TimeOnly(hour: 12, minute: 15, second: 50, millisecond: 333), }, { new TimeOnly(hour: 2, minute: 3, second: 44, millisecond: 632), new TimeOnly(hour: 18, minute: 33, second: 0, millisecond: 887), new TimeOnly(hour: 19, minute: 41, second: 54, millisecond: 26), }, }, { { new TimeOnly(hour: 19, minute: 22, second: 48, millisecond: 612), new TimeOnly(hour: 16, minute: 30, second: 38, millisecond: 221), new TimeOnly(hour: 5, minute: 3, second: 26, millisecond: 695), }, { new TimeOnly(hour: 3, minute: 39, second: 26, millisecond: 968), new TimeOnly(hour: 2, minute: 27, second: 2, millisecond: 926), new TimeOnly(hour: 17, minute: 9, second: 12, millisecond: 301), }, { new TimeOnly(hour: 20, minute: 16, second: 37, millisecond: 207), new TimeOnly(hour: 4, minute: 12, second: 20, millisecond: 671), new TimeOnly(hour: 5, minute: 8, second: 37, millisecond: 34), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 58, second: 8, millisecond: 339), new TimeOnly(hour: 3, minute: 17, second: 42, millisecond: 946), new TimeOnly(hour: 22, minute: 52, second: 35, millisecond: 688), }, { new TimeOnly(hour: 5, minute: 11, second: 23, millisecond: 804), new TimeOnly(hour: 21, minute: 28, second: 11, millisecond: 295), new TimeOnly(hour: 12, minute: 43, second: 38, millisecond: 875), }, { new TimeOnly(hour: 19, minute: 10, second: 41, millisecond: 828), new TimeOnly(hour: 11, minute: 53, second: 28, millisecond: 124), new TimeOnly(hour: 12, minute: 6, second: 28, millisecond: 144), }, }, { { new TimeOnly(hour: 9, minute: 25, second: 41, millisecond: 705), new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 830), new TimeOnly(hour: 13, minute: 50, second: 0, millisecond: 406), }, { new TimeOnly(hour: 5, minute: 27, second: 56, millisecond: 90), new TimeOnly(hour: 21, minute: 45, second: 18, millisecond: 682), new TimeOnly(hour: 2, minute: 25, second: 43, millisecond: 802), }, { new TimeOnly(hour: 8, minute: 53, second: 54, millisecond: 936), new TimeOnly(hour: 9, minute: 44, second: 3, millisecond: 324), new TimeOnly(hour: 20, minute: 38, second: 39, millisecond: 699), }, }, { { new TimeOnly(hour: 16, minute: 24, second: 23, millisecond: 520), new TimeOnly(hour: 0, minute: 58, second: 31, millisecond: 672), new TimeOnly(hour: 1, minute: 13, second: 30, millisecond: 905), }, { new TimeOnly(hour: 11, minute: 56, second: 53, millisecond: 772), new TimeOnly(hour: 9, minute: 13, second: 9, millisecond: 484), new TimeOnly(hour: 22, minute: 6, second: 33, millisecond: 110), }, { new TimeOnly(hour: 14, minute: 38, second: 51, millisecond: 765), new TimeOnly(hour: 5, minute: 6, second: 37, millisecond: 813), new TimeOnly(hour: 14, minute: 35, second: 26, millisecond: 920), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 6, minute: 56, second: 54, millisecond: 761), new TimeOnly(hour: 21, minute: 4, second: 27, millisecond: 293), new TimeOnly(hour: 4, minute: 29, second: 43, millisecond: 859), }, { new TimeOnly(hour: 0, minute: 35, second: 39, millisecond: 243), new TimeOnly(hour: 17, minute: 30, second: 54, millisecond: 217), new TimeOnly(hour: 20, minute: 28, second: 31, millisecond: 58), }, { new TimeOnly(hour: 13, minute: 2, second: 8, millisecond: 121), new TimeOnly(hour: 19, minute: 18, second: 21, millisecond: 611), new TimeOnly(hour: 20, minute: 10, second: 28, millisecond: 36), }, }, { { new TimeOnly(hour: 13, minute: 58, second: 8, millisecond: 952), new TimeOnly(hour: 11, minute: 55, second: 47, millisecond: 204), new TimeOnly(hour: 4, minute: 44, second: 24, millisecond: 752), }, { new TimeOnly(hour: 22, minute: 54, second: 14, millisecond: 840), new TimeOnly(hour: 8, minute: 16, second: 38, millisecond: 983), new TimeOnly(hour: 1, minute: 42, second: 49, millisecond: 247), }, { new TimeOnly(hour: 10, minute: 5, second: 11, millisecond: 326), new TimeOnly(hour: 10, minute: 47, second: 12, millisecond: 588), new TimeOnly(hour: 20, minute: 35, second: 54, millisecond: 794), }, }, { { new TimeOnly(hour: 9, minute: 43, second: 15, millisecond: 568), new TimeOnly(hour: 22, minute: 35, second: 11, millisecond: 13), new TimeOnly(hour: 4, minute: 21, second: 22, millisecond: 216), }, { new TimeOnly(hour: 15, minute: 16, second: 4, millisecond: 857), new TimeOnly(hour: 5, minute: 34, second: 38, millisecond: 693), new TimeOnly(hour: 0, minute: 21, second: 2, millisecond: 444), }, { new TimeOnly(hour: 12, minute: 54, second: 55, millisecond: 445), new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 329), new TimeOnly(hour: 15, minute: 16, second: 7, millisecond: 217), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 44,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 21, second: 15, millisecond: 454), new TimeOnly(hour: 10, minute: 36, second: 33, millisecond: 381), new TimeOnly(hour: 10, minute: 36, second: 32, millisecond: 509), }, { new TimeOnly(hour: 15, minute: 38, second: 8, millisecond: 300), new TimeOnly(hour: 12, minute: 50, second: 41, millisecond: 110), new TimeOnly(hour: 3, minute: 43, second: 55, millisecond: 934), }, { new TimeOnly(hour: 20, minute: 19, second: 48, millisecond: 941), new TimeOnly(hour: 16, minute: 46, second: 56, millisecond: 353), new TimeOnly(hour: 21, minute: 0, second: 16, millisecond: 221), }, }, { { new TimeOnly(hour: 12, minute: 10, second: 41, millisecond: 79), new TimeOnly(hour: 22, minute: 3, second: 10, millisecond: 751), new TimeOnly(hour: 5, minute: 41, second: 44, millisecond: 81), }, { new TimeOnly(hour: 6, minute: 45, second: 40, millisecond: 874), new TimeOnly(hour: 18, minute: 9, second: 10, millisecond: 548), new TimeOnly(hour: 5, minute: 5, second: 47, millisecond: 752), }, { new TimeOnly(hour: 18, minute: 13, second: 22, millisecond: 591), new TimeOnly(hour: 22, minute: 40, second: 51, millisecond: 438), new TimeOnly(hour: 12, minute: 55, second: 11, millisecond: 812), }, }, { { new TimeOnly(hour: 21, minute: 41, second: 45, millisecond: 738), new TimeOnly(hour: 18, minute: 55, second: 33, millisecond: 186), new TimeOnly(hour: 13, minute: 35, second: 48, millisecond: 541), }, { new TimeOnly(hour: 21, minute: 54, second: 30, millisecond: 306), new TimeOnly(hour: 17, minute: 22, second: 51, millisecond: 120), new TimeOnly(hour: 9, minute: 46, second: 15, millisecond: 795), }, { new TimeOnly(hour: 9, minute: 21, second: 5, millisecond: 867), new TimeOnly(hour: 19, minute: 26, second: 6, millisecond: 783), new TimeOnly(hour: 15, minute: 2, second: 57, millisecond: 108), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 5, minute: 29, second: 5, millisecond: 77), new TimeOnly(hour: 1, minute: 12, second: 23, millisecond: 885), new TimeOnly(hour: 0, minute: 9, second: 27, millisecond: 132), }, { new TimeOnly(hour: 9, minute: 30, second: 36, millisecond: 545), new TimeOnly(hour: 20, minute: 23, second: 10, millisecond: 13), new TimeOnly(hour: 21, minute: 42, second: 39, millisecond: 654), }, { new TimeOnly(hour: 16, minute: 18, second: 45, millisecond: 353), new TimeOnly(hour: 20, minute: 28, second: 17, millisecond: 800), new TimeOnly(hour: 4, minute: 26, second: 36, millisecond: 201), }, }, { { new TimeOnly(hour: 11, minute: 16, second: 7, millisecond: 589), new TimeOnly(hour: 10, minute: 50, second: 36, millisecond: 555), new TimeOnly(hour: 5, minute: 29, second: 8, millisecond: 592), }, { new TimeOnly(hour: 16, minute: 29, second: 29, millisecond: 25), new TimeOnly(hour: 6, minute: 47, second: 52, millisecond: 437), new TimeOnly(hour: 1, minute: 48, second: 34, millisecond: 57), }, { new TimeOnly(hour: 1, minute: 33, second: 24, millisecond: 722), new TimeOnly(hour: 11, minute: 6, second: 55, millisecond: 951), new TimeOnly(hour: 18, minute: 1, second: 32, millisecond: 80), }, }, { { new TimeOnly(hour: 4, minute: 56, second: 12, millisecond: 8), new TimeOnly(hour: 2, minute: 40, second: 55, millisecond: 680), new TimeOnly(hour: 17, minute: 38, second: 36, millisecond: 337), }, { new TimeOnly(hour: 17, minute: 26, second: 50, millisecond: 845), new TimeOnly(hour: 19, minute: 17, second: 31, millisecond: 676), new TimeOnly(hour: 12, minute: 38, second: 20, millisecond: 901), }, { new TimeOnly(hour: 20, minute: 12, second: 41, millisecond: 261), new TimeOnly(hour: 7, minute: 32, second: 10, millisecond: 706), new TimeOnly(hour: 13, minute: 32, second: 8, millisecond: 959), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 47,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 10, minute: 4, second: 18, millisecond: 207), new TimeOnly(hour: 16, minute: 42, second: 5, millisecond: 242), new TimeOnly(hour: 12, minute: 34, second: 26, millisecond: 57), }, { new TimeOnly(hour: 15, minute: 18, second: 33, millisecond: 430), new TimeOnly(hour: 6, minute: 8, second: 11, millisecond: 655), new TimeOnly(hour: 17, minute: 56, second: 36, millisecond: 992), }, { new TimeOnly(hour: 10, minute: 17, second: 30, millisecond: 978), new TimeOnly(hour: 11, minute: 14, second: 38, millisecond: 41), new TimeOnly(hour: 15, minute: 32, second: 55, millisecond: 957), }, }, { { new TimeOnly(hour: 12, minute: 10, second: 0, millisecond: 244), new TimeOnly(hour: 11, minute: 41, second: 3, millisecond: 464), new TimeOnly(hour: 16, minute: 30, second: 16, millisecond: 452), }, { new TimeOnly(hour: 7, minute: 32, second: 38, millisecond: 8), new TimeOnly(hour: 20, minute: 42, second: 48, millisecond: 222), new TimeOnly(hour: 6, minute: 8, second: 2, millisecond: 532), }, { new TimeOnly(hour: 6, minute: 15, second: 49, millisecond: 107), new TimeOnly(hour: 0, minute: 34, second: 50, millisecond: 162), new TimeOnly(hour: 12, minute: 14, second: 39, millisecond: 906), }, }, { { new TimeOnly(hour: 2, minute: 48, second: 21, millisecond: 876), new TimeOnly(hour: 10, minute: 21, second: 31, millisecond: 964), new TimeOnly(hour: 9, minute: 50, second: 9, millisecond: 724), }, { new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 832), new TimeOnly(hour: 15, minute: 0, second: 7, millisecond: 544), new TimeOnly(hour: 5, minute: 10, second: 54, millisecond: 744), }, { new TimeOnly(hour: 9, minute: 46, second: 49, millisecond: 374), new TimeOnly(hour: 15, minute: 9, second: 24, millisecond: 261), new TimeOnly(hour: 4, minute: 7, second: 9, millisecond: 789), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 28,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 8, minute: 25, second: 14, millisecond: 546), new TimeOnly(hour: 18, minute: 20, second: 30, millisecond: 133), new TimeOnly(hour: 19, minute: 16, second: 24, millisecond: 590), }, { new TimeOnly(hour: 7, minute: 42, second: 32, millisecond: 695), new TimeOnly(hour: 13, minute: 14, second: 0, millisecond: 574), new TimeOnly(hour: 20, minute: 57, second: 12, millisecond: 78), }, { new TimeOnly(hour: 9, minute: 47, second: 20, millisecond: 281), new TimeOnly(hour: 8, minute: 0, second: 4, millisecond: 902), new TimeOnly(hour: 1, minute: 5, second: 28, millisecond: 539), }, }, { { new TimeOnly(hour: 8, minute: 5, second: 41, millisecond: 625), new TimeOnly(hour: 11, minute: 30, second: 19, millisecond: 940), new TimeOnly(hour: 8, minute: 16, second: 21, millisecond: 53), }, { new TimeOnly(hour: 0, minute: 30, second: 20, millisecond: 710), new TimeOnly(hour: 15, minute: 22, second: 37, millisecond: 195), new TimeOnly(hour: 3, minute: 26, second: 26, millisecond: 493), }, { new TimeOnly(hour: 10, minute: 37, second: 39, millisecond: 626), new TimeOnly(hour: 4, minute: 14, second: 51, millisecond: 266), new TimeOnly(hour: 0, minute: 15, second: 41, millisecond: 913), }, }, { { new TimeOnly(hour: 6, minute: 55, second: 11, millisecond: 468), new TimeOnly(hour: 11, minute: 25, second: 39, millisecond: 393), new TimeOnly(hour: 10, minute: 14, second: 16, millisecond: 442), }, { new TimeOnly(hour: 0, minute: 12, second: 56, millisecond: 224), new TimeOnly(hour: 4, minute: 5, second: 36, millisecond: 143), new TimeOnly(hour: 14, minute: 54, second: 54, millisecond: 222), }, { new TimeOnly(hour: 14, minute: 23, second: 56, millisecond: 887), new TimeOnly(hour: 8, minute: 28, second: 7, millisecond: 97), new TimeOnly(hour: 5, minute: 20, second: 2, millisecond: 564), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 10, second: 17, millisecond: 7), new TimeOnly(hour: 10, minute: 11, second: 28, millisecond: 644), new TimeOnly(hour: 0, minute: 50, second: 39, millisecond: 331), }, { new TimeOnly(hour: 15, minute: 8, second: 10, millisecond: 172), new TimeOnly(hour: 14, minute: 39, second: 9, millisecond: 437), new TimeOnly(hour: 9, minute: 32, second: 54, millisecond: 721), }, { new TimeOnly(hour: 10, minute: 14, second: 57, millisecond: 644), new TimeOnly(hour: 11, minute: 4, second: 10, millisecond: 367), new TimeOnly(hour: 5, minute: 16, second: 11, millisecond: 187), }, }, { { new TimeOnly(hour: 1, minute: 0, second: 23, millisecond: 481), new TimeOnly(hour: 10, minute: 34, second: 30, millisecond: 973), new TimeOnly(hour: 16, minute: 56, second: 46, millisecond: 941), }, { new TimeOnly(hour: 22, minute: 12, second: 3, millisecond: 720), new TimeOnly(hour: 1, minute: 35, second: 18, millisecond: 619), new TimeOnly(hour: 8, minute: 21, second: 21, millisecond: 408), }, { new TimeOnly(hour: 8, minute: 34, second: 22, millisecond: 457), new TimeOnly(hour: 3, minute: 37, second: 0, millisecond: 440), new TimeOnly(hour: 18, minute: 1, second: 17, millisecond: 241), }, }, { { new TimeOnly(hour: 13, minute: 48, second: 57, millisecond: 283), new TimeOnly(hour: 0, minute: 46, second: 48, millisecond: 77), new TimeOnly(hour: 7, minute: 19, second: 53, millisecond: 885), }, { new TimeOnly(hour: 17, minute: 7, second: 15, millisecond: 929), new TimeOnly(hour: 9, minute: 46, second: 12, millisecond: 878), new TimeOnly(hour: 5, minute: 24, second: 22, millisecond: 414), }, { new TimeOnly(hour: 7, minute: 11, second: 48, millisecond: 761), new TimeOnly(hour: 5, minute: 28, second: 5, millisecond: 710), new TimeOnly(hour: 18, minute: 16, second: 44, millisecond: 848), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 55,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 38, second: 6, millisecond: 605), new TimeOnly(hour: 12, minute: 55, second: 42, millisecond: 495), new TimeOnly(hour: 0, minute: 21, second: 5, millisecond: 484), }, { new TimeOnly(hour: 15, minute: 47, second: 24, millisecond: 551), new TimeOnly(hour: 12, minute: 35, second: 57, millisecond: 970), new TimeOnly(hour: 1, minute: 58, second: 19, millisecond: 377), }, { new TimeOnly(hour: 5, minute: 28, second: 11, millisecond: 305), new TimeOnly(hour: 19, minute: 20, second: 14, millisecond: 308), new TimeOnly(hour: 16, minute: 12, second: 31, millisecond: 700), }, }, { { new TimeOnly(hour: 16, minute: 33, second: 3, millisecond: 685), new TimeOnly(hour: 11, minute: 14, second: 51, millisecond: 170), new TimeOnly(hour: 9, minute: 3, second: 58, millisecond: 25), }, { new TimeOnly(hour: 1, minute: 46, second: 17, millisecond: 505), new TimeOnly(hour: 4, minute: 24, second: 29, millisecond: 995), new TimeOnly(hour: 0, minute: 23, second: 43, millisecond: 764), }, { new TimeOnly(hour: 7, minute: 20, second: 56, millisecond: 641), new TimeOnly(hour: 5, minute: 29, second: 50, millisecond: 270), new TimeOnly(hour: 1, minute: 52, second: 23, millisecond: 599), }, }, { { new TimeOnly(hour: 6, minute: 30, second: 34, millisecond: 336), new TimeOnly(hour: 21, minute: 41, second: 0, millisecond: 819), new TimeOnly(hour: 3, minute: 47, second: 17, millisecond: 409), }, { new TimeOnly(hour: 1, minute: 50, second: 5, millisecond: 717), new TimeOnly(hour: 11, minute: 45, second: 13, millisecond: 282), new TimeOnly(hour: 21, minute: 30, second: 21, millisecond: 477), }, { new TimeOnly(hour: 7, minute: 56, second: 20, millisecond: 279), new TimeOnly(hour: 22, minute: 13, second: 6, millisecond: 31), new TimeOnly(hour: 2, minute: 56, second: 22, millisecond: 7), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 56,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 15, minute: 13, second: 14, millisecond: 180), new TimeOnly(hour: 14, minute: 13, second: 49, millisecond: 354), new TimeOnly(hour: 11, minute: 30, second: 49, millisecond: 281), }, { new TimeOnly(hour: 11, minute: 46, second: 19, millisecond: 976), new TimeOnly(hour: 20, minute: 43, second: 55, millisecond: 257), new TimeOnly(hour: 5, minute: 57, second: 38, millisecond: 24), }, { new TimeOnly(hour: 0, minute: 42, second: 36, millisecond: 358), new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 935), new TimeOnly(hour: 6, minute: 15, second: 46, millisecond: 637), }, }, { { new TimeOnly(hour: 6, minute: 55, second: 45, millisecond: 627), new TimeOnly(hour: 16, minute: 9, second: 28, millisecond: 719), new TimeOnly(hour: 15, minute: 29, second: 47, millisecond: 967), }, { new TimeOnly(hour: 0, minute: 58, second: 5, millisecond: 926), new TimeOnly(hour: 14, minute: 54, second: 49, millisecond: 671), new TimeOnly(hour: 11, minute: 53, second: 50, millisecond: 768), }, { new TimeOnly(hour: 11, minute: 4, second: 57, millisecond: 209), new TimeOnly(hour: 8, minute: 53, second: 22, millisecond: 816), new TimeOnly(hour: 15, minute: 12, second: 7, millisecond: 210), }, }, { { new TimeOnly(hour: 5, minute: 26, second: 56, millisecond: 126), new TimeOnly(hour: 0, minute: 20, second: 20, millisecond: 661), new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 746), }, { new TimeOnly(hour: 0, minute: 3, second: 21, millisecond: 993), new TimeOnly(hour: 18, minute: 29, second: 18, millisecond: 987), new TimeOnly(hour: 17, minute: 28, second: 6, millisecond: 754), }, { new TimeOnly(hour: 10, minute: 36, second: 36, millisecond: 541), new TimeOnly(hour: 22, minute: 26, second: 55, millisecond: 724), new TimeOnly(hour: 14, minute: 33, second: 33, millisecond: 691), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 34,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 18, second: 40, millisecond: 718), new TimeOnly(hour: 11, minute: 56, second: 52, millisecond: 296), new TimeOnly(hour: 15, minute: 39, second: 31, millisecond: 945), }, { new TimeOnly(hour: 0, minute: 33, second: 29, millisecond: 513), new TimeOnly(hour: 22, minute: 30, second: 5, millisecond: 550), new TimeOnly(hour: 9, minute: 15, second: 57, millisecond: 269), }, { new TimeOnly(hour: 1, minute: 2, second: 24, millisecond: 11), new TimeOnly(hour: 1, minute: 38, second: 46, millisecond: 428), new TimeOnly(hour: 19, minute: 57, second: 55, millisecond: 313), }, }, { { new TimeOnly(hour: 17, minute: 32, second: 54, millisecond: 17), new TimeOnly(hour: 17, minute: 14, second: 14, millisecond: 491), new TimeOnly(hour: 13, minute: 4, second: 0, millisecond: 166), }, { new TimeOnly(hour: 0, minute: 20, second: 44, millisecond: 883), new TimeOnly(hour: 8, minute: 47, second: 50, millisecond: 733), new TimeOnly(hour: 22, minute: 50, second: 54, millisecond: 932), }, { new TimeOnly(hour: 17, minute: 31, second: 25, millisecond: 996), new TimeOnly(hour: 14, minute: 54, second: 16, millisecond: 166), new TimeOnly(hour: 20, minute: 21, second: 51, millisecond: 136), }, }, { { new TimeOnly(hour: 8, minute: 22, second: 28, millisecond: 984), new TimeOnly(hour: 21, minute: 1, second: 37, millisecond: 280), new TimeOnly(hour: 4, minute: 25, second: 39, millisecond: 204), }, { new TimeOnly(hour: 10, minute: 9, second: 29, millisecond: 907), new TimeOnly(hour: 19, minute: 46, second: 15, millisecond: 131), new TimeOnly(hour: 10, minute: 5, second: 32, millisecond: 973), }, { new TimeOnly(hour: 8, minute: 8, second: 40, millisecond: 347), new TimeOnly(hour: 4, minute: 54, second: 22, millisecond: 5), new TimeOnly(hour: 5, minute: 30, second: 4, millisecond: 482), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 19, minute: 27, second: 7, millisecond: 884), new TimeOnly(hour: 4, minute: 9, second: 15, millisecond: 569), new TimeOnly(hour: 10, minute: 2, second: 2, millisecond: 130), }, { new TimeOnly(hour: 11, minute: 52, second: 48, millisecond: 258), new TimeOnly(hour: 13, minute: 19, second: 55, millisecond: 306), new TimeOnly(hour: 15, minute: 52, second: 31, millisecond: 950), }, { new TimeOnly(hour: 11, minute: 54, second: 4, millisecond: 136), new TimeOnly(hour: 17, minute: 28, second: 1, millisecond: 4), new TimeOnly(hour: 6, minute: 29, second: 52, millisecond: 961), }, }, { { new TimeOnly(hour: 5, minute: 16, second: 40, millisecond: 713), new TimeOnly(hour: 18, minute: 51, second: 45, millisecond: 510), new TimeOnly(hour: 11, minute: 0, second: 18, millisecond: 433), }, { new TimeOnly(hour: 13, minute: 13, second: 30, millisecond: 947), new TimeOnly(hour: 9, minute: 22, second: 49, millisecond: 927), new TimeOnly(hour: 2, minute: 54, second: 55, millisecond: 113), }, { new TimeOnly(hour: 6, minute: 21, second: 5, millisecond: 83), new TimeOnly(hour: 6, minute: 47, second: 32, millisecond: 31), new TimeOnly(hour: 1, minute: 42, second: 7, millisecond: 863), }, }, { { new TimeOnly(hour: 6, minute: 9, second: 4, millisecond: 317), new TimeOnly(hour: 14, minute: 42, second: 7, millisecond: 120), new TimeOnly(hour: 15, minute: 21, second: 33, millisecond: 381), }, { new TimeOnly(hour: 7, minute: 27, second: 7, millisecond: 886), new TimeOnly(hour: 13, minute: 37, second: 8, millisecond: 563), new TimeOnly(hour: 6, minute: 15, second: 8, millisecond: 961), }, { new TimeOnly(hour: 16, minute: 31, second: 28, millisecond: 590), new TimeOnly(hour: 7, minute: 9, second: 19, millisecond: 525), new TimeOnly(hour: 15, minute: 52, second: 47, millisecond: 484), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 62,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 40, second: 20, millisecond: 632), new TimeOnly(hour: 13, minute: 49, second: 32, millisecond: 938), new TimeOnly(hour: 22, minute: 9, second: 33, millisecond: 306), }, { new TimeOnly(hour: 9, minute: 18, second: 43, millisecond: 982), new TimeOnly(hour: 3, minute: 7, second: 18, millisecond: 698), new TimeOnly(hour: 6, minute: 55, second: 26, millisecond: 463), }, { new TimeOnly(hour: 22, minute: 10, second: 43, millisecond: 81), new TimeOnly(hour: 0, minute: 50, second: 20, millisecond: 358), new TimeOnly(hour: 1, minute: 38, second: 51, millisecond: 330), }, }, { { new TimeOnly(hour: 7, minute: 10, second: 11, millisecond: 909), new TimeOnly(hour: 21, minute: 20, second: 18, millisecond: 169), new TimeOnly(hour: 22, minute: 43, second: 8, millisecond: 351), }, { new TimeOnly(hour: 0, minute: 21, second: 47, millisecond: 699), new TimeOnly(hour: 10, minute: 34, second: 31, millisecond: 197), new TimeOnly(hour: 19, minute: 0, second: 29, millisecond: 713), }, { new TimeOnly(hour: 21, minute: 11, second: 26, millisecond: 879), new TimeOnly(hour: 1, minute: 23, second: 13, millisecond: 686), new TimeOnly(hour: 22, minute: 39, second: 26, millisecond: 800), }, }, { { new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 301), new TimeOnly(hour: 5, minute: 35, second: 43, millisecond: 198), new TimeOnly(hour: 10, minute: 40, second: 38, millisecond: 781), }, { new TimeOnly(hour: 14, minute: 43, second: 14, millisecond: 65), new TimeOnly(hour: 14, minute: 55, second: 37, millisecond: 167), new TimeOnly(hour: 12, minute: 55, second: 0, millisecond: 408), }, { new TimeOnly(hour: 0, minute: 6, second: 12, millisecond: 447), new TimeOnly(hour: 0, minute: 55, second: 24, millisecond: 591), new TimeOnly(hour: 11, minute: 4, second: 43, millisecond: 2), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 71,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 16, minute: 6, second: 18, millisecond: 286), new TimeOnly(hour: 8, minute: 17, second: 8, millisecond: 157), new TimeOnly(hour: 17, minute: 31, second: 57, millisecond: 812), }, { new TimeOnly(hour: 21, minute: 21, second: 9, millisecond: 757), new TimeOnly(hour: 14, minute: 7, second: 55, millisecond: 373), new TimeOnly(hour: 13, minute: 44, second: 22, millisecond: 637), }, { new TimeOnly(hour: 19, minute: 27, second: 33, millisecond: 892), new TimeOnly(hour: 22, minute: 53, second: 37, millisecond: 79), new TimeOnly(hour: 5, minute: 42, second: 39, millisecond: 628), }, }, { { new TimeOnly(hour: 16, minute: 48, second: 33, millisecond: 763), new TimeOnly(hour: 11, minute: 42, second: 58, millisecond: 955), new TimeOnly(hour: 21, minute: 19, second: 12, millisecond: 941), }, { new TimeOnly(hour: 14, minute: 56, second: 45, millisecond: 899), new TimeOnly(hour: 16, minute: 55, second: 36, millisecond: 524), new TimeOnly(hour: 22, minute: 38, second: 8, millisecond: 319), }, { new TimeOnly(hour: 19, minute: 19, second: 47, millisecond: 967), new TimeOnly(hour: 5, minute: 21, second: 2, millisecond: 245), new TimeOnly(hour: 14, minute: 14, second: 42, millisecond: 581), }, }, { { new TimeOnly(hour: 11, minute: 32, second: 23, millisecond: 155), new TimeOnly(hour: 16, minute: 52, second: 39, millisecond: 468), new TimeOnly(hour: 8, minute: 1, second: 36, millisecond: 491), }, { new TimeOnly(hour: 0, minute: 15, second: 55, millisecond: 30), new TimeOnly(hour: 14, minute: 15, second: 2, millisecond: 82), new TimeOnly(hour: 18, minute: 11, second: 34, millisecond: 318), }, { new TimeOnly(hour: 2, minute: 51, second: 46, millisecond: 941), new TimeOnly(hour: 1, minute: 12, second: 56, millisecond: 786), new TimeOnly(hour: 2, minute: 33, second: 26, millisecond: 356), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 35,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 8, minute: 1, second: 42, millisecond: 674), new TimeOnly(hour: 2, minute: 24, second: 51, millisecond: 551), new TimeOnly(hour: 8, minute: 49, second: 57, millisecond: 992), }, { new TimeOnly(hour: 5, minute: 43, second: 31, millisecond: 861), new TimeOnly(hour: 4, minute: 42, second: 16, millisecond: 300), new TimeOnly(hour: 13, minute: 27, second: 57, millisecond: 156), }, { new TimeOnly(hour: 11, minute: 54, second: 47, millisecond: 72), new TimeOnly(hour: 9, minute: 48, second: 23, millisecond: 75), new TimeOnly(hour: 13, minute: 52, second: 41, millisecond: 200), }, }, { { new TimeOnly(hour: 17, minute: 22, second: 47, millisecond: 366), new TimeOnly(hour: 9, minute: 43, second: 41, millisecond: 335), new TimeOnly(hour: 20, minute: 17, second: 17, millisecond: 278), }, { new TimeOnly(hour: 20, minute: 36, second: 1, millisecond: 417), new TimeOnly(hour: 2, minute: 26, second: 7, millisecond: 537), new TimeOnly(hour: 1, minute: 18, second: 5, millisecond: 561), }, { new TimeOnly(hour: 21, minute: 35, second: 0, millisecond: 383), new TimeOnly(hour: 1, minute: 12, second: 43, millisecond: 62), new TimeOnly(hour: 17, minute: 13, second: 11, millisecond: 462), }, }, { { new TimeOnly(hour: 1, minute: 11, second: 6, millisecond: 737), new TimeOnly(hour: 8, minute: 18, second: 33, millisecond: 608), new TimeOnly(hour: 9, minute: 56, second: 47, millisecond: 109), }, { new TimeOnly(hour: 5, minute: 9, second: 29, millisecond: 290), new TimeOnly(hour: 15, minute: 9, second: 17, millisecond: 784), new TimeOnly(hour: 9, minute: 42, second: 12, millisecond: 597), }, { new TimeOnly(hour: 1, minute: 55, second: 40, millisecond: 191), new TimeOnly(hour: 1, minute: 1, second: 56, millisecond: 585), new TimeOnly(hour: 19, minute: 31, second: 29, millisecond: 98), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 5, minute: 36, second: 46, millisecond: 991), new TimeOnly(hour: 9, minute: 50, second: 58, millisecond: 319), new TimeOnly(hour: 1, minute: 56, second: 19, millisecond: 403), }, { new TimeOnly(hour: 1, minute: 29, second: 13, millisecond: 945), new TimeOnly(hour: 1, minute: 55, second: 47, millisecond: 766), new TimeOnly(hour: 1, minute: 41, second: 46, millisecond: 651), }, { new TimeOnly(hour: 4, minute: 51, second: 41, millisecond: 976), new TimeOnly(hour: 12, minute: 49, second: 44, millisecond: 981), new TimeOnly(hour: 18, minute: 7, second: 39, millisecond: 197), }, }, { { new TimeOnly(hour: 17, minute: 50, second: 42, millisecond: 256), new TimeOnly(hour: 17, minute: 8, second: 7, millisecond: 673), new TimeOnly(hour: 14, minute: 10, second: 26, millisecond: 408), }, { new TimeOnly(hour: 22, minute: 29, second: 30, millisecond: 572), new TimeOnly(hour: 7, minute: 36, second: 34, millisecond: 317), new TimeOnly(hour: 5, minute: 2, second: 18, millisecond: 718), }, { new TimeOnly(hour: 12, minute: 45, second: 10, millisecond: 432), new TimeOnly(hour: 2, minute: 32, second: 34, millisecond: 813), new TimeOnly(hour: 9, minute: 35, second: 42, millisecond: 855), }, }, { { new TimeOnly(hour: 7, minute: 29, second: 5, millisecond: 959), new TimeOnly(hour: 2, minute: 45, second: 12, millisecond: 475), new TimeOnly(hour: 15, minute: 27, second: 32, millisecond: 827), }, { new TimeOnly(hour: 12, minute: 6, second: 8, millisecond: 384), new TimeOnly(hour: 16, minute: 5, second: 30, millisecond: 485), new TimeOnly(hour: 7, minute: 49, second: 33, millisecond: 75), }, { new TimeOnly(hour: 1, minute: 8, second: 30, millisecond: 417), new TimeOnly(hour: 13, minute: 38, second: 15, millisecond: 727), new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 787), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 22, minute: 10, second: 17, millisecond: 429), new TimeOnly(hour: 21, minute: 11, second: 6, millisecond: 783), new TimeOnly(hour: 3, minute: 5, second: 6, millisecond: 56), }, { new TimeOnly(hour: 0, minute: 28, second: 24, millisecond: 818), new TimeOnly(hour: 14, minute: 26, second: 30, millisecond: 750), new TimeOnly(hour: 21, minute: 4, second: 22, millisecond: 635), }, { new TimeOnly(hour: 10, minute: 54, second: 5, millisecond: 724), new TimeOnly(hour: 2, minute: 9, second: 54, millisecond: 930), new TimeOnly(hour: 12, minute: 31, second: 57, millisecond: 419), }, }, { { new TimeOnly(hour: 19, minute: 35, second: 17, millisecond: 703), new TimeOnly(hour: 16, minute: 55, second: 8, millisecond: 473), new TimeOnly(hour: 13, minute: 13, second: 35, millisecond: 223), }, { new TimeOnly(hour: 4, minute: 3, second: 24, millisecond: 506), new TimeOnly(hour: 17, minute: 20, second: 53, millisecond: 763), new TimeOnly(hour: 14, minute: 27, second: 25, millisecond: 326), }, { new TimeOnly(hour: 1, minute: 50, second: 4, millisecond: 45), new TimeOnly(hour: 1, minute: 40, second: 43, millisecond: 352), new TimeOnly(hour: 19, minute: 21, second: 12, millisecond: 76), }, }, { { new TimeOnly(hour: 9, minute: 58, second: 38, millisecond: 991), new TimeOnly(hour: 3, minute: 36, second: 40, millisecond: 307), new TimeOnly(hour: 1, minute: 5, second: 14, millisecond: 298), }, { new TimeOnly(hour: 14, minute: 3, second: 26, millisecond: 502), new TimeOnly(hour: 9, minute: 44, second: 47, millisecond: 713), new TimeOnly(hour: 21, minute: 11, second: 9, millisecond: 657), }, { new TimeOnly(hour: 2, minute: 41, second: 10, millisecond: 479), new TimeOnly(hour: 15, minute: 10, second: 10, millisecond: 285), new TimeOnly(hour: 18, minute: 43, second: 49, millisecond: 181), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 77,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 19, minute: 55, second: 54, millisecond: 695), new TimeOnly(hour: 0, minute: 41, second: 33, millisecond: 163), new TimeOnly(hour: 5, minute: 0, second: 33, millisecond: 724), }, { new TimeOnly(hour: 22, minute: 32, second: 33, millisecond: 103), new TimeOnly(hour: 4, minute: 42, second: 18, millisecond: 77), new TimeOnly(hour: 12, minute: 51, second: 49, millisecond: 430), }, { new TimeOnly(hour: 5, minute: 34, second: 16, millisecond: 836), new TimeOnly(hour: 7, minute: 38, second: 10, millisecond: 769), new TimeOnly(hour: 0, minute: 57, second: 1, millisecond: 935), }, }, { { new TimeOnly(hour: 13, minute: 14, second: 52, millisecond: 505), new TimeOnly(hour: 0, minute: 1, second: 43, millisecond: 266), new TimeOnly(hour: 12, minute: 56, second: 18, millisecond: 644), }, { new TimeOnly(hour: 14, minute: 26, second: 24, millisecond: 10), new TimeOnly(hour: 17, minute: 43, second: 32, millisecond: 959), new TimeOnly(hour: 6, minute: 51, second: 18, millisecond: 391), }, { new TimeOnly(hour: 6, minute: 12, second: 30, millisecond: 113), new TimeOnly(hour: 1, minute: 23, second: 49, millisecond: 625), new TimeOnly(hour: 9, minute: 36, second: 36, millisecond: 57), }, }, { { new TimeOnly(hour: 22, minute: 29, second: 30, millisecond: 980), new TimeOnly(hour: 11, minute: 45, second: 6, millisecond: 256), new TimeOnly(hour: 21, minute: 28, second: 28, millisecond: 781), }, { new TimeOnly(hour: 5, minute: 58, second: 37, millisecond: 775), new TimeOnly(hour: 3, minute: 10, second: 43, millisecond: 926), new TimeOnly(hour: 9, minute: 12, second: 51, millisecond: 327), }, { new TimeOnly(hour: 3, minute: 14, second: 23, millisecond: 332), new TimeOnly(hour: 11, minute: 25, second: 56, millisecond: 550), new TimeOnly(hour: 20, minute: 23, second: 33, millisecond: 555), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 10, minute: 6, second: 21, millisecond: 289), new TimeOnly(hour: 21, minute: 56, second: 50, millisecond: 652), new TimeOnly(hour: 6, minute: 2, second: 30, millisecond: 9), }, { new TimeOnly(hour: 9, minute: 34, second: 8, millisecond: 861), new TimeOnly(hour: 17, minute: 29, second: 56, millisecond: 357), new TimeOnly(hour: 5, minute: 9, second: 37, millisecond: 283), }, { new TimeOnly(hour: 16, minute: 54, second: 11, millisecond: 735), new TimeOnly(hour: 4, minute: 1, second: 1, millisecond: 907), new TimeOnly(hour: 21, minute: 30, second: 39, millisecond: 126), }, }, { { new TimeOnly(hour: 14, minute: 39, second: 57, millisecond: 879), new TimeOnly(hour: 6, minute: 8, second: 45, millisecond: 903), new TimeOnly(hour: 22, minute: 44, second: 16, millisecond: 102), }, { new TimeOnly(hour: 16, minute: 48, second: 19, millisecond: 283), new TimeOnly(hour: 1, minute: 33, second: 2, millisecond: 912), new TimeOnly(hour: 21, minute: 37, second: 32, millisecond: 553), }, { new TimeOnly(hour: 16, minute: 45, second: 5, millisecond: 792), new TimeOnly(hour: 16, minute: 40, second: 56, millisecond: 728), new TimeOnly(hour: 13, minute: 41, second: 20, millisecond: 89), }, }, { { new TimeOnly(hour: 11, minute: 27, second: 36, millisecond: 611), new TimeOnly(hour: 7, minute: 44, second: 15, millisecond: 250), new TimeOnly(hour: 17, minute: 4, second: 44, millisecond: 827), }, { new TimeOnly(hour: 11, minute: 32, second: 55, millisecond: 983), new TimeOnly(hour: 20, minute: 12, second: 14, millisecond: 812), new TimeOnly(hour: 2, minute: 33, second: 30, millisecond: 671), }, { new TimeOnly(hour: 11, minute: 47, second: 12, millisecond: 417), new TimeOnly(hour: 13, minute: 11, second: 30, millisecond: 147), new TimeOnly(hour: 19, minute: 29, second: 23, millisecond: 850), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 78,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 11, second: 10, millisecond: 611), new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 644), new TimeOnly(hour: 19, minute: 18, second: 38, millisecond: 775), }, { new TimeOnly(hour: 5, minute: 21, second: 1, millisecond: 304), new TimeOnly(hour: 16, minute: 45, second: 33, millisecond: 221), new TimeOnly(hour: 5, minute: 47, second: 53, millisecond: 730), }, { new TimeOnly(hour: 19, minute: 47, second: 43, millisecond: 821), new TimeOnly(hour: 12, minute: 52, second: 20, millisecond: 683), new TimeOnly(hour: 21, minute: 55, second: 32, millisecond: 243), }, }, { { new TimeOnly(hour: 2, minute: 12, second: 12, millisecond: 495), new TimeOnly(hour: 2, minute: 2, second: 44, millisecond: 368), new TimeOnly(hour: 0, minute: 33, second: 7, millisecond: 468), }, { new TimeOnly(hour: 19, minute: 47, second: 25, millisecond: 273), new TimeOnly(hour: 5, minute: 9, second: 57, millisecond: 548), new TimeOnly(hour: 1, minute: 34, second: 21, millisecond: 570), }, { new TimeOnly(hour: 5, minute: 41, second: 5, millisecond: 893), new TimeOnly(hour: 14, minute: 27, second: 33, millisecond: 921), new TimeOnly(hour: 21, minute: 53, second: 18, millisecond: 128), }, }, { { new TimeOnly(hour: 15, minute: 51, second: 47, millisecond: 188), new TimeOnly(hour: 12, minute: 42, second: 46, millisecond: 289), new TimeOnly(hour: 9, minute: 24, second: 47, millisecond: 569), }, { new TimeOnly(hour: 15, minute: 35, second: 15, millisecond: 630), new TimeOnly(hour: 14, minute: 44, second: 1, millisecond: 932), new TimeOnly(hour: 18, minute: 32, second: 12, millisecond: 280), }, { new TimeOnly(hour: 6, minute: 45, second: 35, millisecond: 709), new TimeOnly(hour: 21, minute: 24, second: 11, millisecond: 367), new TimeOnly(hour: 4, minute: 38, second: 34, millisecond: 46), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 42,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 11, minute: 22, second: 12, millisecond: 213), new TimeOnly(hour: 15, minute: 33, second: 56, millisecond: 992), new TimeOnly(hour: 14, minute: 39, second: 57, millisecond: 342), }, { new TimeOnly(hour: 9, minute: 9, second: 53, millisecond: 292), new TimeOnly(hour: 4, minute: 56, second: 31, millisecond: 344), new TimeOnly(hour: 1, minute: 9, second: 13, millisecond: 681), }, { new TimeOnly(hour: 4, minute: 18, second: 55, millisecond: 868), new TimeOnly(hour: 7, minute: 33, second: 51, millisecond: 927), new TimeOnly(hour: 7, minute: 28, second: 11, millisecond: 299), }, }, { { new TimeOnly(hour: 19, minute: 49, second: 49, millisecond: 146), new TimeOnly(hour: 16, minute: 18, second: 26, millisecond: 114), new TimeOnly(hour: 13, minute: 18, second: 47, millisecond: 201), }, { new TimeOnly(hour: 8, minute: 30, second: 8, millisecond: 351), new TimeOnly(hour: 12, minute: 21, second: 35, millisecond: 955), new TimeOnly(hour: 18, minute: 41, second: 33, millisecond: 575), }, { new TimeOnly(hour: 16, minute: 34, second: 32, millisecond: 160), new TimeOnly(hour: 22, minute: 6, second: 30, millisecond: 192), new TimeOnly(hour: 19, minute: 24, second: 12, millisecond: 324), }, }, { { new TimeOnly(hour: 22, minute: 48, second: 50, millisecond: 715), new TimeOnly(hour: 11, minute: 25, second: 15, millisecond: 631), new TimeOnly(hour: 8, minute: 9, second: 5, millisecond: 882), }, { new TimeOnly(hour: 22, minute: 33, second: 25, millisecond: 785), new TimeOnly(hour: 18, minute: 37, second: 32, millisecond: 437), new TimeOnly(hour: 19, minute: 43, second: 31, millisecond: 695), }, { new TimeOnly(hour: 11, minute: 4, second: 41, millisecond: 320), new TimeOnly(hour: 15, minute: 5, second: 12, millisecond: 666), new TimeOnly(hour: 5, minute: 6, second: 52, millisecond: 565), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 6, minute: 10, second: 29, millisecond: 686), new TimeOnly(hour: 2, minute: 48, second: 31, millisecond: 33), new TimeOnly(hour: 18, minute: 3, second: 38, millisecond: 846), }, { new TimeOnly(hour: 22, minute: 37, second: 36, millisecond: 312), new TimeOnly(hour: 14, minute: 33, second: 32, millisecond: 258), new TimeOnly(hour: 22, minute: 5, second: 18, millisecond: 153), }, { new TimeOnly(hour: 15, minute: 30, second: 56, millisecond: 913), new TimeOnly(hour: 11, minute: 49, second: 25, millisecond: 941), new TimeOnly(hour: 14, minute: 8, second: 0, millisecond: 355), }, }, { { new TimeOnly(hour: 20, minute: 49, second: 2, millisecond: 392), new TimeOnly(hour: 6, minute: 19, second: 35, millisecond: 465), new TimeOnly(hour: 22, minute: 53, second: 47, millisecond: 335), }, { new TimeOnly(hour: 2, minute: 29, second: 21, millisecond: 643), new TimeOnly(hour: 4, minute: 11, second: 6, millisecond: 594), new TimeOnly(hour: 8, minute: 25, second: 19, millisecond: 866), }, { new TimeOnly(hour: 12, minute: 30, second: 17, millisecond: 640), new TimeOnly(hour: 18, minute: 3, second: 24, millisecond: 831), new TimeOnly(hour: 21, minute: 24, second: 3, millisecond: 278), }, }, { { new TimeOnly(hour: 9, minute: 25, second: 3, millisecond: 223), new TimeOnly(hour: 17, minute: 8, second: 16, millisecond: 782), new TimeOnly(hour: 14, minute: 16, second: 46, millisecond: 679), }, { new TimeOnly(hour: 21, minute: 20, second: 52, millisecond: 593), new TimeOnly(hour: 4, minute: 37, second: 36, millisecond: 835), new TimeOnly(hour: 5, minute: 29, second: 57, millisecond: 398), }, { new TimeOnly(hour: 15, minute: 13, second: 24, millisecond: 991), new TimeOnly(hour: 3, minute: 27, second: 24, millisecond: 549), new TimeOnly(hour: 0, minute: 49, second: 16, millisecond: 411), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 27, second: 37, millisecond: 491), new TimeOnly(hour: 12, minute: 26, second: 37, millisecond: 92), new TimeOnly(hour: 22, minute: 22, second: 32, millisecond: 128), }, { new TimeOnly(hour: 7, minute: 32, second: 54, millisecond: 732), new TimeOnly(hour: 1, minute: 10, second: 25, millisecond: 86), new TimeOnly(hour: 8, minute: 11, second: 26, millisecond: 883), }, { new TimeOnly(hour: 7, minute: 15, second: 17, millisecond: 976), new TimeOnly(hour: 5, minute: 35, second: 7, millisecond: 914), new TimeOnly(hour: 11, minute: 13, second: 48, millisecond: 559), }, }, { { new TimeOnly(hour: 16, minute: 3, second: 58, millisecond: 717), new TimeOnly(hour: 16, minute: 29, second: 17, millisecond: 656), new TimeOnly(hour: 16, minute: 46, second: 33, millisecond: 765), }, { new TimeOnly(hour: 0, minute: 7, second: 10, millisecond: 652), new TimeOnly(hour: 13, minute: 57, second: 57, millisecond: 994), new TimeOnly(hour: 4, minute: 13, second: 14, millisecond: 347), }, { new TimeOnly(hour: 8, minute: 10, second: 29, millisecond: 377), new TimeOnly(hour: 17, minute: 18, second: 36, millisecond: 496), new TimeOnly(hour: 0, minute: 35, second: 22, millisecond: 320), }, }, { { new TimeOnly(hour: 17, minute: 29, second: 4, millisecond: 564), new TimeOnly(hour: 5, minute: 58, second: 26, millisecond: 378), new TimeOnly(hour: 20, minute: 27, second: 1, millisecond: 156), }, { new TimeOnly(hour: 4, minute: 47, second: 48, millisecond: 520), new TimeOnly(hour: 17, minute: 38, second: 31, millisecond: 365), new TimeOnly(hour: 17, minute: 40, second: 5, millisecond: 330), }, { new TimeOnly(hour: 11, minute: 20, second: 14, millisecond: 67), new TimeOnly(hour: 6, minute: 40, second: 57, millisecond: 343), new TimeOnly(hour: 0, minute: 22, second: 53, millisecond: 879), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 82,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 11, minute: 29, second: 57, millisecond: 241), new TimeOnly(hour: 14, minute: 1, second: 2, millisecond: 507), new TimeOnly(hour: 20, minute: 45, second: 22, millisecond: 273), }, { new TimeOnly(hour: 12, minute: 8, second: 4, millisecond: 743), new TimeOnly(hour: 6, minute: 20, second: 9, millisecond: 462), new TimeOnly(hour: 22, minute: 57, second: 33, millisecond: 751), }, { new TimeOnly(hour: 19, minute: 56, second: 22, millisecond: 107), new TimeOnly(hour: 5, minute: 48, second: 6, millisecond: 575), new TimeOnly(hour: 16, minute: 5, second: 15, millisecond: 373), }, }, { { new TimeOnly(hour: 15, minute: 31, second: 25, millisecond: 156), new TimeOnly(hour: 12, minute: 9, second: 52, millisecond: 962), new TimeOnly(hour: 1, minute: 45, second: 33, millisecond: 716), }, { new TimeOnly(hour: 8, minute: 56, second: 11, millisecond: 793), new TimeOnly(hour: 1, minute: 41, second: 36, millisecond: 924), new TimeOnly(hour: 7, minute: 50, second: 21, millisecond: 474), }, { new TimeOnly(hour: 12, minute: 46, second: 33, millisecond: 532), new TimeOnly(hour: 1, minute: 29, second: 46, millisecond: 155), new TimeOnly(hour: 20, minute: 25, second: 14, millisecond: 819), }, }, { { new TimeOnly(hour: 22, minute: 4, second: 16, millisecond: 284), new TimeOnly(hour: 2, minute: 38, second: 45, millisecond: 720), new TimeOnly(hour: 20, minute: 35, second: 13, millisecond: 234), }, { new TimeOnly(hour: 2, minute: 9, second: 26, millisecond: 717), new TimeOnly(hour: 1, minute: 52, second: 26, millisecond: 709), new TimeOnly(hour: 20, minute: 0, second: 21, millisecond: 480), }, { new TimeOnly(hour: 10, minute: 57, second: 15, millisecond: 379), new TimeOnly(hour: 18, minute: 47, second: 24, millisecond: 836), new TimeOnly(hour: 19, minute: 10, second: 31, millisecond: 297), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 84,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 22, second: 9, millisecond: 801), new TimeOnly(hour: 15, minute: 15, second: 28, millisecond: 245), new TimeOnly(hour: 15, minute: 43, second: 19, millisecond: 227), }, { new TimeOnly(hour: 5, minute: 55, second: 25, millisecond: 348), new TimeOnly(hour: 22, minute: 42, second: 54, millisecond: 217), new TimeOnly(hour: 10, minute: 10, second: 28, millisecond: 335), }, { new TimeOnly(hour: 14, minute: 15, second: 43, millisecond: 436), new TimeOnly(hour: 21, minute: 38, second: 0, millisecond: 323), new TimeOnly(hour: 12, minute: 41, second: 49, millisecond: 4), }, }, { { new TimeOnly(hour: 5, minute: 38, second: 36, millisecond: 803), new TimeOnly(hour: 18, minute: 1, second: 27, millisecond: 909), new TimeOnly(hour: 8, minute: 42, second: 42, millisecond: 630), }, { new TimeOnly(hour: 7, minute: 34, second: 57, millisecond: 868), new TimeOnly(hour: 10, minute: 28, second: 31, millisecond: 358), new TimeOnly(hour: 8, minute: 38, second: 58, millisecond: 767), }, { new TimeOnly(hour: 21, minute: 41, second: 3, millisecond: 477), new TimeOnly(hour: 12, minute: 12, second: 15, millisecond: 30), new TimeOnly(hour: 2, minute: 22, second: 40, millisecond: 913), }, }, { { new TimeOnly(hour: 21, minute: 10, second: 55, millisecond: 674), new TimeOnly(hour: 21, minute: 54, second: 40, millisecond: 169), new TimeOnly(hour: 12, minute: 10, second: 49, millisecond: 261), }, { new TimeOnly(hour: 13, minute: 26, second: 30, millisecond: 219), new TimeOnly(hour: 21, minute: 26, second: 23, millisecond: 371), new TimeOnly(hour: 18, minute: 46, second: 58, millisecond: 800), }, { new TimeOnly(hour: 14, minute: 1, second: 49, millisecond: 379), new TimeOnly(hour: 17, minute: 49, second: 26, millisecond: 965), new TimeOnly(hour: 21, minute: 54, second: 44, millisecond: 251), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 49,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 0, minute: 17, second: 58, millisecond: 498), new TimeOnly(hour: 3, minute: 56, second: 32, millisecond: 281), new TimeOnly(hour: 14, minute: 23, second: 6, millisecond: 423), }, { new TimeOnly(hour: 18, minute: 6, second: 45, millisecond: 800), new TimeOnly(hour: 17, minute: 13, second: 6, millisecond: 622), new TimeOnly(hour: 10, minute: 45, second: 2, millisecond: 668), }, { new TimeOnly(hour: 21, minute: 36, second: 7, millisecond: 533), new TimeOnly(hour: 18, minute: 23, second: 47, millisecond: 145), new TimeOnly(hour: 15, minute: 37, second: 50, millisecond: 819), }, }, { { new TimeOnly(hour: 22, minute: 12, second: 13, millisecond: 225), new TimeOnly(hour: 16, minute: 25, second: 18, millisecond: 815), new TimeOnly(hour: 7, minute: 39, second: 17, millisecond: 484), }, { new TimeOnly(hour: 20, minute: 3, second: 50, millisecond: 25), new TimeOnly(hour: 22, minute: 46, second: 4, millisecond: 591), new TimeOnly(hour: 2, minute: 54, second: 19, millisecond: 487), }, { new TimeOnly(hour: 6, minute: 30, second: 0, millisecond: 926), new TimeOnly(hour: 20, minute: 36, second: 23, millisecond: 548), new TimeOnly(hour: 20, minute: 6, second: 15, millisecond: 596), }, }, { { new TimeOnly(hour: 15, minute: 23, second: 7, millisecond: 563), new TimeOnly(hour: 14, minute: 58, second: 53, millisecond: 78), new TimeOnly(hour: 5, minute: 4, second: 5, millisecond: 915), }, { new TimeOnly(hour: 10, minute: 7, second: 3, millisecond: 751), new TimeOnly(hour: 9, minute: 17, second: 1, millisecond: 32), new TimeOnly(hour: 3, minute: 48, second: 47, millisecond: 124), }, { new TimeOnly(hour: 10, minute: 56, second: 53, millisecond: 15), new TimeOnly(hour: 0, minute: 17, second: 27, millisecond: 657), new TimeOnly(hour: 18, minute: 49, second: 3, millisecond: 734), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 16, minute: 44, second: 17, millisecond: 531), new TimeOnly(hour: 7, minute: 4, second: 45, millisecond: 318), new TimeOnly(hour: 21, minute: 57, second: 1, millisecond: 1), }, { new TimeOnly(hour: 9, minute: 29, second: 43, millisecond: 893), new TimeOnly(hour: 19, minute: 8, second: 20, millisecond: 896), new TimeOnly(hour: 7, minute: 12, second: 18, millisecond: 739), }, { new TimeOnly(hour: 2, minute: 23, second: 53, millisecond: 654), new TimeOnly(hour: 12, minute: 56, second: 42, millisecond: 423), new TimeOnly(hour: 4, minute: 56, second: 52, millisecond: 286), }, }, { { new TimeOnly(hour: 19, minute: 10, second: 49, millisecond: 584), new TimeOnly(hour: 21, minute: 36, second: 45, millisecond: 568), new TimeOnly(hour: 19, minute: 4, second: 36, millisecond: 611), }, { new TimeOnly(hour: 9, minute: 1, second: 8, millisecond: 315), new TimeOnly(hour: 17, minute: 14, second: 0, millisecond: 546), new TimeOnly(hour: 4, minute: 53, second: 40, millisecond: 297), }, { new TimeOnly(hour: 11, minute: 46, second: 21, millisecond: 780), new TimeOnly(hour: 3, minute: 27, second: 45, millisecond: 569), new TimeOnly(hour: 9, minute: 14, second: 45, millisecond: 463), }, }, { { new TimeOnly(hour: 13, minute: 35, second: 36, millisecond: 712), new TimeOnly(hour: 12, minute: 40, second: 48, millisecond: 899), new TimeOnly(hour: 9, minute: 56, second: 52, millisecond: 747), }, { new TimeOnly(hour: 19, minute: 0, second: 56, millisecond: 929), new TimeOnly(hour: 19, minute: 47, second: 36, millisecond: 228), new TimeOnly(hour: 11, minute: 31, second: 4, millisecond: 99), }, { new TimeOnly(hour: 2, minute: 9, second: 17, millisecond: 432), new TimeOnly(hour: 9, minute: 57, second: 52, millisecond: 583), new TimeOnly(hour: 15, minute: 45, second: 14, millisecond: 564), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 6, minute: 40, second: 54, millisecond: 355), new TimeOnly(hour: 10, minute: 6, second: 45, millisecond: 372), new TimeOnly(hour: 3, minute: 11, second: 10, millisecond: 286), }, { new TimeOnly(hour: 1, minute: 56, second: 12, millisecond: 107), new TimeOnly(hour: 9, minute: 37, second: 48, millisecond: 524), new TimeOnly(hour: 8, minute: 44, second: 26, millisecond: 571), }, { new TimeOnly(hour: 20, minute: 51, second: 3, millisecond: 938), new TimeOnly(hour: 20, minute: 13, second: 25, millisecond: 177), new TimeOnly(hour: 9, minute: 45, second: 35, millisecond: 827), }, }, { { new TimeOnly(hour: 6, minute: 2, second: 19, millisecond: 632), new TimeOnly(hour: 9, minute: 23, second: 35, millisecond: 832), new TimeOnly(hour: 7, minute: 33, second: 36, millisecond: 35), }, { new TimeOnly(hour: 6, minute: 9, second: 19, millisecond: 264), new TimeOnly(hour: 1, minute: 48, second: 9, millisecond: 741), new TimeOnly(hour: 4, minute: 30, second: 9, millisecond: 293), }, { new TimeOnly(hour: 8, minute: 11, second: 25, millisecond: 240), new TimeOnly(hour: 15, minute: 33, second: 13, millisecond: 810), new TimeOnly(hour: 7, minute: 12, second: 18, millisecond: 110), }, }, { { new TimeOnly(hour: 4, minute: 28, second: 47, millisecond: 901), new TimeOnly(hour: 20, minute: 46, second: 50, millisecond: 222), new TimeOnly(hour: 18, minute: 7, second: 35, millisecond: 238), }, { new TimeOnly(hour: 22, minute: 14, second: 47, millisecond: 170), new TimeOnly(hour: 6, minute: 28, second: 2, millisecond: 588), new TimeOnly(hour: 1, minute: 1, second: 37, millisecond: 294), }, { new TimeOnly(hour: 4, minute: 31, second: 6, millisecond: 697), new TimeOnly(hour: 20, minute: 34, second: 38, millisecond: 537), new TimeOnly(hour: 7, minute: 53, second: 41, millisecond: 504), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 13, minute: 37, second: 13, millisecond: 37), new TimeOnly(hour: 0, minute: 4, second: 44, millisecond: 592), new TimeOnly(hour: 19, minute: 2, second: 19, millisecond: 928), }, { new TimeOnly(hour: 11, minute: 18, second: 4, millisecond: 715), new TimeOnly(hour: 21, minute: 38, second: 42, millisecond: 428), new TimeOnly(hour: 20, minute: 3, second: 16, millisecond: 520), }, { new TimeOnly(hour: 5, minute: 14, second: 7, millisecond: 60), new TimeOnly(hour: 12, minute: 6, second: 30, millisecond: 644), new TimeOnly(hour: 15, minute: 48, second: 40, millisecond: 871), }, }, { { new TimeOnly(hour: 2, minute: 18, second: 50, millisecond: 357), new TimeOnly(hour: 8, minute: 29, second: 14, millisecond: 693), new TimeOnly(hour: 5, minute: 35, second: 27, millisecond: 886), }, { new TimeOnly(hour: 21, minute: 57, second: 41, millisecond: 314), new TimeOnly(hour: 18, minute: 40, second: 56, millisecond: 11), new TimeOnly(hour: 8, minute: 0, second: 12, millisecond: 40), }, { new TimeOnly(hour: 5, minute: 33, second: 48, millisecond: 1), new TimeOnly(hour: 21, minute: 0, second: 52, millisecond: 670), new TimeOnly(hour: 14, minute: 54, second: 9, millisecond: 260), }, }, { { new TimeOnly(hour: 18, minute: 42, second: 24, millisecond: 853), new TimeOnly(hour: 21, minute: 46, second: 37, millisecond: 272), new TimeOnly(hour: 20, minute: 49, second: 46, millisecond: 906), }, { new TimeOnly(hour: 11, minute: 50, second: 35, millisecond: 941), new TimeOnly(hour: 14, minute: 20, second: 37, millisecond: 372), new TimeOnly(hour: 1, minute: 30, second: 35, millisecond: 594), }, { new TimeOnly(hour: 4, minute: 43, second: 3, millisecond: 254), new TimeOnly(hour: 13, minute: 57, second: 10, millisecond: 450), new TimeOnly(hour: 19, minute: 46, second: 16, millisecond: 711), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 91,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 7, minute: 52, second: 28, millisecond: 804), new TimeOnly(hour: 7, minute: 3, second: 4, millisecond: 314), new TimeOnly(hour: 7, minute: 12, second: 38, millisecond: 225), }, { new TimeOnly(hour: 11, minute: 52, second: 41, millisecond: 239), new TimeOnly(hour: 20, minute: 3, second: 11, millisecond: 382), new TimeOnly(hour: 10, minute: 52, second: 2, millisecond: 477), }, { new TimeOnly(hour: 1, minute: 24, second: 31, millisecond: 52), new TimeOnly(hour: 12, minute: 24, second: 27, millisecond: 70), new TimeOnly(hour: 19, minute: 13, second: 51, millisecond: 729), }, }, { { new TimeOnly(hour: 15, minute: 21, second: 56, millisecond: 154), new TimeOnly(hour: 19, minute: 10, second: 12, millisecond: 739), new TimeOnly(hour: 8, minute: 45, second: 0, millisecond: 41), }, { new TimeOnly(hour: 17, minute: 16, second: 39, millisecond: 40), new TimeOnly(hour: 21, minute: 17, second: 50, millisecond: 801), new TimeOnly(hour: 20, minute: 37, second: 32, millisecond: 92), }, { new TimeOnly(hour: 16, minute: 17, second: 15, millisecond: 311), new TimeOnly(hour: 10, minute: 42, second: 3, millisecond: 35), new TimeOnly(hour: 3, minute: 22, second: 43, millisecond: 601), }, }, { { new TimeOnly(hour: 14, minute: 32, second: 11, millisecond: 8), new TimeOnly(hour: 2, minute: 46, second: 1, millisecond: 384), new TimeOnly(hour: 14, minute: 18, second: 12, millisecond: 2), }, { new TimeOnly(hour: 18, minute: 34, second: 4, millisecond: 10), new TimeOnly(hour: 3, minute: 23, second: 11, millisecond: 856), new TimeOnly(hour: 7, minute: 46, second: 47, millisecond: 923), }, { new TimeOnly(hour: 8, minute: 2, second: 25, millisecond: 744), new TimeOnly(hour: 16, minute: 27, second: 14, millisecond: 21), new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 877), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 53,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 14, minute: 27, second: 12, millisecond: 200), new TimeOnly(hour: 3, minute: 38, second: 4, millisecond: 742), new TimeOnly(hour: 6, minute: 43, second: 47, millisecond: 498), }, { new TimeOnly(hour: 21, minute: 55, second: 15, millisecond: 908), new TimeOnly(hour: 19, minute: 3, second: 11, millisecond: 898), new TimeOnly(hour: 4, minute: 26, second: 9, millisecond: 606), }, { new TimeOnly(hour: 17, minute: 42, second: 35, millisecond: 986), new TimeOnly(hour: 3, minute: 4, second: 20, millisecond: 805), new TimeOnly(hour: 18, minute: 54, second: 55, millisecond: 168), }, }, { { new TimeOnly(hour: 11, minute: 14, second: 52, millisecond: 560), new TimeOnly(hour: 1, minute: 15, second: 14, millisecond: 475), new TimeOnly(hour: 10, minute: 41, second: 50, millisecond: 84), }, { new TimeOnly(hour: 3, minute: 23, second: 55, millisecond: 396), new TimeOnly(hour: 6, minute: 40, second: 6, millisecond: 561), new TimeOnly(hour: 5, minute: 8, second: 22, millisecond: 748), }, { new TimeOnly(hour: 1, minute: 46, second: 32, millisecond: 307), new TimeOnly(hour: 2, minute: 19, second: 17, millisecond: 362), new TimeOnly(hour: 22, minute: 29, second: 29, millisecond: 705), }, }, { { new TimeOnly(hour: 2, minute: 26, second: 13, millisecond: 609), new TimeOnly(hour: 1, minute: 38, second: 38, millisecond: 634), new TimeOnly(hour: 17, minute: 43, second: 1, millisecond: 210), }, { new TimeOnly(hour: 21, minute: 1, second: 42, millisecond: 199), new TimeOnly(hour: 4, minute: 40, second: 24, millisecond: 755), new TimeOnly(hour: 16, minute: 36, second: 53, millisecond: 203), }, { new TimeOnly(hour: 7, minute: 28, second: 58, millisecond: 160), new TimeOnly(hour: 18, minute: 42, second: 57, millisecond: 896), new TimeOnly(hour: 4, minute: 47, second: 3, millisecond: 251), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 11, second: 55, millisecond: 518), new TimeOnly(hour: 15, minute: 33, second: 45, millisecond: 868), new TimeOnly(hour: 20, minute: 52, second: 50, millisecond: 374), }, { new TimeOnly(hour: 18, minute: 19, second: 58, millisecond: 896), new TimeOnly(hour: 8, minute: 42, second: 41, millisecond: 412), new TimeOnly(hour: 0, minute: 3, second: 26, millisecond: 950), }, { new TimeOnly(hour: 18, minute: 58, second: 52, millisecond: 821), new TimeOnly(hour: 15, minute: 51, second: 18, millisecond: 875), new TimeOnly(hour: 10, minute: 38, second: 2, millisecond: 132), }, }, { { new TimeOnly(hour: 5, minute: 24, second: 36, millisecond: 586), new TimeOnly(hour: 7, minute: 2, second: 12, millisecond: 94), new TimeOnly(hour: 14, minute: 44, second: 43, millisecond: 963), }, { new TimeOnly(hour: 21, minute: 40, second: 43, millisecond: 4), new TimeOnly(hour: 2, minute: 4, second: 1, millisecond: 565), new TimeOnly(hour: 13, minute: 48, second: 5, millisecond: 701), }, { new TimeOnly(hour: 14, minute: 51, second: 20, millisecond: 700), new TimeOnly(hour: 8, minute: 46, second: 29, millisecond: 147), new TimeOnly(hour: 11, minute: 3, second: 25, millisecond: 170), }, }, { { new TimeOnly(hour: 15, minute: 29, second: 23, millisecond: 115), new TimeOnly(hour: 9, minute: 42, second: 50, millisecond: 985), new TimeOnly(hour: 9, minute: 20, second: 2, millisecond: 181), }, { new TimeOnly(hour: 0, minute: 9, second: 18, millisecond: 119), new TimeOnly(hour: 0, minute: 51, second: 1, millisecond: 18), new TimeOnly(hour: 4, minute: 35, second: 43, millisecond: 785), }, { new TimeOnly(hour: 13, minute: 15, second: 19, millisecond: 470), new TimeOnly(hour: 16, minute: 2, second: 49, millisecond: 16), new TimeOnly(hour: 7, minute: 25, second: 35, millisecond: 185), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 94,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 3, minute: 17, second: 17, millisecond: 167), new TimeOnly(hour: 17, minute: 48, second: 35, millisecond: 702), new TimeOnly(hour: 21, minute: 51, second: 28, millisecond: 545), }, { new TimeOnly(hour: 9, minute: 9, second: 16, millisecond: 240), new TimeOnly(hour: 9, minute: 14, second: 37, millisecond: 236), new TimeOnly(hour: 21, minute: 1, second: 34, millisecond: 798), }, { new TimeOnly(hour: 13, minute: 39, second: 10, millisecond: 6), new TimeOnly(hour: 12, minute: 28, second: 29, millisecond: 88), new TimeOnly(hour: 16, minute: 47, second: 17, millisecond: 242), }, }, { { new TimeOnly(hour: 15, minute: 51, second: 0, millisecond: 935), new TimeOnly(hour: 16, minute: 55, second: 7, millisecond: 385), new TimeOnly(hour: 18, minute: 50, second: 55, millisecond: 979), }, { new TimeOnly(hour: 3, minute: 32, second: 4, millisecond: 786), new TimeOnly(hour: 15, minute: 29, second: 8, millisecond: 669), new TimeOnly(hour: 6, minute: 3, second: 48, millisecond: 348), }, { new TimeOnly(hour: 0, minute: 19, second: 49, millisecond: 263), new TimeOnly(hour: 18, minute: 28, second: 35, millisecond: 236), new TimeOnly(hour: 3, minute: 15, second: 8, millisecond: 236), }, }, { { new TimeOnly(hour: 7, minute: 50, second: 24, millisecond: 126), new TimeOnly(hour: 22, minute: 47, second: 30, millisecond: 199), new TimeOnly(hour: 0, minute: 3, second: 3, millisecond: 443), }, { new TimeOnly(hour: 14, minute: 30, second: 10, millisecond: 995), new TimeOnly(hour: 16, minute: 7, second: 24, millisecond: 950), new TimeOnly(hour: 16, minute: 47, second: 36, millisecond: 881), }, { new TimeOnly(hour: 8, minute: 8, second: 11, millisecond: 965), new TimeOnly(hour: 12, minute: 51, second: 35, millisecond: 420), new TimeOnly(hour: 18, minute: 37, second: 29, millisecond: 244), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 17, second: 3, millisecond: 115), new TimeOnly(hour: 1, minute: 56, second: 32, millisecond: 872), new TimeOnly(hour: 13, minute: 33, second: 42, millisecond: 734), }, { new TimeOnly(hour: 7, minute: 14, second: 3, millisecond: 94), new TimeOnly(hour: 15, minute: 27, second: 2, millisecond: 613), new TimeOnly(hour: 22, minute: 9, second: 45, millisecond: 713), }, { new TimeOnly(hour: 0, minute: 8, second: 4, millisecond: 254), new TimeOnly(hour: 0, minute: 54, second: 25, millisecond: 510), new TimeOnly(hour: 5, minute: 18, second: 58, millisecond: 837), }, }, { { new TimeOnly(hour: 8, minute: 14, second: 52, millisecond: 423), new TimeOnly(hour: 7, minute: 14, second: 22, millisecond: 773), new TimeOnly(hour: 15, minute: 37, second: 46, millisecond: 859), }, { new TimeOnly(hour: 20, minute: 53, second: 48, millisecond: 414), new TimeOnly(hour: 10, minute: 29, second: 28, millisecond: 544), new TimeOnly(hour: 11, minute: 48, second: 35, millisecond: 760), }, { new TimeOnly(hour: 16, minute: 56, second: 44, millisecond: 531), new TimeOnly(hour: 19, minute: 21, second: 45, millisecond: 582), new TimeOnly(hour: 20, minute: 22, second: 33, millisecond: 849), }, }, { { new TimeOnly(hour: 5, minute: 15, second: 12, millisecond: 960), new TimeOnly(hour: 15, minute: 42, second: 35, millisecond: 556), new TimeOnly(hour: 5, minute: 4, second: 33, millisecond: 529), }, { new TimeOnly(hour: 18, minute: 12, second: 45, millisecond: 212), new TimeOnly(hour: 12, minute: 55, second: 27, millisecond: 391), new TimeOnly(hour: 20, minute: 25, second: 55, millisecond: 898), }, { new TimeOnly(hour: 0, minute: 15, second: 46, millisecond: 745), new TimeOnly(hour: 14, minute: 38, second: 43, millisecond: 189), new TimeOnly(hour: 9, minute: 21, second: 28, millisecond: 474), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 97,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 885), new TimeOnly(hour: 12, minute: 25, second: 43, millisecond: 927), new TimeOnly(hour: 11, minute: 33, second: 12, millisecond: 551), }, { new TimeOnly(hour: 19, minute: 43, second: 39, millisecond: 349), new TimeOnly(hour: 9, minute: 56, second: 25, millisecond: 741), new TimeOnly(hour: 7, minute: 35, second: 1, millisecond: 56), }, { new TimeOnly(hour: 7, minute: 10, second: 16, millisecond: 919), new TimeOnly(hour: 22, minute: 35, second: 16, millisecond: 208), new TimeOnly(hour: 22, minute: 58, second: 53, millisecond: 544), }, }, { { new TimeOnly(hour: 18, minute: 3, second: 52, millisecond: 559), new TimeOnly(hour: 12, minute: 23, second: 27, millisecond: 889), new TimeOnly(hour: 21, minute: 36, second: 45, millisecond: 360), }, { new TimeOnly(hour: 11, minute: 20, second: 49, millisecond: 300), new TimeOnly(hour: 15, minute: 24, second: 51, millisecond: 853), new TimeOnly(hour: 1, minute: 38, second: 48, millisecond: 466), }, { new TimeOnly(hour: 1, minute: 45, second: 47, millisecond: 678), new TimeOnly(hour: 12, minute: 35, second: 42, millisecond: 814), new TimeOnly(hour: 15, minute: 38, second: 49, millisecond: 400), }, }, { { new TimeOnly(hour: 6, minute: 51, second: 37, millisecond: 292), new TimeOnly(hour: 8, minute: 55, second: 36, millisecond: 630), new TimeOnly(hour: 6, minute: 49, second: 29, millisecond: 971), }, { new TimeOnly(hour: 12, minute: 47, second: 11, millisecond: 353), new TimeOnly(hour: 3, minute: 37, second: 48, millisecond: 571), new TimeOnly(hour: 10, minute: 31, second: 52, millisecond: 138), }, { new TimeOnly(hour: 13, minute: 47, second: 21, millisecond: 915), new TimeOnly(hour: 16, minute: 5, second: 9, millisecond: 248), new TimeOnly(hour: 12, minute: 47, second: 21, millisecond: 158), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 60,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 21, second: 42, millisecond: 871), new TimeOnly(hour: 21, minute: 8, second: 24, millisecond: 953), new TimeOnly(hour: 14, minute: 51, second: 50, millisecond: 19), }, { new TimeOnly(hour: 13, minute: 23, second: 1, millisecond: 952), new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 455), new TimeOnly(hour: 3, minute: 49, second: 4, millisecond: 840), }, { new TimeOnly(hour: 10, minute: 52, second: 54, millisecond: 907), new TimeOnly(hour: 5, minute: 28, second: 42, millisecond: 405), new TimeOnly(hour: 17, minute: 12, second: 15, millisecond: 783), }, }, { { new TimeOnly(hour: 17, minute: 21, second: 17, millisecond: 502), new TimeOnly(hour: 4, minute: 50, second: 17, millisecond: 915), new TimeOnly(hour: 17, minute: 37, second: 6, millisecond: 421), }, { new TimeOnly(hour: 6, minute: 6, second: 42, millisecond: 56), new TimeOnly(hour: 13, minute: 26, second: 57, millisecond: 736), new TimeOnly(hour: 7, minute: 11, second: 21, millisecond: 105), }, { new TimeOnly(hour: 5, minute: 52, second: 57, millisecond: 79), new TimeOnly(hour: 2, minute: 54, second: 28, millisecond: 72), new TimeOnly(hour: 12, minute: 18, second: 42, millisecond: 302), }, }, { { new TimeOnly(hour: 4, minute: 21, second: 38, millisecond: 489), new TimeOnly(hour: 0, minute: 9, second: 9, millisecond: 662), new TimeOnly(hour: 3, minute: 58, second: 53, millisecond: 175), }, { new TimeOnly(hour: 17, minute: 5, second: 11, millisecond: 613), new TimeOnly(hour: 11, minute: 47, second: 6, millisecond: 951), new TimeOnly(hour: 15, minute: 51, second: 22, millisecond: 755), }, { new TimeOnly(hour: 18, minute: 23, second: 38, millisecond: 592), new TimeOnly(hour: 0, minute: 49, second: 54, millisecond: 61), new TimeOnly(hour: 21, minute: 37, second: 25, millisecond: 210), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 10, minute: 45, second: 15, millisecond: 923), new TimeOnly(hour: 20, minute: 38, second: 31, millisecond: 826), new TimeOnly(hour: 4, minute: 6, second: 9, millisecond: 413), }, { new TimeOnly(hour: 19, minute: 23, second: 6, millisecond: 278), new TimeOnly(hour: 3, minute: 6, second: 55, millisecond: 731), new TimeOnly(hour: 19, minute: 30, second: 38, millisecond: 916), }, { new TimeOnly(hour: 2, minute: 13, second: 13, millisecond: 249), new TimeOnly(hour: 1, minute: 46, second: 7, millisecond: 919), new TimeOnly(hour: 16, minute: 17, second: 36, millisecond: 387), }, }, { { new TimeOnly(hour: 4, minute: 28, second: 15, millisecond: 831), new TimeOnly(hour: 20, minute: 40, second: 9, millisecond: 879), new TimeOnly(hour: 9, minute: 5, second: 58, millisecond: 551), }, { new TimeOnly(hour: 5, minute: 31, second: 20, millisecond: 576), new TimeOnly(hour: 13, minute: 21, second: 37, millisecond: 32), new TimeOnly(hour: 12, minute: 56, second: 22, millisecond: 722), }, { new TimeOnly(hour: 21, minute: 20, second: 49, millisecond: 478), new TimeOnly(hour: 21, minute: 4, second: 43, millisecond: 391), new TimeOnly(hour: 11, minute: 4, second: 35, millisecond: 835), }, }, { { new TimeOnly(hour: 12, minute: 42, second: 48, millisecond: 286), new TimeOnly(hour: 16, minute: 33, second: 18, millisecond: 556), new TimeOnly(hour: 1, minute: 49, second: 17, millisecond: 417), }, { new TimeOnly(hour: 18, minute: 36, second: 23, millisecond: 455), new TimeOnly(hour: 19, minute: 8, second: 54, millisecond: 728), new TimeOnly(hour: 8, minute: 45, second: 29, millisecond: 219), }, { new TimeOnly(hour: 19, minute: 40, second: 36, millisecond: 694), new TimeOnly(hour: 10, minute: 30, second: 20, millisecond: 308), new TimeOnly(hour: 13, minute: 30, second: 0, millisecond: 340), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 103,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 19, minute: 32, second: 20, millisecond: 78), new TimeOnly(hour: 12, minute: 50, second: 24, millisecond: 595), new TimeOnly(hour: 21, minute: 34, second: 11, millisecond: 755), }, { new TimeOnly(hour: 9, minute: 28, second: 46, millisecond: 566), new TimeOnly(hour: 18, minute: 35, second: 32, millisecond: 342), new TimeOnly(hour: 4, minute: 20, second: 30, millisecond: 483), }, { new TimeOnly(hour: 1, minute: 3, second: 43, millisecond: 370), new TimeOnly(hour: 17, minute: 25, second: 8, millisecond: 882), new TimeOnly(hour: 9, minute: 24, second: 13, millisecond: 353), }, }, { { new TimeOnly(hour: 15, minute: 53, second: 39, millisecond: 378), new TimeOnly(hour: 2, minute: 46, second: 2, millisecond: 439), new TimeOnly(hour: 16, minute: 0, second: 12, millisecond: 603), }, { new TimeOnly(hour: 6, minute: 3, second: 23, millisecond: 131), new TimeOnly(hour: 22, minute: 11, second: 50, millisecond: 941), new TimeOnly(hour: 10, minute: 0, second: 5, millisecond: 19), }, { new TimeOnly(hour: 11, minute: 17, second: 57, millisecond: 154), new TimeOnly(hour: 3, minute: 8, second: 12, millisecond: 427), new TimeOnly(hour: 10, minute: 29, second: 10, millisecond: 716), }, }, { { new TimeOnly(hour: 16, minute: 24, second: 11, millisecond: 775), new TimeOnly(hour: 4, minute: 51, second: 28, millisecond: 354), new TimeOnly(hour: 11, minute: 17, second: 1, millisecond: 196), }, { new TimeOnly(hour: 1, minute: 1, second: 0, millisecond: 494), new TimeOnly(hour: 13, minute: 3, second: 18, millisecond: 524), new TimeOnly(hour: 0, minute: 42, second: 39, millisecond: 26), }, { new TimeOnly(hour: 22, minute: 31, second: 38, millisecond: 941), new TimeOnly(hour: 6, minute: 22, second: 36, millisecond: 540), new TimeOnly(hour: 22, minute: 44, second: 55, millisecond: 886), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 106,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 14, second: 24, millisecond: 742), new TimeOnly(hour: 21, minute: 57, second: 2, millisecond: 933), new TimeOnly(hour: 7, minute: 46, second: 50, millisecond: 28), }, { new TimeOnly(hour: 22, minute: 10, second: 19, millisecond: 620), new TimeOnly(hour: 5, minute: 30, second: 14, millisecond: 409), new TimeOnly(hour: 8, minute: 35, second: 47, millisecond: 99), }, { new TimeOnly(hour: 9, minute: 3, second: 26, millisecond: 692), new TimeOnly(hour: 11, minute: 33, second: 44, millisecond: 416), new TimeOnly(hour: 1, minute: 14, second: 29, millisecond: 444), }, }, { { new TimeOnly(hour: 8, minute: 56, second: 0, millisecond: 638), new TimeOnly(hour: 17, minute: 31, second: 40, millisecond: 68), new TimeOnly(hour: 21, minute: 43, second: 13, millisecond: 754), }, { new TimeOnly(hour: 18, minute: 47, second: 54, millisecond: 899), new TimeOnly(hour: 13, minute: 8, second: 4, millisecond: 799), new TimeOnly(hour: 4, minute: 1, second: 4, millisecond: 792), }, { new TimeOnly(hour: 14, minute: 15, second: 18, millisecond: 214), new TimeOnly(hour: 11, minute: 12, second: 34, millisecond: 582), new TimeOnly(hour: 2, minute: 50, second: 44, millisecond: 958), }, }, { { new TimeOnly(hour: 14, minute: 31, second: 54, millisecond: 962), new TimeOnly(hour: 13, minute: 12, second: 6, millisecond: 858), new TimeOnly(hour: 0, minute: 32, second: 22, millisecond: 973), }, { new TimeOnly(hour: 19, minute: 19, second: 52, millisecond: 74), new TimeOnly(hour: 5, minute: 56, second: 12, millisecond: 51), new TimeOnly(hour: 11, minute: 49, second: 20, millisecond: 650), }, { new TimeOnly(hour: 20, minute: 25, second: 21, millisecond: 66), new TimeOnly(hour: 7, minute: 49, second: 20, millisecond: 128), new TimeOnly(hour: 8, minute: 12, second: 36, millisecond: 64), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 68,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 58, second: 44, millisecond: 947), new TimeOnly(hour: 2, minute: 38, second: 32, millisecond: 166), new TimeOnly(hour: 11, minute: 56, second: 21, millisecond: 121), }, { new TimeOnly(hour: 18, minute: 56, second: 26, millisecond: 659), new TimeOnly(hour: 0, minute: 13, second: 4, millisecond: 259), new TimeOnly(hour: 14, minute: 11, second: 4, millisecond: 115), }, { new TimeOnly(hour: 20, minute: 28, second: 27, millisecond: 532), new TimeOnly(hour: 6, minute: 40, second: 27, millisecond: 188), new TimeOnly(hour: 13, minute: 6, second: 38, millisecond: 44), }, }, { { new TimeOnly(hour: 5, minute: 14, second: 0, millisecond: 708), new TimeOnly(hour: 15, minute: 22, second: 28, millisecond: 0), new TimeOnly(hour: 7, minute: 7, second: 27, millisecond: 842), }, { new TimeOnly(hour: 9, minute: 15, second: 58, millisecond: 213), new TimeOnly(hour: 2, minute: 36, second: 1, millisecond: 937), new TimeOnly(hour: 10, minute: 33, second: 46, millisecond: 726), }, { new TimeOnly(hour: 6, minute: 23, second: 57, millisecond: 361), new TimeOnly(hour: 7, minute: 0, second: 40, millisecond: 369), new TimeOnly(hour: 22, minute: 7, second: 46, millisecond: 532), }, }, { { new TimeOnly(hour: 22, minute: 43, second: 4, millisecond: 990), new TimeOnly(hour: 9, minute: 22, second: 22, millisecond: 256), new TimeOnly(hour: 5, minute: 41, second: 4, millisecond: 334), }, { new TimeOnly(hour: 22, minute: 4, second: 57, millisecond: 180), new TimeOnly(hour: 7, minute: 28, second: 17, millisecond: 42), new TimeOnly(hour: 18, minute: 45, second: 29, millisecond: 902), }, { new TimeOnly(hour: 2, minute: 25, second: 31, millisecond: 67), new TimeOnly(hour: 4, minute: 22, second: 35, millisecond: 559), new TimeOnly(hour: 1, minute: 19, second: 7, millisecond: 734), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 2, minute: 42, second: 17, millisecond: 494), new TimeOnly(hour: 3, minute: 12, second: 22, millisecond: 388), new TimeOnly(hour: 21, minute: 45, second: 54, millisecond: 255), }, { new TimeOnly(hour: 14, minute: 48, second: 22, millisecond: 736), new TimeOnly(hour: 8, minute: 47, second: 52, millisecond: 544), new TimeOnly(hour: 22, minute: 27, second: 42, millisecond: 85), }, { new TimeOnly(hour: 18, minute: 41, second: 21, millisecond: 418), new TimeOnly(hour: 2, minute: 46, second: 18, millisecond: 227), new TimeOnly(hour: 22, minute: 8, second: 34, millisecond: 35), }, }, { { new TimeOnly(hour: 8, minute: 20, second: 22, millisecond: 910), new TimeOnly(hour: 8, minute: 54, second: 57, millisecond: 603), new TimeOnly(hour: 21, minute: 10, second: 32, millisecond: 76), }, { new TimeOnly(hour: 17, minute: 26, second: 11, millisecond: 830), new TimeOnly(hour: 19, minute: 39, second: 26, millisecond: 898), new TimeOnly(hour: 5, minute: 43, second: 5, millisecond: 971), }, { new TimeOnly(hour: 3, minute: 23, second: 5, millisecond: 982), new TimeOnly(hour: 20, minute: 55, second: 56, millisecond: 30), new TimeOnly(hour: 13, minute: 27, second: 38, millisecond: 118), }, }, { { new TimeOnly(hour: 10, minute: 11, second: 29, millisecond: 100), new TimeOnly(hour: 20, minute: 56, second: 21, millisecond: 490), new TimeOnly(hour: 18, minute: 20, second: 8, millisecond: 306), }, { new TimeOnly(hour: 16, minute: 20, second: 39, millisecond: 290), new TimeOnly(hour: 9, minute: 54, second: 43, millisecond: 177), new TimeOnly(hour: 4, minute: 11, second: 31, millisecond: 285), }, { new TimeOnly(hour: 15, minute: 7, second: 35, millisecond: 820), new TimeOnly(hour: 6, minute: 20, second: 29, millisecond: 836), new TimeOnly(hour: 7, minute: 14, second: 21, millisecond: 43), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 109,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 7, minute: 3, second: 10, millisecond: 679), new TimeOnly(hour: 21, minute: 57, second: 45, millisecond: 690), new TimeOnly(hour: 20, minute: 6, second: 58, millisecond: 302), }, { new TimeOnly(hour: 14, minute: 31, second: 43, millisecond: 873), new TimeOnly(hour: 6, minute: 49, second: 32, millisecond: 857), new TimeOnly(hour: 15, minute: 23, second: 45, millisecond: 439), }, { new TimeOnly(hour: 21, minute: 21, second: 34, millisecond: 923), new TimeOnly(hour: 19, minute: 18, second: 1, millisecond: 754), new TimeOnly(hour: 9, minute: 30, second: 49, millisecond: 796), }, }, { { new TimeOnly(hour: 22, minute: 6, second: 42, millisecond: 762), new TimeOnly(hour: 2, minute: 36, second: 4, millisecond: 424), new TimeOnly(hour: 11, minute: 13, second: 42, millisecond: 635), }, { new TimeOnly(hour: 4, minute: 16, second: 46, millisecond: 434), new TimeOnly(hour: 3, minute: 2, second: 55, millisecond: 314), new TimeOnly(hour: 19, minute: 7, second: 29, millisecond: 720), }, { new TimeOnly(hour: 14, minute: 10, second: 3, millisecond: 699), new TimeOnly(hour: 5, minute: 40, second: 44, millisecond: 520), new TimeOnly(hour: 15, minute: 36, second: 43, millisecond: 879), }, }, { { new TimeOnly(hour: 17, minute: 0, second: 50, millisecond: 427), new TimeOnly(hour: 22, minute: 32, second: 47, millisecond: 344), new TimeOnly(hour: 8, minute: 39, second: 10, millisecond: 628), }, { new TimeOnly(hour: 11, minute: 48, second: 52, millisecond: 989), new TimeOnly(hour: 4, minute: 19, second: 30, millisecond: 598), new TimeOnly(hour: 20, minute: 28, second: 43, millisecond: 245), }, { new TimeOnly(hour: 5, minute: 2, second: 45, millisecond: 880), new TimeOnly(hour: 17, minute: 40, second: 25, millisecond: 945), new TimeOnly(hour: 21, minute: 38, second: 46, millisecond: 14), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 115,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 11, minute: 7, second: 4, millisecond: 570), new TimeOnly(hour: 17, minute: 34, second: 52, millisecond: 998), new TimeOnly(hour: 20, minute: 44, second: 12, millisecond: 971), }, { new TimeOnly(hour: 10, minute: 33, second: 12, millisecond: 431), new TimeOnly(hour: 0, minute: 1, second: 8, millisecond: 708), new TimeOnly(hour: 21, minute: 51, second: 32, millisecond: 815), }, { new TimeOnly(hour: 14, minute: 38, second: 19, millisecond: 788), new TimeOnly(hour: 0, minute: 25, second: 14, millisecond: 148), new TimeOnly(hour: 15, minute: 52, second: 15, millisecond: 304), }, }, { { new TimeOnly(hour: 0, minute: 37, second: 50, millisecond: 30), new TimeOnly(hour: 3, minute: 41, second: 50, millisecond: 965), new TimeOnly(hour: 16, minute: 40, second: 40, millisecond: 239), }, { new TimeOnly(hour: 17, minute: 0, second: 39, millisecond: 287), new TimeOnly(hour: 14, minute: 19, second: 40, millisecond: 654), new TimeOnly(hour: 1, minute: 51, second: 30, millisecond: 693), }, { new TimeOnly(hour: 18, minute: 17, second: 20, millisecond: 580), new TimeOnly(hour: 5, minute: 49, second: 20, millisecond: 157), new TimeOnly(hour: 16, minute: 32, second: 44, millisecond: 800), }, }, { { new TimeOnly(hour: 6, minute: 18, second: 13, millisecond: 943), new TimeOnly(hour: 20, minute: 8, second: 35, millisecond: 948), new TimeOnly(hour: 15, minute: 22, second: 40, millisecond: 9), }, { new TimeOnly(hour: 7, minute: 24, second: 14, millisecond: 363), new TimeOnly(hour: 4, minute: 33, second: 27, millisecond: 555), new TimeOnly(hour: 6, minute: 5, second: 50, millisecond: 746), }, { new TimeOnly(hour: 14, minute: 50, second: 10, millisecond: 750), new TimeOnly(hour: 17, minute: 28, second: 48, millisecond: 107), new TimeOnly(hour: 9, minute: 19, second: 24, millisecond: 30), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 70,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 26, second: 33, millisecond: 925), new TimeOnly(hour: 9, minute: 17, second: 20, millisecond: 261), new TimeOnly(hour: 7, minute: 10, second: 8, millisecond: 457), }, { new TimeOnly(hour: 19, minute: 25, second: 53, millisecond: 400), new TimeOnly(hour: 19, minute: 24, second: 22, millisecond: 365), new TimeOnly(hour: 11, minute: 22, second: 9, millisecond: 977), }, { new TimeOnly(hour: 19, minute: 53, second: 29, millisecond: 201), new TimeOnly(hour: 3, minute: 26, second: 50, millisecond: 692), new TimeOnly(hour: 3, minute: 1, second: 36, millisecond: 972), }, }, { { new TimeOnly(hour: 15, minute: 16, second: 39, millisecond: 139), new TimeOnly(hour: 20, minute: 45, second: 49, millisecond: 820), new TimeOnly(hour: 3, minute: 28, second: 16, millisecond: 872), }, { new TimeOnly(hour: 2, minute: 26, second: 30, millisecond: 4), new TimeOnly(hour: 0, minute: 39, second: 58, millisecond: 405), new TimeOnly(hour: 21, minute: 45, second: 31, millisecond: 52), }, { new TimeOnly(hour: 2, minute: 49, second: 17, millisecond: 381), new TimeOnly(hour: 0, minute: 36, second: 51, millisecond: 166), new TimeOnly(hour: 4, minute: 39, second: 7, millisecond: 874), }, }, { { new TimeOnly(hour: 21, minute: 21, second: 10, millisecond: 895), new TimeOnly(hour: 17, minute: 17, second: 18, millisecond: 324), new TimeOnly(hour: 14, minute: 22, second: 34, millisecond: 42), }, { new TimeOnly(hour: 11, minute: 12, second: 5, millisecond: 692), new TimeOnly(hour: 0, minute: 1, second: 11, millisecond: 69), new TimeOnly(hour: 15, minute: 20, second: 55, millisecond: 171), }, { new TimeOnly(hour: 16, minute: 53, second: 23, millisecond: 846), new TimeOnly(hour: 14, minute: 44, second: 54, millisecond: 630), new TimeOnly(hour: 20, minute: 45, second: 13, millisecond: 405), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 122,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 15, minute: 23, second: 18, millisecond: 799), new TimeOnly(hour: 17, minute: 39, second: 53, millisecond: 471), new TimeOnly(hour: 20, minute: 40, second: 6, millisecond: 933), }, { new TimeOnly(hour: 17, minute: 25, second: 1, millisecond: 814), new TimeOnly(hour: 3, minute: 40, second: 41, millisecond: 390), new TimeOnly(hour: 1, minute: 20, second: 48, millisecond: 857), }, { new TimeOnly(hour: 15, minute: 15, second: 54, millisecond: 299), new TimeOnly(hour: 14, minute: 58, second: 22, millisecond: 212), new TimeOnly(hour: 5, minute: 15, second: 58, millisecond: 633), }, }, { { new TimeOnly(hour: 14, minute: 8, second: 32, millisecond: 552), new TimeOnly(hour: 1, minute: 6, second: 31, millisecond: 593), new TimeOnly(hour: 16, minute: 21, second: 15, millisecond: 554), }, { new TimeOnly(hour: 22, minute: 30, second: 26, millisecond: 183), new TimeOnly(hour: 10, minute: 42, second: 33, millisecond: 238), new TimeOnly(hour: 18, minute: 46, second: 33, millisecond: 179), }, { new TimeOnly(hour: 21, minute: 49, second: 22, millisecond: 700), new TimeOnly(hour: 5, minute: 10, second: 42, millisecond: 69), new TimeOnly(hour: 9, minute: 32, second: 10, millisecond: 481), }, }, { { new TimeOnly(hour: 3, minute: 58, second: 7, millisecond: 400), new TimeOnly(hour: 5, minute: 29, second: 55, millisecond: 655), new TimeOnly(hour: 7, minute: 48, second: 5, millisecond: 118), }, { new TimeOnly(hour: 9, minute: 31, second: 5, millisecond: 351), new TimeOnly(hour: 17, minute: 33, second: 25, millisecond: 212), new TimeOnly(hour: 15, minute: 58, second: 25, millisecond: 814), }, { new TimeOnly(hour: 19, minute: 21, second: 51, millisecond: 400), new TimeOnly(hour: 20, minute: 9, second: 1, millisecond: 322), new TimeOnly(hour: 11, minute: 31, second: 37, millisecond: 684), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 21, minute: 27, second: 32, millisecond: 402), new TimeOnly(hour: 2, minute: 52, second: 33, millisecond: 798), new TimeOnly(hour: 5, minute: 16, second: 40, millisecond: 992), }, { new TimeOnly(hour: 1, minute: 40, second: 8, millisecond: 394), new TimeOnly(hour: 16, minute: 4, second: 18, millisecond: 626), new TimeOnly(hour: 15, minute: 48, second: 26, millisecond: 370), }, { new TimeOnly(hour: 15, minute: 10, second: 9, millisecond: 698), new TimeOnly(hour: 11, minute: 52, second: 16, millisecond: 781), new TimeOnly(hour: 3, minute: 30, second: 57, millisecond: 596), }, }, { { new TimeOnly(hour: 3, minute: 8, second: 20, millisecond: 731), new TimeOnly(hour: 18, minute: 47, second: 39, millisecond: 909), new TimeOnly(hour: 18, minute: 44, second: 31, millisecond: 662), }, { new TimeOnly(hour: 14, minute: 17, second: 33, millisecond: 480), new TimeOnly(hour: 4, minute: 39, second: 58, millisecond: 217), new TimeOnly(hour: 11, minute: 10, second: 36, millisecond: 887), }, { new TimeOnly(hour: 1, minute: 11, second: 35, millisecond: 893), new TimeOnly(hour: 12, minute: 16, second: 28, millisecond: 89), new TimeOnly(hour: 5, minute: 22, second: 28, millisecond: 497), }, }, { { new TimeOnly(hour: 10, minute: 35, second: 6, millisecond: 619), new TimeOnly(hour: 8, minute: 26, second: 21, millisecond: 446), new TimeOnly(hour: 13, minute: 25, second: 32, millisecond: 419), }, { new TimeOnly(hour: 1, minute: 23, second: 29, millisecond: 420), new TimeOnly(hour: 18, minute: 25, second: 47, millisecond: 215), new TimeOnly(hour: 3, minute: 9, second: 52, millisecond: 269), }, { new TimeOnly(hour: 16, minute: 8, second: 33, millisecond: 449), new TimeOnly(hour: 17, minute: 10, second: 9, millisecond: 126), new TimeOnly(hour: 3, minute: 54, second: 25, millisecond: 327), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 130,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 19, minute: 37, second: 38, millisecond: 940), new TimeOnly(hour: 8, minute: 21, second: 27, millisecond: 104), new TimeOnly(hour: 8, minute: 55, second: 20, millisecond: 663), }, { new TimeOnly(hour: 6, minute: 3, second: 43, millisecond: 524), new TimeOnly(hour: 7, minute: 48, second: 29, millisecond: 790), new TimeOnly(hour: 6, minute: 5, second: 13, millisecond: 771), }, { new TimeOnly(hour: 13, minute: 21, second: 25, millisecond: 144), new TimeOnly(hour: 22, minute: 37, second: 45, millisecond: 803), new TimeOnly(hour: 10, minute: 55, second: 24, millisecond: 166), }, }, { { new TimeOnly(hour: 8, minute: 36, second: 55, millisecond: 210), new TimeOnly(hour: 8, minute: 41, second: 25, millisecond: 956), new TimeOnly(hour: 1, minute: 10, second: 42, millisecond: 321), }, { new TimeOnly(hour: 13, minute: 5, second: 43, millisecond: 801), new TimeOnly(hour: 16, minute: 10, second: 7, millisecond: 390), new TimeOnly(hour: 1, minute: 43, second: 37, millisecond: 812), }, { new TimeOnly(hour: 5, minute: 12, second: 38, millisecond: 996), new TimeOnly(hour: 7, minute: 11, second: 51, millisecond: 264), new TimeOnly(hour: 9, minute: 47, second: 9, millisecond: 157), }, }, { { new TimeOnly(hour: 1, minute: 33, second: 58, millisecond: 529), new TimeOnly(hour: 8, minute: 52, second: 34, millisecond: 250), new TimeOnly(hour: 0, minute: 0, second: 5, millisecond: 140), }, { new TimeOnly(hour: 12, minute: 18, second: 32, millisecond: 254), new TimeOnly(hour: 5, minute: 6, second: 7, millisecond: 609), new TimeOnly(hour: 3, minute: 23, second: 29, millisecond: 757), }, { new TimeOnly(hour: 17, minute: 31, second: 50, millisecond: 65), new TimeOnly(hour: 8, minute: 53, second: 31, millisecond: 357), new TimeOnly(hour: 9, minute: 12, second: 5, millisecond: 99), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 74,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 16, minute: 25, second: 20, millisecond: 311), new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 655), new TimeOnly(hour: 1, minute: 50, second: 23, millisecond: 265), }, { new TimeOnly(hour: 16, minute: 3, second: 51, millisecond: 109), new TimeOnly(hour: 16, minute: 13, second: 18, millisecond: 543), new TimeOnly(hour: 5, minute: 20, second: 30, millisecond: 30), }, { new TimeOnly(hour: 14, minute: 19, second: 48, millisecond: 773), new TimeOnly(hour: 22, minute: 43, second: 57, millisecond: 18), new TimeOnly(hour: 14, minute: 33, second: 1, millisecond: 388), }, }, { { new TimeOnly(hour: 8, minute: 56, second: 47, millisecond: 68), new TimeOnly(hour: 8, minute: 32, second: 22, millisecond: 344), new TimeOnly(hour: 18, minute: 47, second: 46, millisecond: 848), }, { new TimeOnly(hour: 0, minute: 47, second: 1, millisecond: 294), new TimeOnly(hour: 21, minute: 51, second: 25, millisecond: 158), new TimeOnly(hour: 6, minute: 20, second: 46, millisecond: 236), }, { new TimeOnly(hour: 16, minute: 15, second: 4, millisecond: 140), new TimeOnly(hour: 11, minute: 47, second: 16, millisecond: 866), new TimeOnly(hour: 3, minute: 4, second: 15, millisecond: 843), }, }, { { new TimeOnly(hour: 7, minute: 26, second: 4, millisecond: 253), new TimeOnly(hour: 8, minute: 10, second: 27, millisecond: 883), new TimeOnly(hour: 12, minute: 4, second: 0, millisecond: 660), }, { new TimeOnly(hour: 17, minute: 19, second: 54, millisecond: 125), new TimeOnly(hour: 5, minute: 42, second: 4, millisecond: 319), new TimeOnly(hour: 17, minute: 30, second: 29, millisecond: 50), }, { new TimeOnly(hour: 20, minute: 13, second: 33, millisecond: 686), new TimeOnly(hour: 11, minute: 54, second: 46, millisecond: 490), new TimeOnly(hour: 3, minute: 53, second: 24, millisecond: 56), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 12, minute: 32, second: 22, millisecond: 342), new TimeOnly(hour: 1, minute: 20, second: 42, millisecond: 799), new TimeOnly(hour: 10, minute: 16, second: 53, millisecond: 503), }, { new TimeOnly(hour: 18, minute: 1, second: 31, millisecond: 449), new TimeOnly(hour: 13, minute: 38, second: 6, millisecond: 743), new TimeOnly(hour: 1, minute: 37, second: 53, millisecond: 639), }, { new TimeOnly(hour: 6, minute: 52, second: 29, millisecond: 497), new TimeOnly(hour: 16, minute: 52, second: 32, millisecond: 796), new TimeOnly(hour: 9, minute: 32, second: 29, millisecond: 360), }, }, { { new TimeOnly(hour: 7, minute: 55, second: 11, millisecond: 402), new TimeOnly(hour: 5, minute: 17, second: 22, millisecond: 791), new TimeOnly(hour: 15, minute: 8, second: 12, millisecond: 892), }, { new TimeOnly(hour: 10, minute: 24, second: 52, millisecond: 645), new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 157), new TimeOnly(hour: 6, minute: 33, second: 3, millisecond: 188), }, { new TimeOnly(hour: 8, minute: 33, second: 35, millisecond: 645), new TimeOnly(hour: 14, minute: 41, second: 4, millisecond: 9), new TimeOnly(hour: 8, minute: 36, second: 28, millisecond: 256), }, }, { { new TimeOnly(hour: 17, minute: 50, second: 27, millisecond: 149), new TimeOnly(hour: 1, minute: 45, second: 19, millisecond: 387), new TimeOnly(hour: 19, minute: 47, second: 55, millisecond: 280), }, { new TimeOnly(hour: 0, minute: 21, second: 26, millisecond: 795), new TimeOnly(hour: 6, minute: 7, second: 52, millisecond: 994), new TimeOnly(hour: 0, minute: 56, second: 42, millisecond: 838), }, { new TimeOnly(hour: 8, minute: 53, second: 14, millisecond: 402), new TimeOnly(hour: 5, minute: 42, second: 56, millisecond: 565), new TimeOnly(hour: 19, minute: 48, second: 57, millisecond: 871), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 134,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 4, minute: 50, second: 50, millisecond: 181), new TimeOnly(hour: 7, minute: 43, second: 43, millisecond: 42), new TimeOnly(hour: 12, minute: 20, second: 27, millisecond: 154), }, { new TimeOnly(hour: 18, minute: 24, second: 53, millisecond: 838), new TimeOnly(hour: 12, minute: 3, second: 19, millisecond: 563), new TimeOnly(hour: 13, minute: 18, second: 9, millisecond: 810), }, { new TimeOnly(hour: 6, minute: 21, second: 31, millisecond: 581), new TimeOnly(hour: 8, minute: 48, second: 22, millisecond: 140), new TimeOnly(hour: 13, minute: 23, second: 49, millisecond: 108), }, }, { { new TimeOnly(hour: 12, minute: 36, second: 53, millisecond: 571), new TimeOnly(hour: 10, minute: 25, second: 42, millisecond: 23), new TimeOnly(hour: 17, minute: 14, second: 53, millisecond: 900), }, { new TimeOnly(hour: 3, minute: 16, second: 49, millisecond: 752), new TimeOnly(hour: 9, minute: 37, second: 39, millisecond: 709), new TimeOnly(hour: 8, minute: 31, second: 31, millisecond: 159), }, { new TimeOnly(hour: 11, minute: 38, second: 27, millisecond: 906), new TimeOnly(hour: 15, minute: 49, second: 33, millisecond: 336), new TimeOnly(hour: 16, minute: 37, second: 0, millisecond: 801), }, }, { { new TimeOnly(hour: 4, minute: 52, second: 57, millisecond: 745), new TimeOnly(hour: 15, minute: 22, second: 2, millisecond: 898), new TimeOnly(hour: 16, minute: 31, second: 20, millisecond: 912), }, { new TimeOnly(hour: 12, minute: 51, second: 31, millisecond: 433), new TimeOnly(hour: 22, minute: 23, second: 36, millisecond: 238), new TimeOnly(hour: 19, minute: 27, second: 10, millisecond: 976), }, { new TimeOnly(hour: 12, minute: 57, second: 39, millisecond: 832), new TimeOnly(hour: 10, minute: 47, second: 14, millisecond: 883), new TimeOnly(hour: 10, minute: 39, second: 37, millisecond: 745), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 139,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 17, minute: 41, second: 30, millisecond: 29), new TimeOnly(hour: 11, minute: 30, second: 29, millisecond: 238), new TimeOnly(hour: 3, minute: 6, second: 15, millisecond: 880), }, { new TimeOnly(hour: 14, minute: 24, second: 53, millisecond: 313), new TimeOnly(hour: 7, minute: 49, second: 34, millisecond: 653), new TimeOnly(hour: 3, minute: 8, second: 3, millisecond: 316), }, { new TimeOnly(hour: 17, minute: 58, second: 50, millisecond: 734), new TimeOnly(hour: 13, minute: 5, second: 55, millisecond: 432), new TimeOnly(hour: 2, minute: 48, second: 0, millisecond: 481), }, }, { { new TimeOnly(hour: 16, minute: 32, second: 5, millisecond: 126), new TimeOnly(hour: 16, minute: 0, second: 4, millisecond: 393), new TimeOnly(hour: 12, minute: 51, second: 37, millisecond: 854), }, { new TimeOnly(hour: 1, minute: 52, second: 1, millisecond: 212), new TimeOnly(hour: 16, minute: 2, second: 15, millisecond: 814), new TimeOnly(hour: 1, minute: 0, second: 34, millisecond: 991), }, { new TimeOnly(hour: 12, minute: 51, second: 44, millisecond: 21), new TimeOnly(hour: 9, minute: 27, second: 12, millisecond: 579), new TimeOnly(hour: 20, minute: 45, second: 56, millisecond: 340), }, }, { { new TimeOnly(hour: 13, minute: 21, second: 34, millisecond: 943), new TimeOnly(hour: 13, minute: 25, second: 17, millisecond: 149), new TimeOnly(hour: 17, minute: 35, second: 27, millisecond: 434), }, { new TimeOnly(hour: 16, minute: 20, second: 11, millisecond: 185), new TimeOnly(hour: 13, minute: 56, second: 6, millisecond: 249), new TimeOnly(hour: 2, minute: 21, second: 15, millisecond: 394), }, { new TimeOnly(hour: 0, minute: 13, second: 43, millisecond: 966), new TimeOnly(hour: 12, minute: 21, second: 25, millisecond: 847), new TimeOnly(hour: 5, minute: 46, second: 40, millisecond: 752), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 83,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 9, minute: 28, second: 34, millisecond: 169), new TimeOnly(hour: 8, minute: 3, second: 37, millisecond: 796), new TimeOnly(hour: 16, minute: 55, second: 2, millisecond: 323), }, { new TimeOnly(hour: 13, minute: 0, second: 39, millisecond: 41), new TimeOnly(hour: 21, minute: 50, second: 12, millisecond: 312), new TimeOnly(hour: 20, minute: 18, second: 49, millisecond: 479), }, { new TimeOnly(hour: 16, minute: 7, second: 25, millisecond: 162), new TimeOnly(hour: 16, minute: 28, second: 18, millisecond: 771), new TimeOnly(hour: 22, minute: 33, second: 8, millisecond: 703), }, }, { { new TimeOnly(hour: 9, minute: 26, second: 18, millisecond: 600), new TimeOnly(hour: 3, minute: 33, second: 38, millisecond: 424), new TimeOnly(hour: 5, minute: 43, second: 23, millisecond: 21), }, { new TimeOnly(hour: 5, minute: 9, second: 41, millisecond: 155), new TimeOnly(hour: 20, minute: 5, second: 24, millisecond: 700), new TimeOnly(hour: 10, minute: 58, second: 21, millisecond: 765), }, { new TimeOnly(hour: 22, minute: 42, second: 55, millisecond: 553), new TimeOnly(hour: 21, minute: 33, second: 8, millisecond: 117), new TimeOnly(hour: 0, minute: 31, second: 20, millisecond: 331), }, }, { { new TimeOnly(hour: 19, minute: 34, second: 16, millisecond: 217), new TimeOnly(hour: 16, minute: 27, second: 19, millisecond: 949), new TimeOnly(hour: 19, minute: 56, second: 35, millisecond: 964), }, { new TimeOnly(hour: 10, minute: 5, second: 37, millisecond: 311), new TimeOnly(hour: 1, minute: 26, second: 24, millisecond: 346), new TimeOnly(hour: 7, minute: 24, second: 14, millisecond: 12), }, { new TimeOnly(hour: 13, minute: 26, second: 47, millisecond: 347), new TimeOnly(hour: 9, minute: 46, second: 1, millisecond: 217), new TimeOnly(hour: 0, minute: 54, second: 4, millisecond: 438), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 8, minute: 19, second: 18, millisecond: 513), new TimeOnly(hour: 13, minute: 18, second: 35, millisecond: 243), new TimeOnly(hour: 20, minute: 41, second: 31, millisecond: 151), }, { new TimeOnly(hour: 12, minute: 46, second: 9, millisecond: 995), new TimeOnly(hour: 19, minute: 3, second: 18, millisecond: 202), new TimeOnly(hour: 19, minute: 0, second: 35, millisecond: 64), }, { new TimeOnly(hour: 19, minute: 42, second: 58, millisecond: 189), new TimeOnly(hour: 22, minute: 23, second: 26, millisecond: 939), new TimeOnly(hour: 14, minute: 0, second: 10, millisecond: 384), }, }, { { new TimeOnly(hour: 20, minute: 24, second: 27, millisecond: 282), new TimeOnly(hour: 17, minute: 48, second: 27, millisecond: 308), new TimeOnly(hour: 5, minute: 3, second: 37, millisecond: 191), }, { new TimeOnly(hour: 5, minute: 56, second: 28, millisecond: 836), new TimeOnly(hour: 21, minute: 52, second: 51, millisecond: 926), new TimeOnly(hour: 22, minute: 41, second: 2, millisecond: 179), }, { new TimeOnly(hour: 19, minute: 34, second: 53, millisecond: 485), new TimeOnly(hour: 15, minute: 10, second: 18, millisecond: 548), new TimeOnly(hour: 13, minute: 30, second: 17, millisecond: 87), }, }, { { new TimeOnly(hour: 19, minute: 56, second: 41, millisecond: 891), new TimeOnly(hour: 21, minute: 37, second: 47, millisecond: 285), new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 935), }, { new TimeOnly(hour: 20, minute: 10, second: 0, millisecond: 859), new TimeOnly(hour: 16, minute: 52, second: 22, millisecond: 264), new TimeOnly(hour: 1, minute: 15, second: 6, millisecond: 707), }, { new TimeOnly(hour: 2, minute: 58, second: 55, millisecond: 872), new TimeOnly(hour: 20, minute: 32, second: 34, millisecond: 29), new TimeOnly(hour: 11, minute: 1, second: 29, millisecond: 919), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 16, minute: 51, second: 20, millisecond: 650), new TimeOnly(hour: 18, minute: 4, second: 11, millisecond: 908), new TimeOnly(hour: 4, minute: 16, second: 26, millisecond: 128), }, { new TimeOnly(hour: 4, minute: 26, second: 51, millisecond: 858), new TimeOnly(hour: 3, minute: 9, second: 39, millisecond: 354), new TimeOnly(hour: 4, minute: 44, second: 14, millisecond: 754), }, { new TimeOnly(hour: 2, minute: 57, second: 36, millisecond: 776), new TimeOnly(hour: 21, minute: 36, second: 2, millisecond: 215), new TimeOnly(hour: 7, minute: 1, second: 34, millisecond: 741), }, }, { { new TimeOnly(hour: 13, minute: 9, second: 10, millisecond: 224), new TimeOnly(hour: 21, minute: 49, second: 43, millisecond: 270), new TimeOnly(hour: 11, minute: 21, second: 11, millisecond: 352), }, { new TimeOnly(hour: 20, minute: 1, second: 0, millisecond: 342), new TimeOnly(hour: 18, minute: 22, second: 21, millisecond: 285), new TimeOnly(hour: 2, minute: 44, second: 54, millisecond: 810), }, { new TimeOnly(hour: 12, minute: 31, second: 14, millisecond: 597), new TimeOnly(hour: 5, minute: 34, second: 47, millisecond: 345), new TimeOnly(hour: 3, minute: 17, second: 57, millisecond: 181), }, }, { { new TimeOnly(hour: 15, minute: 45, second: 4, millisecond: 362), new TimeOnly(hour: 20, minute: 25, second: 23, millisecond: 252), new TimeOnly(hour: 6, minute: 54, second: 26, millisecond: 853), }, { new TimeOnly(hour: 10, minute: 49, second: 3, millisecond: 274), new TimeOnly(hour: 19, minute: 55, second: 0, millisecond: 590), new TimeOnly(hour: 10, minute: 12, second: 47, millisecond: 72), }, { new TimeOnly(hour: 5, minute: 25, second: 3, millisecond: 790), new TimeOnly(hour: 14, minute: 33, second: 7, millisecond: 402), new TimeOnly(hour: 13, minute: 37, second: 24, millisecond: 307), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 148,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 14, minute: 41, second: 46, millisecond: 81), new TimeOnly(hour: 15, minute: 3, second: 37, millisecond: 796), new TimeOnly(hour: 11, minute: 39, second: 24, millisecond: 629), }, { new TimeOnly(hour: 15, minute: 38, second: 18, millisecond: 0), new TimeOnly(hour: 11, minute: 48, second: 46, millisecond: 873), new TimeOnly(hour: 4, minute: 38, second: 20, millisecond: 888), }, { new TimeOnly(hour: 22, minute: 2, second: 7, millisecond: 336), new TimeOnly(hour: 9, minute: 37, second: 15, millisecond: 907), new TimeOnly(hour: 14, minute: 34, second: 36, millisecond: 969), }, }, { { new TimeOnly(hour: 16, minute: 10, second: 23, millisecond: 611), new TimeOnly(hour: 7, minute: 21, second: 20, millisecond: 656), new TimeOnly(hour: 18, minute: 43, second: 58, millisecond: 849), }, { new TimeOnly(hour: 2, minute: 10, second: 53, millisecond: 180), new TimeOnly(hour: 16, minute: 6, second: 43, millisecond: 129), new TimeOnly(hour: 15, minute: 34, second: 5, millisecond: 414), }, { new TimeOnly(hour: 0, minute: 20, second: 31, millisecond: 312), new TimeOnly(hour: 17, minute: 39, second: 35, millisecond: 850), new TimeOnly(hour: 7, minute: 54, second: 58, millisecond: 410), }, }, { { new TimeOnly(hour: 22, minute: 23, second: 47, millisecond: 248), new TimeOnly(hour: 3, minute: 35, second: 37, millisecond: 816), new TimeOnly(hour: 7, minute: 43, second: 35, millisecond: 126), }, { new TimeOnly(hour: 1, minute: 39, second: 0, millisecond: 921), new TimeOnly(hour: 2, minute: 39, second: 58, millisecond: 229), new TimeOnly(hour: 0, minute: 0, second: 52, millisecond: 819), }, { new TimeOnly(hour: 10, minute: 9, second: 29, millisecond: 250), new TimeOnly(hour: 9, minute: 32, second: 2, millisecond: 585), new TimeOnly(hour: 6, minute: 26, second: 53, millisecond: 353), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 19, minute: 13, second: 0, millisecond: 593), new TimeOnly(hour: 13, minute: 7, second: 52, millisecond: 235), new TimeOnly(hour: 7, minute: 2, second: 38, millisecond: 692), }, { new TimeOnly(hour: 8, minute: 6, second: 24, millisecond: 107), new TimeOnly(hour: 6, minute: 7, second: 16, millisecond: 258), new TimeOnly(hour: 19, minute: 31, second: 40, millisecond: 900), }, { new TimeOnly(hour: 12, minute: 2, second: 6, millisecond: 578), new TimeOnly(hour: 12, minute: 45, second: 24, millisecond: 16), new TimeOnly(hour: 13, minute: 9, second: 44, millisecond: 845), }, }, { { new TimeOnly(hour: 11, minute: 48, second: 24, millisecond: 767), new TimeOnly(hour: 14, minute: 32, second: 2, millisecond: 382), new TimeOnly(hour: 14, minute: 35, second: 57, millisecond: 72), }, { new TimeOnly(hour: 17, minute: 54, second: 58, millisecond: 367), new TimeOnly(hour: 18, minute: 58, second: 2, millisecond: 464), new TimeOnly(hour: 4, minute: 2, second: 17, millisecond: 363), }, { new TimeOnly(hour: 7, minute: 42, second: 25, millisecond: 692), new TimeOnly(hour: 15, minute: 26, second: 8, millisecond: 295), new TimeOnly(hour: 7, minute: 22, second: 49, millisecond: 591), }, }, { { new TimeOnly(hour: 10, minute: 37, second: 37, millisecond: 751), new TimeOnly(hour: 18, minute: 37, second: 0, millisecond: 979), new TimeOnly(hour: 15, minute: 41, second: 29, millisecond: 166), }, { new TimeOnly(hour: 8, minute: 16, second: 29, millisecond: 150), new TimeOnly(hour: 9, minute: 57, second: 49, millisecond: 255), new TimeOnly(hour: 0, minute: 47, second: 1, millisecond: 487), }, { new TimeOnly(hour: 10, minute: 24, second: 9, millisecond: 660), new TimeOnly(hour: 22, minute: 17, second: 17, millisecond: 364), new TimeOnly(hour: 21, minute: 50, second: 50, millisecond: 114), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 153,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 11, minute: 27, second: 48, millisecond: 402), new TimeOnly(hour: 21, minute: 36, second: 36, millisecond: 776), new TimeOnly(hour: 17, minute: 29, second: 31, millisecond: 733), }, { new TimeOnly(hour: 11, minute: 17, second: 49, millisecond: 732), new TimeOnly(hour: 8, minute: 5, second: 9, millisecond: 799), new TimeOnly(hour: 20, minute: 30, second: 44, millisecond: 294), }, { new TimeOnly(hour: 22, minute: 45, second: 16, millisecond: 634), new TimeOnly(hour: 6, minute: 37, second: 53, millisecond: 265), new TimeOnly(hour: 18, minute: 14, second: 3, millisecond: 472), }, }, { { new TimeOnly(hour: 15, minute: 17, second: 41, millisecond: 438), new TimeOnly(hour: 19, minute: 51, second: 28, millisecond: 938), new TimeOnly(hour: 11, minute: 39, second: 14, millisecond: 689), }, { new TimeOnly(hour: 18, minute: 21, second: 15, millisecond: 486), new TimeOnly(hour: 8, minute: 23, second: 49, millisecond: 776), new TimeOnly(hour: 5, minute: 5, second: 0, millisecond: 280), }, { new TimeOnly(hour: 14, minute: 57, second: 21, millisecond: 998), new TimeOnly(hour: 18, minute: 56, second: 31, millisecond: 632), new TimeOnly(hour: 10, minute: 53, second: 24, millisecond: 816), }, }, { { new TimeOnly(hour: 9, minute: 34, second: 29, millisecond: 710), new TimeOnly(hour: 16, minute: 25, second: 28, millisecond: 487), new TimeOnly(hour: 7, minute: 7, second: 24, millisecond: 223), }, { new TimeOnly(hour: 16, minute: 18, second: 16, millisecond: 566), new TimeOnly(hour: 11, minute: 21, second: 47, millisecond: 716), new TimeOnly(hour: 13, minute: 6, second: 7, millisecond: 511), }, { new TimeOnly(hour: 8, minute: 35, second: 11, millisecond: 15), new TimeOnly(hour: 0, minute: 3, second: 37, millisecond: 511), new TimeOnly(hour: 4, minute: 43, second: 51, millisecond: 602), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 92,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 20, minute: 24, second: 21, millisecond: 146), new TimeOnly(hour: 10, minute: 54, second: 44, millisecond: 545), new TimeOnly(hour: 20, minute: 36, second: 26, millisecond: 292), }, { new TimeOnly(hour: 3, minute: 42, second: 24, millisecond: 408), new TimeOnly(hour: 3, minute: 2, second: 42, millisecond: 104), new TimeOnly(hour: 4, minute: 6, second: 39, millisecond: 345), }, { new TimeOnly(hour: 13, minute: 7, second: 22, millisecond: 545), new TimeOnly(hour: 21, minute: 28, second: 40, millisecond: 947), new TimeOnly(hour: 12, minute: 8, second: 6, millisecond: 89), }, }, { { new TimeOnly(hour: 19, minute: 46, second: 24, millisecond: 277), new TimeOnly(hour: 1, minute: 48, second: 17, millisecond: 413), new TimeOnly(hour: 19, minute: 50, second: 25, millisecond: 243), }, { new TimeOnly(hour: 1, minute: 14, second: 41, millisecond: 656), new TimeOnly(hour: 5, minute: 19, second: 57, millisecond: 883), new TimeOnly(hour: 10, minute: 52, second: 47, millisecond: 420), }, { new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 416), new TimeOnly(hour: 18, minute: 7, second: 13, millisecond: 962), new TimeOnly(hour: 2, minute: 5, second: 52, millisecond: 409), }, }, { { new TimeOnly(hour: 5, minute: 20, second: 23, millisecond: 876), new TimeOnly(hour: 16, minute: 13, second: 25, millisecond: 731), new TimeOnly(hour: 5, minute: 6, second: 3, millisecond: 245), }, { new TimeOnly(hour: 4, minute: 37, second: 22, millisecond: 166), new TimeOnly(hour: 9, minute: 57, second: 10, millisecond: 146), new TimeOnly(hour: 5, minute: 20, second: 51, millisecond: 368), }, { new TimeOnly(hour: 21, minute: 48, second: 23, millisecond: 437), new TimeOnly(hour: 1, minute: 41, second: 37, millisecond: 386), new TimeOnly(hour: 2, minute: 41, second: 15, millisecond: 958), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 12, minute: 24, second: 14, millisecond: 657), new TimeOnly(hour: 3, minute: 57, second: 13, millisecond: 722), new TimeOnly(hour: 19, minute: 23, second: 18, millisecond: 562), }, { new TimeOnly(hour: 2, minute: 50, second: 54, millisecond: 573), new TimeOnly(hour: 11, minute: 51, second: 14, millisecond: 914), new TimeOnly(hour: 16, minute: 32, second: 38, millisecond: 317), }, { new TimeOnly(hour: 4, minute: 54, second: 39, millisecond: 478), new TimeOnly(hour: 1, minute: 46, second: 0, millisecond: 974), new TimeOnly(hour: 21, minute: 10, second: 1, millisecond: 446), }, }, { { new TimeOnly(hour: 5, minute: 24, second: 37, millisecond: 792), new TimeOnly(hour: 7, minute: 41, second: 27, millisecond: 358), new TimeOnly(hour: 2, minute: 49, second: 5, millisecond: 470), }, { new TimeOnly(hour: 1, minute: 52, second: 36, millisecond: 567), new TimeOnly(hour: 10, minute: 29, second: 49, millisecond: 419), new TimeOnly(hour: 21, minute: 4, second: 47, millisecond: 954), }, { new TimeOnly(hour: 11, minute: 3, second: 42, millisecond: 213), new TimeOnly(hour: 19, minute: 43, second: 6, millisecond: 557), new TimeOnly(hour: 3, minute: 7, second: 55, millisecond: 691), }, }, { { new TimeOnly(hour: 9, minute: 34, second: 48, millisecond: 677), new TimeOnly(hour: 21, minute: 21, second: 43, millisecond: 787), new TimeOnly(hour: 16, minute: 30, second: 1, millisecond: 136), }, { new TimeOnly(hour: 3, minute: 7, second: 29, millisecond: 507), new TimeOnly(hour: 19, minute: 40, second: 20, millisecond: 207), new TimeOnly(hour: 13, minute: 0, second: 44, millisecond: 521), }, { new TimeOnly(hour: 16, minute: 45, second: 11, millisecond: 146), new TimeOnly(hour: 20, minute: 21, second: 28, millisecond: 295), new TimeOnly(hour: 4, minute: 54, second: 27, millisecond: 674), }, }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 160,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 5, minute: 14, second: 21, millisecond: 947), new TimeOnly(hour: 19, minute: 33, second: 11, millisecond: 924), new TimeOnly(hour: 3, minute: 24, second: 32, millisecond: 370), }, { new TimeOnly(hour: 3, minute: 23, second: 31, millisecond: 634), new TimeOnly(hour: 19, minute: 7, second: 42, millisecond: 523), new TimeOnly(hour: 11, minute: 55, second: 35, millisecond: 445), }, { new TimeOnly(hour: 14, minute: 53, second: 25, millisecond: 447), new TimeOnly(hour: 0, minute: 37, second: 49, millisecond: 879), new TimeOnly(hour: 12, minute: 33, second: 20, millisecond: 242), }, }, { { new TimeOnly(hour: 5, minute: 31, second: 5, millisecond: 648), new TimeOnly(hour: 22, minute: 58, second: 16, millisecond: 138), new TimeOnly(hour: 8, minute: 25, second: 52, millisecond: 165), }, { new TimeOnly(hour: 2, minute: 28, second: 52, millisecond: 593), new TimeOnly(hour: 7, minute: 36, second: 25, millisecond: 795), new TimeOnly(hour: 8, minute: 7, second: 36, millisecond: 62), }, { new TimeOnly(hour: 16, minute: 24, second: 1, millisecond: 614), new TimeOnly(hour: 5, minute: 22, second: 36, millisecond: 292), new TimeOnly(hour: 7, minute: 29, second: 41, millisecond: 403), }, }, { { new TimeOnly(hour: 14, minute: 55, second: 30, millisecond: 676), new TimeOnly(hour: 19, minute: 0, second: 11, millisecond: 317), new TimeOnly(hour: 3, minute: 10, second: 3, millisecond: 3), }, { new TimeOnly(hour: 9, minute: 13, second: 21, millisecond: 76), new TimeOnly(hour: 17, minute: 57, second: 31, millisecond: 804), new TimeOnly(hour: 5, minute: 6, second: 11, millisecond: 695), }, { new TimeOnly(hour: 9, minute: 27, second: 55, millisecond: 411), new TimeOnly(hour: 6, minute: 31, second: 15, millisecond: 169), new TimeOnly(hour: 10, minute: 34, second: 9, millisecond: 190), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 16, minute: 12, second: 35, millisecond: 709), new TimeOnly(hour: 14, minute: 9, second: 16, millisecond: 774), new TimeOnly(hour: 11, minute: 25, second: 17, millisecond: 647), }, { new TimeOnly(hour: 13, minute: 40, second: 58, millisecond: 795), new TimeOnly(hour: 22, minute: 44, second: 28, millisecond: 55), new TimeOnly(hour: 22, minute: 9, second: 19, millisecond: 122), }, { new TimeOnly(hour: 1, minute: 7, second: 19, millisecond: 174), new TimeOnly(hour: 3, minute: 20, second: 27, millisecond: 213), new TimeOnly(hour: 15, minute: 46, second: 51, millisecond: 427), }, }, { { new TimeOnly(hour: 20, minute: 21, second: 23, millisecond: 61), new TimeOnly(hour: 15, minute: 12, second: 53, millisecond: 722), new TimeOnly(hour: 21, minute: 37, second: 25, millisecond: 370), }, { new TimeOnly(hour: 7, minute: 28, second: 34, millisecond: 826), new TimeOnly(hour: 10, minute: 7, second: 19, millisecond: 682), new TimeOnly(hour: 1, minute: 1, second: 54, millisecond: 932), }, { new TimeOnly(hour: 3, minute: 25, second: 35, millisecond: 543), new TimeOnly(hour: 0, minute: 5, second: 25, millisecond: 329), new TimeOnly(hour: 15, minute: 4, second: 53, millisecond: 843), }, }, { { new TimeOnly(hour: 12, minute: 32, second: 12, millisecond: 668), new TimeOnly(hour: 19, minute: 3, second: 15, millisecond: 257), new TimeOnly(hour: 5, minute: 45, second: 53, millisecond: 947), }, { new TimeOnly(hour: 11, minute: 4, second: 38, millisecond: 887), new TimeOnly(hour: 18, minute: 45, second: 40, millisecond: 257), new TimeOnly(hour: 9, minute: 51, second: 46, millisecond: 660), }, { new TimeOnly(hour: 20, minute: 52, second: 57, millisecond: 132), new TimeOnly(hour: 17, minute: 1, second: 53, millisecond: 817), new TimeOnly(hour: 18, minute: 51, second: 50, millisecond: 237), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 164,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 1, minute: 55, second: 28, millisecond: 496), new TimeOnly(hour: 21, minute: 2, second: 2, millisecond: 282), new TimeOnly(hour: 18, minute: 41, second: 53, millisecond: 261), }, { new TimeOnly(hour: 5, minute: 57, second: 18, millisecond: 133), new TimeOnly(hour: 16, minute: 12, second: 0, millisecond: 657), new TimeOnly(hour: 5, minute: 7, second: 13, millisecond: 134), }, { new TimeOnly(hour: 20, minute: 14, second: 28, millisecond: 101), new TimeOnly(hour: 2, minute: 53, second: 9, millisecond: 685), new TimeOnly(hour: 22, minute: 23, second: 13, millisecond: 766), }, }, { { new TimeOnly(hour: 11, minute: 15, second: 50, millisecond: 276), new TimeOnly(hour: 18, minute: 27, second: 12, millisecond: 224), new TimeOnly(hour: 0, minute: 49, second: 24, millisecond: 449), }, { new TimeOnly(hour: 15, minute: 35, second: 40, millisecond: 701), new TimeOnly(hour: 14, minute: 33, second: 32, millisecond: 673), new TimeOnly(hour: 8, minute: 54, second: 19, millisecond: 982), }, { new TimeOnly(hour: 22, minute: 24, second: 37, millisecond: 562), new TimeOnly(hour: 22, minute: 23, second: 6, millisecond: 697), new TimeOnly(hour: 4, minute: 37, second: 5, millisecond: 229), }, }, { { new TimeOnly(hour: 13, minute: 5, second: 39, millisecond: 4), new TimeOnly(hour: 16, minute: 57, second: 2, millisecond: 392), new TimeOnly(hour: 1, minute: 26, second: 11, millisecond: 488), }, { new TimeOnly(hour: 12, minute: 20, second: 21, millisecond: 692), new TimeOnly(hour: 9, minute: 43, second: 43, millisecond: 896), new TimeOnly(hour: 9, minute: 9, second: 46, millisecond: 857), }, { new TimeOnly(hour: 9, minute: 4, second: 19, millisecond: 134), new TimeOnly(hour: 9, minute: 13, second: 19, millisecond: 954), new TimeOnly(hour: 8, minute: 40, second: 43, millisecond: 314), }, }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD3E1MI
{
    Id = 98,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 11, minute: 46, second: 13, millisecond: 799), new TimeOnly(hour: 1, minute: 54, second: 29, millisecond: 527), new TimeOnly(hour: 3, minute: 53, second: 19, millisecond: 165), }, { new TimeOnly(hour: 10, minute: 27, second: 6, millisecond: 997), new TimeOnly(hour: 3, minute: 44, second: 11, millisecond: 322), new TimeOnly(hour: 0, minute: 8, second: 46, millisecond: 343), }, { new TimeOnly(hour: 5, minute: 35, second: 46, millisecond: 267), new TimeOnly(hour: 1, minute: 43, second: 31, millisecond: 590), new TimeOnly(hour: 15, minute: 34, second: 3, millisecond: 475), }, }, { { new TimeOnly(hour: 15, minute: 48, second: 42, millisecond: 675), new TimeOnly(hour: 15, minute: 49, second: 52, millisecond: 285), new TimeOnly(hour: 6, minute: 11, second: 15, millisecond: 457), }, { new TimeOnly(hour: 9, minute: 9, second: 36, millisecond: 370), new TimeOnly(hour: 4, minute: 45, second: 1, millisecond: 471), new TimeOnly(hour: 3, minute: 50, second: 10, millisecond: 952), }, { new TimeOnly(hour: 22, minute: 48, second: 12, millisecond: 165), new TimeOnly(hour: 21, minute: 22, second: 44, millisecond: 532), new TimeOnly(hour: 20, minute: 19, second: 41, millisecond: 197), }, }, { { new TimeOnly(hour: 11, minute: 46, second: 8, millisecond: 127), new TimeOnly(hour: 18, minute: 47, second: 52, millisecond: 26), new TimeOnly(hour: 16, minute: 28, second: 44, millisecond: 528), }, { new TimeOnly(hour: 0, minute: 18, second: 2, millisecond: 928), new TimeOnly(hour: 16, minute: 8, second: 9, millisecond: 817), new TimeOnly(hour: 19, minute: 31, second: 42, millisecond: 923), }, { new TimeOnly(hour: 21, minute: 32, second: 20, millisecond: 544), new TimeOnly(hour: 6, minute: 50, second: 41, millisecond: 300), new TimeOnly(hour: 6, minute: 43, second: 21, millisecond: 497), }, }, },
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 8, second: 35, millisecond: 673), new TimeOnly(hour: 13, minute: 57, second: 27, millisecond: 346), new TimeOnly(hour: 2, minute: 26, second: 7, millisecond: 840), }, { new TimeOnly(hour: 15, minute: 26, second: 7, millisecond: 326), new TimeOnly(hour: 13, minute: 44, second: 7, millisecond: 678), new TimeOnly(hour: 18, minute: 55, second: 25, millisecond: 165), }, { new TimeOnly(hour: 19, minute: 1, second: 0, millisecond: 865), new TimeOnly(hour: 16, minute: 28, second: 7, millisecond: 249), new TimeOnly(hour: 22, minute: 41, second: 27, millisecond: 352), }, }, { { new TimeOnly(hour: 6, minute: 32, second: 34, millisecond: 143), new TimeOnly(hour: 8, minute: 7, second: 5, millisecond: 297), new TimeOnly(hour: 5, minute: 51, second: 3, millisecond: 459), }, { new TimeOnly(hour: 16, minute: 45, second: 44, millisecond: 465), new TimeOnly(hour: 4, minute: 50, second: 50, millisecond: 142), new TimeOnly(hour: 18, minute: 29, second: 27, millisecond: 210), }, { new TimeOnly(hour: 18, minute: 30, second: 14, millisecond: 600), new TimeOnly(hour: 5, minute: 39, second: 25, millisecond: 414), new TimeOnly(hour: 9, minute: 42, second: 49, millisecond: 581), }, }, { { new TimeOnly(hour: 1, minute: 20, second: 7, millisecond: 871), new TimeOnly(hour: 17, minute: 28, second: 39, millisecond: 950), new TimeOnly(hour: 2, minute: 35, second: 18, millisecond: 446), }, { new TimeOnly(hour: 17, minute: 3, second: 3, millisecond: 373), new TimeOnly(hour: 20, minute: 20, second: 1, millisecond: 895), new TimeOnly(hour: 21, minute: 32, second: 39, millisecond: 567), }, { new TimeOnly(hour: 20, minute: 41, second: 17, millisecond: 598), new TimeOnly(hour: 22, minute: 39, second: 57, millisecond: 291), new TimeOnly(hour: 13, minute: 7, second: 30, millisecond: 96), }, }, },
},
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 18, minute: 53, second: 8, millisecond: 518), new TimeOnly(hour: 3, minute: 48, second: 13, millisecond: 521), new TimeOnly(hour: 4, minute: 33, second: 25, millisecond: 930), }, { new TimeOnly(hour: 12, minute: 40, second: 54, millisecond: 141), new TimeOnly(hour: 9, minute: 13, second: 8, millisecond: 574), new TimeOnly(hour: 12, minute: 8, second: 48, millisecond: 741), }, { new TimeOnly(hour: 12, minute: 47, second: 52, millisecond: 775), new TimeOnly(hour: 14, minute: 20, second: 24, millisecond: 488), new TimeOnly(hour: 19, minute: 50, second: 32, millisecond: 756), }, }, { { new TimeOnly(hour: 22, minute: 40, second: 48, millisecond: 162), new TimeOnly(hour: 15, minute: 48, second: 17, millisecond: 251), new TimeOnly(hour: 11, minute: 27, second: 9, millisecond: 880), }, { new TimeOnly(hour: 8, minute: 17, second: 1, millisecond: 194), new TimeOnly(hour: 22, minute: 29, second: 22, millisecond: 589), new TimeOnly(hour: 18, minute: 19, second: 3, millisecond: 157), }, { new TimeOnly(hour: 17, minute: 46, second: 17, millisecond: 31), new TimeOnly(hour: 18, minute: 22, second: 54, millisecond: 165), new TimeOnly(hour: 1, minute: 10, second: 55, millisecond: 339), }, }, { { new TimeOnly(hour: 5, minute: 19, second: 11, millisecond: 513), new TimeOnly(hour: 1, minute: 25, second: 15, millisecond: 998), new TimeOnly(hour: 19, minute: 44, second: 34, millisecond: 815), }, { new TimeOnly(hour: 4, minute: 33, second: 51, millisecond: 864), new TimeOnly(hour: 1, minute: 2, second: 34, millisecond: 120), new TimeOnly(hour: 1, minute: 5, second: 41, millisecond: 838), }, { new TimeOnly(hour: 8, minute: 38, second: 13, millisecond: 681), new TimeOnly(hour: 10, minute: 2, second: 58, millisecond: 890), new TimeOnly(hour: 10, minute: 12, second: 53, millisecond: 636), }, }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD3E1M
{
    Id = 169,
    Value = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 20, minute: 45, second: 58, millisecond: 252), new TimeOnly(hour: 10, minute: 52, second: 41, millisecond: 349), new TimeOnly(hour: 4, minute: 39, second: 45, millisecond: 219), }, { new TimeOnly(hour: 16, minute: 43, second: 55, millisecond: 345), new TimeOnly(hour: 20, minute: 32, second: 27, millisecond: 880), new TimeOnly(hour: 13, minute: 1, second: 33, millisecond: 694), }, { new TimeOnly(hour: 21, minute: 26, second: 15, millisecond: 928), new TimeOnly(hour: 20, minute: 16, second: 58, millisecond: 375), new TimeOnly(hour: 6, minute: 3, second: 50, millisecond: 357), }, }, { { new TimeOnly(hour: 2, minute: 30, second: 38, millisecond: 769), new TimeOnly(hour: 0, minute: 28, second: 32, millisecond: 203), new TimeOnly(hour: 18, minute: 24, second: 34, millisecond: 151), }, { new TimeOnly(hour: 12, minute: 29, second: 18, millisecond: 980), new TimeOnly(hour: 3, minute: 11, second: 34, millisecond: 962), new TimeOnly(hour: 9, minute: 17, second: 7, millisecond: 366), }, { new TimeOnly(hour: 10, minute: 33, second: 14, millisecond: 812), new TimeOnly(hour: 1, minute: 22, second: 4, millisecond: 843), new TimeOnly(hour: 5, minute: 34, second: 35, millisecond: 540), }, }, { { new TimeOnly(hour: 20, minute: 24, second: 40, millisecond: 207), new TimeOnly(hour: 10, minute: 35, second: 11, millisecond: 460), new TimeOnly(hour: 16, minute: 51, second: 10, millisecond: 359), }, { new TimeOnly(hour: 16, minute: 14, second: 45, millisecond: 647), new TimeOnly(hour: 13, minute: 31, second: 27, millisecond: 37), new TimeOnly(hour: 13, minute: 20, second: 14, millisecond: 148), }, { new TimeOnly(hour: 10, minute: 17, second: 47, millisecond: 746), new TimeOnly(hour: 13, minute: 18, second: 14, millisecond: 935), new TimeOnly(hour: 9, minute: 14, second: 19, millisecond: 4), }, }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,,] { { { new TimeOnly(hour: 20, minute: 52, second: 43, millisecond: 48), new TimeOnly(hour: 22, minute: 48, second: 53, millisecond: 178), new TimeOnly(hour: 5, minute: 8, second: 48, millisecond: 566), }, { new TimeOnly(hour: 16, minute: 26, second: 2, millisecond: 944), new TimeOnly(hour: 7, minute: 10, second: 36, millisecond: 579), new TimeOnly(hour: 18, minute: 43, second: 12, millisecond: 661), }, { new TimeOnly(hour: 18, minute: 57, second: 7, millisecond: 785), new TimeOnly(hour: 19, minute: 53, second: 31, millisecond: 941), new TimeOnly(hour: 14, minute: 44, second: 5, millisecond: 423), }, }, { { new TimeOnly(hour: 3, minute: 50, second: 33, millisecond: 132), new TimeOnly(hour: 9, minute: 6, second: 21, millisecond: 522), new TimeOnly(hour: 9, minute: 38, second: 57, millisecond: 406), }, { new TimeOnly(hour: 2, minute: 21, second: 48, millisecond: 235), new TimeOnly(hour: 6, minute: 5, second: 31, millisecond: 812), new TimeOnly(hour: 3, minute: 24, second: 34, millisecond: 930), }, { new TimeOnly(hour: 13, minute: 53, second: 36, millisecond: 686), new TimeOnly(hour: 17, minute: 49, second: 13, millisecond: 39), new TimeOnly(hour: 18, minute: 4, second: 25, millisecond: 882), }, }, { { new TimeOnly(hour: 4, minute: 2, second: 55, millisecond: 284), new TimeOnly(hour: 18, minute: 35, second: 48, millisecond: 462), new TimeOnly(hour: 20, minute: 51, second: 4, millisecond: 681), }, { new TimeOnly(hour: 0, minute: 52, second: 37, millisecond: 77), new TimeOnly(hour: 3, minute: 14, second: 51, millisecond: 461), new TimeOnly(hour: 2, minute: 53, second: 44, millisecond: 475), }, { new TimeOnly(hour: 14, minute: 40, second: 53, millisecond: 523), new TimeOnly(hour: 10, minute: 42, second: 54, millisecond: 974), new TimeOnly(hour: 5, minute: 10, second: 29, millisecond: 997), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd3e1mi(
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd3e1mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
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

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd3e1mi_id
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonemmarrayd3e1mi_id", 
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
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd3e1mi_id
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
    timeonlytime_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd3e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd3e1mi_id
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
    timeonlytime_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonemmarrayd3e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneMMArrayD3E1M> models = null;

                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneMMArrayD3E1M> models = null;

                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd3e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd3e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd3e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[2], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[3], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[4], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[30],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[31],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 115, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 91, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 24, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 44, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD3E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 24, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd3e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd3e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 94, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1m m
LEFT JOIN public.binary_timeonlytime_without_time_zonemmarrayd3e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonemmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI), typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MI>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD3E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD3))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

