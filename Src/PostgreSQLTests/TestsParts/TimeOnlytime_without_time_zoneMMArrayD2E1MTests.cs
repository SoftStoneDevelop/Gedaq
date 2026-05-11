

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
    internal partial interface ITimeOnlyMArraytime_without_time_zoneMMArrayD2
    {
    }
    
    internal partial class TimeOnlyMArraytime_without_time_zoneMMArrayD2 : ITimeOnlyMArraytime_without_time_zoneMMArrayD2
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneMMArrayD2E1M[] _testData = new TimeOnlytime_without_time_zoneMMArrayD2E1M[]
        {
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 9, minute: 32, second: 31, millisecond: 60), new TimeOnly(hour: 15, minute: 32, second: 48, millisecond: 928), }, { new TimeOnly(hour: 18, minute: 3, second: 43, millisecond: 528), new TimeOnly(hour: 8, minute: 12, second: 27, millisecond: 585), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 35, second: 36, millisecond: 263), new TimeOnly(hour: 15, minute: 0, second: 14, millisecond: 741), }, { new TimeOnly(hour: 18, minute: 42, second: 54, millisecond: 463), new TimeOnly(hour: 1, minute: 51, second: 19, millisecond: 162), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 17,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 4, minute: 43, second: 57, millisecond: 971), new TimeOnly(hour: 18, minute: 9, second: 15, millisecond: 359), }, { new TimeOnly(hour: 7, minute: 27, second: 53, millisecond: 293), new TimeOnly(hour: 10, minute: 8, second: 31, millisecond: 395), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 21, minute: 51, second: 41, millisecond: 440), new TimeOnly(hour: 22, minute: 7, second: 56, millisecond: 466), }, { new TimeOnly(hour: 17, minute: 13, second: 53, millisecond: 317), new TimeOnly(hour: 1, minute: 13, second: 6, millisecond: 486), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 14, minute: 31, second: 24, millisecond: 696), new TimeOnly(hour: 5, minute: 10, second: 4, millisecond: 373), }, { new TimeOnly(hour: 6, minute: 45, second: 30, millisecond: 201), new TimeOnly(hour: 13, minute: 11, second: 47, millisecond: 622), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 4, minute: 34, second: 7, millisecond: 926), new TimeOnly(hour: 7, minute: 10, second: 48, millisecond: 452), }, { new TimeOnly(hour: 5, minute: 2, second: 55, millisecond: 876), new TimeOnly(hour: 1, minute: 16, second: 15, millisecond: 686), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 14, minute: 5, second: 9, millisecond: 238), new TimeOnly(hour: 21, minute: 14, second: 4, millisecond: 750), }, { new TimeOnly(hour: 11, minute: 0, second: 2, millisecond: 232), new TimeOnly(hour: 22, minute: 29, second: 21, millisecond: 962), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 20, minute: 17, second: 4, millisecond: 799), new TimeOnly(hour: 8, minute: 37, second: 31, millisecond: 911), }, { new TimeOnly(hour: 19, minute: 31, second: 4, millisecond: 119), new TimeOnly(hour: 11, minute: 30, second: 32, millisecond: 834), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 14, minute: 13, second: 13, millisecond: 662), new TimeOnly(hour: 13, minute: 34, second: 15, millisecond: 202), }, { new TimeOnly(hour: 6, minute: 37, second: 52, millisecond: 124), new TimeOnly(hour: 12, minute: 45, second: 58, millisecond: 940), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 5, minute: 32, second: 34, millisecond: 566), new TimeOnly(hour: 6, minute: 37, second: 0, millisecond: 652), }, { new TimeOnly(hour: 20, minute: 26, second: 42, millisecond: 944), new TimeOnly(hour: 18, minute: 39, second: 53, millisecond: 304), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 0, minute: 19, second: 1, millisecond: 110), new TimeOnly(hour: 20, minute: 28, second: 33, millisecond: 871), }, { new TimeOnly(hour: 18, minute: 48, second: 47, millisecond: 587), new TimeOnly(hour: 5, minute: 4, second: 52, millisecond: 536), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 5, second: 31, millisecond: 74), new TimeOnly(hour: 5, minute: 50, second: 21, millisecond: 746), }, { new TimeOnly(hour: 1, minute: 40, second: 55, millisecond: 515), new TimeOnly(hour: 6, minute: 29, second: 5, millisecond: 475), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 6, minute: 58, second: 11, millisecond: 413), new TimeOnly(hour: 19, minute: 55, second: 46, millisecond: 960), }, { new TimeOnly(hour: 4, minute: 11, second: 16, millisecond: 708), new TimeOnly(hour: 0, minute: 28, second: 14, millisecond: 685), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 13, minute: 12, second: 1, millisecond: 803), new TimeOnly(hour: 19, minute: 15, second: 14, millisecond: 592), }, { new TimeOnly(hour: 15, minute: 39, second: 29, millisecond: 339), new TimeOnly(hour: 19, minute: 21, second: 54, millisecond: 120), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 21, minute: 33, second: 9, millisecond: 316), new TimeOnly(hour: 14, minute: 52, second: 0, millisecond: 938), }, { new TimeOnly(hour: 3, minute: 11, second: 54, millisecond: 959), new TimeOnly(hour: 20, minute: 28, second: 35, millisecond: 542), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 49, second: 21, millisecond: 198), new TimeOnly(hour: 15, minute: 34, second: 48, millisecond: 238), }, { new TimeOnly(hour: 11, minute: 12, second: 53, millisecond: 794), new TimeOnly(hour: 4, minute: 34, second: 47, millisecond: 278), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 12, minute: 48, second: 33, millisecond: 384), new TimeOnly(hour: 2, minute: 38, second: 48, millisecond: 302), }, { new TimeOnly(hour: 8, minute: 15, second: 47, millisecond: 330), new TimeOnly(hour: 6, minute: 31, second: 42, millisecond: 471), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 18, minute: 6, second: 36, millisecond: 704), new TimeOnly(hour: 14, minute: 9, second: 28, millisecond: 540), }, { new TimeOnly(hour: 2, minute: 52, second: 58, millisecond: 785), new TimeOnly(hour: 18, minute: 7, second: 54, millisecond: 180), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 17, minute: 16, second: 1, millisecond: 794), new TimeOnly(hour: 4, minute: 25, second: 20, millisecond: 772), }, { new TimeOnly(hour: 15, minute: 25, second: 39, millisecond: 127), new TimeOnly(hour: 14, minute: 25, second: 18, millisecond: 584), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 54,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 21, minute: 16, second: 7, millisecond: 195), new TimeOnly(hour: 22, minute: 13, second: 7, millisecond: 590), }, { new TimeOnly(hour: 13, minute: 5, second: 7, millisecond: 711), new TimeOnly(hour: 7, minute: 8, second: 40, millisecond: 521), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 7, second: 58, millisecond: 621), new TimeOnly(hour: 11, minute: 52, second: 11, millisecond: 299), }, { new TimeOnly(hour: 1, minute: 24, second: 39, millisecond: 616), new TimeOnly(hour: 18, minute: 21, second: 21, millisecond: 260), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 1, minute: 29, second: 33, millisecond: 446), new TimeOnly(hour: 21, minute: 42, second: 19, millisecond: 469), }, { new TimeOnly(hour: 20, minute: 33, second: 15, millisecond: 533), new TimeOnly(hour: 5, minute: 19, second: 39, millisecond: 42), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 45, second: 57, millisecond: 720), new TimeOnly(hour: 2, minute: 44, second: 24, millisecond: 363), }, { new TimeOnly(hour: 22, minute: 3, second: 46, millisecond: 376), new TimeOnly(hour: 2, minute: 52, second: 47, millisecond: 175), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 4, minute: 16, second: 56, millisecond: 230), new TimeOnly(hour: 3, minute: 21, second: 8, millisecond: 223), }, { new TimeOnly(hour: 14, minute: 54, second: 47, millisecond: 385), new TimeOnly(hour: 12, minute: 10, second: 46, millisecond: 243), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 12, minute: 48, second: 45, millisecond: 522), new TimeOnly(hour: 5, minute: 35, second: 28, millisecond: 665), }, { new TimeOnly(hour: 19, minute: 58, second: 57, millisecond: 855), new TimeOnly(hour: 22, minute: 50, second: 24, millisecond: 367), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 5, minute: 42, second: 33, millisecond: 773), new TimeOnly(hour: 10, minute: 0, second: 40, millisecond: 525), }, { new TimeOnly(hour: 12, minute: 41, second: 46, millisecond: 662), new TimeOnly(hour: 9, minute: 33, second: 25, millisecond: 438), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 13, minute: 56, second: 21, millisecond: 165), new TimeOnly(hour: 17, minute: 24, second: 37, millisecond: 527), }, { new TimeOnly(hour: 19, minute: 11, second: 37, millisecond: 175), new TimeOnly(hour: 22, minute: 4, second: 49, millisecond: 669), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 75,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 9, minute: 46, second: 50, millisecond: 950), new TimeOnly(hour: 16, minute: 5, second: 15, millisecond: 818), }, { new TimeOnly(hour: 5, minute: 30, second: 57, millisecond: 52), new TimeOnly(hour: 15, minute: 14, second: 45, millisecond: 329), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 6, minute: 9, second: 52, millisecond: 630), new TimeOnly(hour: 19, minute: 54, second: 25, millisecond: 112), }, { new TimeOnly(hour: 16, minute: 47, second: 17, millisecond: 378), new TimeOnly(hour: 2, minute: 14, second: 3, millisecond: 164), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 8, minute: 21, second: 27, millisecond: 842), new TimeOnly(hour: 11, minute: 1, second: 19, millisecond: 323), }, { new TimeOnly(hour: 9, minute: 5, second: 2, millisecond: 423), new TimeOnly(hour: 2, minute: 19, second: 40, millisecond: 212), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 35, second: 48, millisecond: 92), new TimeOnly(hour: 13, minute: 41, second: 37, millisecond: 478), }, { new TimeOnly(hour: 3, minute: 52, second: 9, millisecond: 311), new TimeOnly(hour: 19, minute: 49, second: 8, millisecond: 180), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 48, second: 19, millisecond: 582), new TimeOnly(hour: 1, minute: 46, second: 43, millisecond: 169), }, { new TimeOnly(hour: 13, minute: 25, second: 6, millisecond: 2), new TimeOnly(hour: 12, minute: 29, second: 6, millisecond: 102), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 1, minute: 48, second: 25, millisecond: 664), new TimeOnly(hour: 14, minute: 16, second: 48, millisecond: 698), }, { new TimeOnly(hour: 21, minute: 27, second: 9, millisecond: 648), new TimeOnly(hour: 0, minute: 3, second: 56, millisecond: 538), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 42, second: 8, millisecond: 410), new TimeOnly(hour: 22, minute: 40, second: 24, millisecond: 801), }, { new TimeOnly(hour: 3, minute: 22, second: 45, millisecond: 977), new TimeOnly(hour: 17, minute: 54, second: 22, millisecond: 871), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 57, second: 51, millisecond: 602), new TimeOnly(hour: 16, minute: 18, second: 11, millisecond: 913), }, { new TimeOnly(hour: 13, minute: 37, second: 27, millisecond: 212), new TimeOnly(hour: 12, minute: 45, second: 22, millisecond: 173), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 16, minute: 26, second: 26, millisecond: 623), new TimeOnly(hour: 20, minute: 30, second: 32, millisecond: 379), }, { new TimeOnly(hour: 3, minute: 50, second: 22, millisecond: 878), new TimeOnly(hour: 7, minute: 42, second: 0, millisecond: 924), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 15, minute: 43, second: 5, millisecond: 54), new TimeOnly(hour: 5, minute: 53, second: 10, millisecond: 981), }, { new TimeOnly(hour: 1, minute: 18, second: 23, millisecond: 93), new TimeOnly(hour: 5, minute: 19, second: 34, millisecond: 572), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 15, minute: 0, second: 2, millisecond: 107), new TimeOnly(hour: 12, minute: 52, second: 37, millisecond: 853), }, { new TimeOnly(hour: 18, minute: 17, second: 49, millisecond: 614), new TimeOnly(hour: 16, minute: 27, second: 14, millisecond: 37), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 21, second: 45, millisecond: 966), new TimeOnly(hour: 20, minute: 13, second: 8, millisecond: 94), }, { new TimeOnly(hour: 14, minute: 47, second: 49, millisecond: 832), new TimeOnly(hour: 3, minute: 53, second: 13, millisecond: 820), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 0, minute: 43, second: 31, millisecond: 418), new TimeOnly(hour: 10, minute: 22, second: 58, millisecond: 898), }, { new TimeOnly(hour: 1, minute: 42, second: 47, millisecond: 640), new TimeOnly(hour: 22, minute: 58, second: 1, millisecond: 11), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 14, minute: 55, second: 36, millisecond: 897), new TimeOnly(hour: 12, minute: 22, second: 58, millisecond: 139), }, { new TimeOnly(hour: 2, minute: 11, second: 13, millisecond: 41), new TimeOnly(hour: 22, minute: 45, second: 52, millisecond: 202), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 46, second: 58, millisecond: 547), new TimeOnly(hour: 10, minute: 57, second: 7, millisecond: 543), }, { new TimeOnly(hour: 14, minute: 25, second: 32, millisecond: 33), new TimeOnly(hour: 22, minute: 18, second: 46, millisecond: 268), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 14, minute: 37, second: 19, millisecond: 905), new TimeOnly(hour: 15, minute: 13, second: 16, millisecond: 393), }, { new TimeOnly(hour: 8, minute: 40, second: 20, millisecond: 73), new TimeOnly(hour: 21, minute: 15, second: 42, millisecond: 691), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 0, minute: 49, second: 53, millisecond: 749), new TimeOnly(hour: 14, minute: 49, second: 12, millisecond: 970), }, { new TimeOnly(hour: 3, minute: 33, second: 1, millisecond: 705), new TimeOnly(hour: 0, minute: 33, second: 20, millisecond: 699), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 9, minute: 46, second: 21, millisecond: 9), new TimeOnly(hour: 3, minute: 58, second: 47, millisecond: 277), }, { new TimeOnly(hour: 12, minute: 7, second: 51, millisecond: 801), new TimeOnly(hour: 3, minute: 31, second: 29, millisecond: 32), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 30, second: 21, millisecond: 457), new TimeOnly(hour: 4, minute: 46, second: 44, millisecond: 74), }, { new TimeOnly(hour: 2, minute: 41, second: 49, millisecond: 916), new TimeOnly(hour: 7, minute: 9, second: 34, millisecond: 143), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 27, second: 24, millisecond: 305), new TimeOnly(hour: 9, minute: 57, second: 43, millisecond: 510), }, { new TimeOnly(hour: 17, minute: 15, second: 9, millisecond: 909), new TimeOnly(hour: 4, minute: 25, second: 47, millisecond: 387), }, },
},
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 48, second: 2, millisecond: 439), new TimeOnly(hour: 16, minute: 47, second: 29, millisecond: 984), }, { new TimeOnly(hour: 3, minute: 7, second: 49, millisecond: 312), new TimeOnly(hour: 9, minute: 20, second: 15, millisecond: 51), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 2, minute: 12, second: 17, millisecond: 374), new TimeOnly(hour: 4, minute: 26, second: 54, millisecond: 41), }, { new TimeOnly(hour: 20, minute: 41, second: 23, millisecond: 648), new TimeOnly(hour: 19, minute: 0, second: 46, millisecond: 832), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 2, minute: 33, second: 18, millisecond: 444), new TimeOnly(hour: 8, minute: 4, second: 41, millisecond: 330), }, { new TimeOnly(hour: 21, minute: 45, second: 39, millisecond: 619), new TimeOnly(hour: 2, minute: 22, second: 12, millisecond: 735), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 15, minute: 27, second: 1, millisecond: 457), new TimeOnly(hour: 9, minute: 58, second: 25, millisecond: 126), }, { new TimeOnly(hour: 16, minute: 5, second: 40, millisecond: 287), new TimeOnly(hour: 15, minute: 36, second: 36, millisecond: 324), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 22, minute: 30, second: 37, millisecond: 507), new TimeOnly(hour: 19, minute: 15, second: 12, millisecond: 599), }, { new TimeOnly(hour: 15, minute: 4, second: 13, millisecond: 713), new TimeOnly(hour: 2, minute: 14, second: 5, millisecond: 831), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 57, second: 1, millisecond: 867), new TimeOnly(hour: 12, minute: 42, second: 1, millisecond: 204), }, { new TimeOnly(hour: 0, minute: 45, second: 55, millisecond: 247), new TimeOnly(hour: 22, minute: 10, second: 23, millisecond: 235), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 40, second: 22, millisecond: 146), new TimeOnly(hour: 14, minute: 44, second: 44, millisecond: 43), }, { new TimeOnly(hour: 14, minute: 11, second: 15, millisecond: 447), new TimeOnly(hour: 7, minute: 49, second: 38, millisecond: 386), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 0, minute: 49, second: 38, millisecond: 720), new TimeOnly(hour: 5, minute: 8, second: 13, millisecond: 62), }, { new TimeOnly(hour: 17, minute: 55, second: 10, millisecond: 789), new TimeOnly(hour: 1, minute: 9, second: 22, millisecond: 879), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 56, second: 0, millisecond: 675), new TimeOnly(hour: 10, minute: 39, second: 52, millisecond: 572), }, { new TimeOnly(hour: 8, minute: 9, second: 26, millisecond: 789), new TimeOnly(hour: 22, minute: 49, second: 30, millisecond: 457), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 11, minute: 18, second: 38, millisecond: 894), new TimeOnly(hour: 7, minute: 38, second: 46, millisecond: 726), }, { new TimeOnly(hour: 5, minute: 15, second: 9, millisecond: 403), new TimeOnly(hour: 7, minute: 43, second: 10, millisecond: 283), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 0, second: 54, millisecond: 983), new TimeOnly(hour: 11, minute: 29, second: 34, millisecond: 782), }, { new TimeOnly(hour: 19, minute: 40, second: 7, millisecond: 799), new TimeOnly(hour: 22, minute: 39, second: 22, millisecond: 435), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 165,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 0, second: 50, millisecond: 404), new TimeOnly(hour: 5, minute: 9, second: 4, millisecond: 741), }, { new TimeOnly(hour: 18, minute: 28, second: 8, millisecond: 728), new TimeOnly(hour: 8, minute: 51, second: 29, millisecond: 286), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 29, second: 22, millisecond: 299), new TimeOnly(hour: 19, minute: 49, second: 12, millisecond: 936), }, { new TimeOnly(hour: 12, minute: 11, second: 27, millisecond: 713), new TimeOnly(hour: 18, minute: 48, second: 25, millisecond: 720), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 4, second: 9, millisecond: 469), new TimeOnly(hour: 13, minute: 40, second: 2, millisecond: 35), }, { new TimeOnly(hour: 2, minute: 49, second: 21, millisecond: 558), new TimeOnly(hour: 5, minute: 24, second: 56, millisecond: 61), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 16, minute: 40, second: 28, millisecond: 702), new TimeOnly(hour: 6, minute: 33, second: 27, millisecond: 604), }, { new TimeOnly(hour: 3, minute: 9, second: 29, millisecond: 805), new TimeOnly(hour: 20, minute: 13, second: 21, millisecond: 832), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 20, minute: 51, second: 45, millisecond: 840), new TimeOnly(hour: 10, minute: 12, second: 4, millisecond: 938), }, { new TimeOnly(hour: 6, minute: 8, second: 13, millisecond: 93), new TimeOnly(hour: 21, minute: 57, second: 0, millisecond: 360), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 175,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 19, minute: 28, second: 47, millisecond: 191), new TimeOnly(hour: 17, minute: 45, second: 22, millisecond: 498), }, { new TimeOnly(hour: 5, minute: 19, second: 22, millisecond: 369), new TimeOnly(hour: 6, minute: 55, second: 4, millisecond: 174), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 10, minute: 20, second: 37, millisecond: 605), new TimeOnly(hour: 18, minute: 53, second: 2, millisecond: 700), }, { new TimeOnly(hour: 20, minute: 19, second: 44, millisecond: 823), new TimeOnly(hour: 4, minute: 38, second: 4, millisecond: 470), }, },
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 7, minute: 35, second: 34, millisecond: 82), new TimeOnly(hour: 2, minute: 51, second: 10, millisecond: 785), }, { new TimeOnly(hour: 16, minute: 20, second: 28, millisecond: 660), new TimeOnly(hour: 16, minute: 11, second: 34, millisecond: 219), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 184,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 4, minute: 33, second: 2, millisecond: 45), new TimeOnly(hour: 2, minute: 6, second: 20, millisecond: 965), }, { new TimeOnly(hour: 1, minute: 45, second: 52, millisecond: 562), new TimeOnly(hour: 12, minute: 49, second: 28, millisecond: 342), }, },
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 3, minute: 32, second: 29, millisecond: 178), new TimeOnly(hour: 14, minute: 54, second: 29, millisecond: 448), }, { new TimeOnly(hour: 8, minute: 0, second: 0, millisecond: 890), new TimeOnly(hour: 6, minute: 55, second: 24, millisecond: 426), }, },
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 193,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 2, minute: 38, second: 43, millisecond: 224), new TimeOnly(hour: 11, minute: 11, second: 13, millisecond: 886), }, { new TimeOnly(hour: 11, minute: 9, second: 23, millisecond: 304), new TimeOnly(hour: 3, minute: 4, second: 37, millisecond: 674), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 5, minute: 27, second: 32, millisecond: 612), new TimeOnly(hour: 13, minute: 10, second: 21, millisecond: 841), }, { new TimeOnly(hour: 9, minute: 42, second: 57, millisecond: 9), new TimeOnly(hour: 9, minute: 53, second: 26, millisecond: 778), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 15, minute: 21, second: 44, millisecond: 768), new TimeOnly(hour: 20, minute: 19, second: 53, millisecond: 717), }, { new TimeOnly(hour: 13, minute: 35, second: 16, millisecond: 266), new TimeOnly(hour: 12, minute: 11, second: 51, millisecond: 180), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 199,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 12, minute: 6, second: 19, millisecond: 817), new TimeOnly(hour: 7, minute: 18, second: 22, millisecond: 771), }, { new TimeOnly(hour: 4, minute: 32, second: 35, millisecond: 59), new TimeOnly(hour: 20, minute: 9, second: 18, millisecond: 540), }, },
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 207,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 5, minute: 49, second: 27, millisecond: 746), new TimeOnly(hour: 5, minute: 53, second: 43, millisecond: 915), }, { new TimeOnly(hour: 8, minute: 12, second: 47, millisecond: 256), new TimeOnly(hour: 7, minute: 38, second: 37, millisecond: 109), }, },
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 17, minute: 14, second: 53, millisecond: 952), new TimeOnly(hour: 1, minute: 30, second: 51, millisecond: 914), }, { new TimeOnly(hour: 20, minute: 31, second: 31, millisecond: 339), new TimeOnly(hour: 5, minute: 3, second: 54, millisecond: 977), }, },
    NullableValue = 
new System.TimeOnly[,] { { new TimeOnly(hour: 4, minute: 48, second: 46, millisecond: 81), new TimeOnly(hour: 19, minute: 3, second: 9, millisecond: 73), }, { new TimeOnly(hour: 12, minute: 30, second: 45, millisecond: 140), new TimeOnly(hour: 3, minute: 8, second: 49, millisecond: 503), }, },
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD2E1M
{
    Id = 214,
    Value = 
new System.TimeOnly[,] { { new TimeOnly(hour: 22, minute: 1, second: 35, millisecond: 792), new TimeOnly(hour: 6, minute: 47, second: 46, millisecond: 672), }, { new TimeOnly(hour: 20, minute: 20, second: 42, millisecond: 544), new TimeOnly(hour: 22, minute: 16, second: 2, millisecond: 924), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd2e1mi(
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd2e1mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]), 
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

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd2e1mi_id
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonemmarrayd2e1mi_id", 
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
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd2e1mi_id
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
    timeonlytime_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
INSERT INTO public.timeonlytime_without_time_zonemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd2e1mi_id
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
    timeonlytime_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonemmarrayd2e1mi_id", 
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
                List<TimeOnlytime_without_time_zoneMMArrayD2E1M> models = null;

                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneMMArrayD2E1M> models = null;

                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd2e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd2e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 199;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr2.Value = 167;
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 199;
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                parametr2.Value = 199;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd2e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 199;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 105, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 193, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 199, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 199, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 184, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD2E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd2e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd2e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 167, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 35, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1m m
LEFT JOIN public.binary_timeonlytime_without_time_zonemmarrayd2e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI), typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MI>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD2E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD2))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

