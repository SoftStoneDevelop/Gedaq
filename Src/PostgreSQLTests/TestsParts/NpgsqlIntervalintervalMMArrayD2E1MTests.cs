

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
    internal partial interface INpgsqlIntervalMArrayintervalMMArrayD2
    {
    }
    
    internal partial class NpgsqlIntervalMArrayintervalMMArrayD2 : INpgsqlIntervalMArrayintervalMMArrayD2
    {


#region TestData

        private readonly NpgsqlIntervalintervalMMArrayD2E1M[] _testData = new NpgsqlIntervalintervalMMArrayD2E1M[]
        {
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4694), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4501), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 776), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 426), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4020), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2748), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2331), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4164), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 519), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3761), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3206), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3157), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 767), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4157), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1665), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2441), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4638), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1204), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2421), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2216), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1347), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3929), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1298), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 600), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3325), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1199), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3992), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 877), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3675), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3698), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1117), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4030), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3272), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3830), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4889), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2151), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1821), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 529), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1467), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3988), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3954), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4461), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1306), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3649), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3375), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2673), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1234), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3268), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 295), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4646), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3960), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 192), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1899), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4672), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4104), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3504), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1155), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1999), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3231), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3166), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4240), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 404), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4233), }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1566), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3802), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1069), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 483), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1627), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1012), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4655), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1591), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1734), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1814), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1658), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 919), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1025), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4100), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3626), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 930), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3638), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4069), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2774), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 864), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3839), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4062), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3897), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1080), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4347), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 18), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1057), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4600), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3606), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2474), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4408), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3026), }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2742), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2266), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2702), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2844), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1836), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4727), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4762), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2408), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4690), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1380), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 775), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4801), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4286), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1298), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2360), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2958), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3090), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1080), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1492), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3088), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 918), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 221), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1120), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1051), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3271), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1168), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 119), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1464), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 423), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1119), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2613), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2832), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2730), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1305), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 901), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3036), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3183), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1668), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 645), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1089), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1064), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1682), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1453), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 355), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3268), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 933), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 804), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1603), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1872), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2226), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 817), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3797), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3005), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2076), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2885), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2953), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3269), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2468), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1090), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2327), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4310), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 116), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3842), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2346), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4184), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1317), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 63), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4920), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2946), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3749), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 502), }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1292), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2685), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3394), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1653), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4260), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 99), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1337), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3421), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3799), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1306), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 659), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1506), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 529), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1752), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3443), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2493), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4884), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2528), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4884), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3311), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3315), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4453), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1078), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4223), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 183), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3929), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 667), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3143), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4317), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 406), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2931), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 239), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4216), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4344), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 438), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 736), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4492), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3437), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4974), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2621), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4075), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3164), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2378), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3511), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2457), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1099), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3815), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2428), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 665), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 143), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2280), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3059), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2692), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3380), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3214), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4948), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1824), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1918), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4223), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3843), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1043), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2297), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1633), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 386), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3079), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1211), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1561), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1193), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 841), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4555), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4685), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1276), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1732), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 294), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3696), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3243), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2719), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3872), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4292), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 121), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2902), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4003), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 438), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 816), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3096), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2579), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2389), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1236), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1816), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4831), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2805), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2127), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4465), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4353), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2954), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3884), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3575), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3090), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 132), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2968), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2758), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3836), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 493), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3431), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4931), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4627), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2320), }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD2E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 99), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4920), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1702), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4557), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1008), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1209), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2592), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 831), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3821), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 391), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4602), }, },
},
            new NpgsqlIntervalintervalMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3372), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4934), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 644), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2441), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4682), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4336), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1031), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]), 
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

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd2e1mi_id
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
    npgsqlintervalintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd2e1mi_id
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
    npgsqlintervalintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalmmarrayd2e1mi_id", 
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
                List<NpgsqlIntervalintervalMMArrayD2E1M> models = null;

                models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalMMArrayD2E1M> models = null;

                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd2e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd2e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 91;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 13;
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd2e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 107, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd2e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 50, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
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
FROM public.binary_npgsqlintervalintervalmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlintervalintervalmmarrayd2e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
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
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
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
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
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
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
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
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MI), typeof(NpgsqlIntervalintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MI>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MI>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD2E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD2))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

