

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
    internal partial interface INpgsqlIntervalMArrayintervalMMArrayD3
    {
    }
    
    internal partial class NpgsqlIntervalMArrayintervalMMArrayD3 : INpgsqlIntervalMArrayintervalMMArrayD3
    {


#region TestData

        private readonly NpgsqlIntervalintervalMMArrayD3E1M[] _testData = new NpgsqlIntervalintervalMMArrayD3E1M[]
        {
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4012), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4664), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 53), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1435), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2033), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2912), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4667), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 767), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2865), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4944), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 230), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4547), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4084), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 23), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2949), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2089), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 135), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 771), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2467), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3606), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 937), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4898), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 177), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3691), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2557), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4159), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3818), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1397), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3961), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1308), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 106), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 113), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3144), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1595), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1936), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 260), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2457), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4630), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4139), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2043), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4798), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3280), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1356), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4645), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1699), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 217), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 562), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1398), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4449), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4476), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3094), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1251), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2448), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4998), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1142), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3706), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4664), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3678), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3112), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 746), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 660), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3698), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2721), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 588), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4087), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 994), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2397), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4167), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1665), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4622), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 745), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4661), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 787), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2887), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2381), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4200), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1366), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4070), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3003), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 805), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3655), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2248), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 208), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3804), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1091), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4187), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 667), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2029), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 310), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3356), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 640), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3863), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2383), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4345), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1201), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1600), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 674), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1318), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 809), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4061), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 131), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3735), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2962), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2598), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1258), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1134), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3565), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1245), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3973), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 449), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 663), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1165), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 102), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1896), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3286), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2758), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4376), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 857), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2428), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1838), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2981), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1873), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3054), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 489), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 674), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2872), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2429), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2651), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3558), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3653), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 980), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3043), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 762), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3840), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3038), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1561), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1036), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2011), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4371), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3971), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2374), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1777), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2823), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 866), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3234), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 795), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2621), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1182), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3664), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4511), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1379), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2547), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2799), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2045), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1159), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 797), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4299), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 643), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1062), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2521), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2869), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1610), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3800), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 985), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1236), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1251), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4991), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4006), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3135), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 27), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3977), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2763), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3236), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1255), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 382), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2675), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3710), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 41), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1909), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2455), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2350), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3931), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 868), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2133), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2063), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1698), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1158), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 749), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3431), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3028), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 569), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 664), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3862), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2265), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 698), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3726), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 497), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1267), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4421), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3721), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4892), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 162), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4570), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3764), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2483), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4767), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1061), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4675), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3671), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4296), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1607), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3463), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2971), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2761), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 564), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 853), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3036), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3052), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1242), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4707), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4734), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4664), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4832), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1875), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3927), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 848), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4924), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4405), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1153), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4245), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3853), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4454), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4544), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4071), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4912), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4494), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2188), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2935), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 84), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3149), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3083), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3433), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2121), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3357), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3656), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 426), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3509), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 491), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 312), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2097), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 38), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3830), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1409), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 778), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4918), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3059), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4203), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2452), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1612), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3765), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 723), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3677), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2584), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 84), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1123), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2265), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1424), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2509), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1139), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 684), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2877), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4162), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 29), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1586), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2385), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 303), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 914), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1154), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3939), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 589), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2769), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3099), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4526), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3031), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4681), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 417), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3912), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 450), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4692), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3869), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 458), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2206), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4121), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1957), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3802), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 548), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3253), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1177), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4906), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1567), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2277), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 825), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2490), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1201), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 637), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3192), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1274), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2467), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1544), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4698), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4520), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1045), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1181), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2094), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1666), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4048), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3197), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1709), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4202), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3507), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3662), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1129), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1651), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4800), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 218), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1015), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 620), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 418), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3302), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 363), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1843), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3105), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 985), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3579), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2003), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1035), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1252), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4323), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 938), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1203), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 212), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2667), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 872), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3078), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1301), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4389), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 877), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3375), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2729), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4727), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2980), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2873), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1141), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2243), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1998), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2739), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4480), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3055), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 230), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1253), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3978), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3400), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1177), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4667), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3647), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 771), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3146), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1288), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3295), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3178), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1183), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2506), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4809), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1341), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2128), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3861), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3504), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3280), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1932), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3331), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3076), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 79), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3914), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4249), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1180), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1933), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1754), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3614), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 691), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 881), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4438), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2406), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4272), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4139), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1322), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4690), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2477), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4648), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3972), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3753), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1765), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1855), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 965), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1738), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 998), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1247), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2504), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4731), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3396), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2026), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4610), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3582), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3642), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1594), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2906), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1468), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1011), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4738), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1040), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2931), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2740), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 360), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4435), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2897), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2592), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2550), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3665), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4796), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3017), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 777), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4390), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 88), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4122), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1410), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 828), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 357), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1316), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4025), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 23), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2307), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3327), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2033), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3734), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4205), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4462), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4247), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3445), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4738), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4078), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4054), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4087), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2385), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4081), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 250), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2546), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 206), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 136), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3975), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1803), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 500), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 344), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3144), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 492), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3960), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4357), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2194), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2209), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4124), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4862), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1560), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 977), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 273), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2764), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2262), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 459), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 644), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1850), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4909), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1405), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3652), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2022), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3754), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2442), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3228), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4885), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2458), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4419), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1774), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2915), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3406), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4033), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4419), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3514), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4408), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 439), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2490), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4932), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4941), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 514), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1820), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4152), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2417), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2741), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4169), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1278), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1369), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4168), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1751), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4530), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1368), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 652), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 929), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3306), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 773), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4440), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 381), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2763), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1245), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 941), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2214), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4067), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2705), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2673), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1707), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 508), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3995), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3293), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1072), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1606), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1684), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 11), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4420), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1609), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3783), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1017), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1813), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2452), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 520), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 150), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1602), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2224), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 952), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1230), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 550), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1396), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2493), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3739), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3479), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 850), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2396), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 372), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 579), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3489), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1203), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 268), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 648), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4508), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 205), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 172), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3214), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3670), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2056), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1239), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3359), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1532), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 112), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3517), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3878), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4323), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4772), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3362), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3240), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3164), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4065), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3313), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1491), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4277), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4795), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2377), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4073), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1458), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4733), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1685), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4904), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3183), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 66), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2998), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 52), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4479), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4145), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4212), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2471), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4768), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4782), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3396), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4991), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2395), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1557), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1468), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2210), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 387), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3814), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3742), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 465), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 182), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4336), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2201), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1782), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 803), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3215), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4363), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1168), }, }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4094), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3845), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2844), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 551), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2542), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 808), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4850), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2721), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2093), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4912), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1066), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4308), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2482), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2117), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2755), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4796), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3722), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1049), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 891), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1607), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2514), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4424), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4031), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2559), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3321), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4464), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1649), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 809), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 501), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4896), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2297), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1587), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1828), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 72), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3101), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3817), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 381), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3723), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2169), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4841), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4226), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2101), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2005), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2183), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 336), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4380), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4745), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4202), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4958), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1714), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3932), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2894), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3985), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4124), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 219), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3193), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4764), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4356), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4679), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 664), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 255), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 403), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4578), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1629), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2336), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3163), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 343), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3652), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2433), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1847), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4546), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4559), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4843), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1728), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 582), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4154), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 533), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4445), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1077), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 122), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2107), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4621), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1626), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3816), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4832), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1540), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 627), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3248), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1288), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 281), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1108), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 344), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2834), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 562), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1538), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 494), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 167), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4415), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3056), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4584), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3995), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2002), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 544), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2953), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 553), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4726), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 551), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 762), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3488), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1103), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3607), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4893), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2010), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2408), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4979), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3531), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1309), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1932), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2412), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2393), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3627), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1406), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3618), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1175), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3159), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3296), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4965), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1072), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3808), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4685), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 525), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1708), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1618), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3382), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4908), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 403), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2558), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2550), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3104), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1073), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1091), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2517), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2598), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2459), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2329), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2735), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3110), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3945), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2635), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1309), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 579), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3861), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1992), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1353), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 299), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1260), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4218), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2038), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 14), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 222), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4348), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3761), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4908), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1792), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3072), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2109), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1565), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2929), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 826), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1145), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 581), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3755), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 420), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3158), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2578), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1034), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 200), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2650), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1783), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2616), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4243), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 923), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 375), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2603), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3370), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2411), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1584), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1632), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 727), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1203), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4626), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4424), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4983), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 632), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 614), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3649), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2147), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4051), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1327), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2514), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3836), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1507), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2166), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2505), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1889), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4509), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3855), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3865), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4978), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2904), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3702), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4049), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2360), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2434), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2831), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3096), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1406), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 301), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2381), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1805), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4438), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 469), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3940), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3399), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4156), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 436), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4420), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 531), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4691), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3706), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 701), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 460), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3332), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4291), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4590), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3258), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 192), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2506), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3833), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2443), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1136), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4748), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4909), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3220), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3282), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1169), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4179), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3785), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1163), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 287), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 966), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2593), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4516), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3142), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3555), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2403), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4081), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4636), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1404), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3663), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4708), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4713), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1922), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4579), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4234), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3358), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1454), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1363), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3565), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4589), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3884), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3829), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4933), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1277), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1386), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2263), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3127), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2171), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4383), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1299), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4840), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4645), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 512), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1539), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2495), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 470), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4793), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1983), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2146), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1965), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1000), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3698), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 340), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2114), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1734), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3216), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1141), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 621), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3197), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1703), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4815), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4659), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 787), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1802), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1669), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3456), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 384), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4437), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1667), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3846), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3885), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3675), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2351), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4175), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4717), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3721), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4932), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3132), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4858), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3552), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1525), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 206), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1503), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4201), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1999), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3527), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2156), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4366), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 815), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1434), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3961), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2757), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 570), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3957), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 231), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2908), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4977), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 25), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1108), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1731), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 629), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1492), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 717), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3632), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3451), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3459), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4333), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 247), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3176), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1899), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4319), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3242), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1767), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1154), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3522), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2864), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4545), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 110), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2381), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4107), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4576), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4569), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3870), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 624), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2177), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1957), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4893), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 937), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4367), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2415), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 738), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4323), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3529), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2683), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 73), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3317), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1718), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1882), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3730), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2604), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4507), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4488), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 426), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4206), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2929), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1896), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3982), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3258), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1577), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2465), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 124), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4173), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 273), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3508), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1088), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1468), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2889), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 960), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 976), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1174), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3566), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 404), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4514), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4851), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1610), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 411), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1120), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4931), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1545), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3588), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3214), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 997), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 151), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1761), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2186), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2651), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1088), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1912), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3243), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 790), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 193), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1228), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 940), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4526), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3784), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3055), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 121), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2713), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3808), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1736), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4089), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 494), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1032), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1078), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 41), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1644), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4027), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4505), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4147), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1200), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4165), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1687), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3658), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1508), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3945), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4505), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1829), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4177), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3545), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1544), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3880), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 518), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3727), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 713), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3427), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1134), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1024), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2159), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3215), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4482), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4338), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1836), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 548), }, }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4277), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3071), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4056), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4178), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1820), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2485), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1224), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 23), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2205), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2460), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1336), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 951), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3031), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3576), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 872), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4378), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4582), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2343), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2487), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1089), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1812), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1932), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1958), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1815), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4618), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 688), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2606), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 153), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2969), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2973), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4402), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3395), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4543), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2032), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4317), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3747), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1657), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 565), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1351), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2420), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4265), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2452), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 970), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 532), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1354), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3266), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 239), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4268), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 988), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2871), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4522), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1133), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3974), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3189), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1823), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4835), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4160), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1864), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 225), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1112), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3238), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2755), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4285), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2086), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4531), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3575), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4237), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4465), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 298), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 683), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3120), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4087), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1443), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4862), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 357), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1725), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3271), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4681), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2587), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2612), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2038), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4638), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1579), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 144), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2154), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1762), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 98), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 709), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4795), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4092), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1379), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 599), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1305), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3443), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2560), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3605), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 643), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2260), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2476), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2744), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4540), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4085), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1634), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4927), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1635), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1498), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4316), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4494), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4526), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4129), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3023), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1410), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3289), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1455), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4127), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 189), }, }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3027), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 110), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3982), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2239), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2703), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4888), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1709), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3129), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2468), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2304), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 408), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2115), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3838), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1938), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4620), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1209), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1026), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3701), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2300), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 220), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3032), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2896), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3233), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1463), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4214), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1743), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4013), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 525), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4001), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3402), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 400), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 716), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2051), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 182), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2900), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4702), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 850), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4197), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 458), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2555), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2961), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 364), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 59), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 241), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 360), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2238), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2282), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1968), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1184), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4051), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4343), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1074), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 704), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2077), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4842), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2776), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2692), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1935), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3087), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3397), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2640), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1422), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1730), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 934), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2823), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3009), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 983), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1667), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2563), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3231), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1719), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4669), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4767), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3111), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4540), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4130), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 649), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4204), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 128), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2500), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1515), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3300), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 781), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3649), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4714), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3398), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1959), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3535), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1458), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4508), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4903), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1924), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1529), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3309), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 971), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 302), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3000), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2461), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 819), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2128), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2807), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2410), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3639), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2635), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3404), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4348), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2320), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3625), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4577), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2207), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2714), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4177), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3612), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3881), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1758), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2084), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3439), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 88), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3674), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4982), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 312), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4221), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 391), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2863), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 453), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1928), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 950), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3992), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3909), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 399), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3163), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1020), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4263), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3343), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 404), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1395), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 478), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3273), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 846), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4125), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4101), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3506), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2931), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1976), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1362), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 105), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 437), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1262), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2046), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3949), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2174), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 260), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2481), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1972), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1736), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3708), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3050), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2840), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 604), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 339), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1315), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2968), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1392), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1318), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3610), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3943), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1119), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1517), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3373), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1094), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4806), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4811), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1294), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1307), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3484), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 834), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1692), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2946), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4798), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3735), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4778), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4177), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4315), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 997), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1514), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4890), }, }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 864), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 561), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2395), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1773), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4677), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4593), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 15), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3334), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4169), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 973), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1981), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1978), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2596), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 393), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3073), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1706), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 852), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1334), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1984), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1772), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3310), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 667), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 697), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2753), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 903), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 376), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4625), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4311), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2121), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3771), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2464), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2352), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1199), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4181), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 689), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3243), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3894), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4711), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 82), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2423), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3511), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3886), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4674), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1591), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1529), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3461), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1006), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3406), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2773), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4725), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1418), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4408), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1048), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4056), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2064), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1816), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 822), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 279), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4589), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1006), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4226), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4375), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2860), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 950), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3431), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4147), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2823), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 796), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4962), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2960), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 615), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2534), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3721), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2169), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 841), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3015), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 800), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1738), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 450), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4639), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1714), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4227), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 432), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4716), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2928), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1664), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1189), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1910), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 745), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1250), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4012), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2535), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3603), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3620), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3498), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 496), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2654), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1133), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 236), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4283), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4834), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3100), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1612), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2349), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1560), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1187), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2965), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4328), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2179), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2355), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2679), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 804), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2711), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1174), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2001), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 564), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1147), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1353), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 709), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1510), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2070), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3709), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 140), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 689), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1600), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1788), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1810), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2980), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2248), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1277), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1414), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 584), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1614), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 15), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3336), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2404), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4962), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2380), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 567), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4332), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4918), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1965), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2676), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2074), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3060), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2285), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2970), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2129), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2187), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 40), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4271), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3682), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4420), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1599), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1315), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1247), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1023), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2499), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3343), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1572), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3939), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2978), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3115), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 493), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 781), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 417), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4098), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4447), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4296), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3940), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2552), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3834), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3423), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1920), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2386), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 943), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4110), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3375), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4630), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1493), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3021), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3119), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4895), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4435), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1260), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1432), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3005), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3169), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3996), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1470), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4703), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 833), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4572), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3080), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4139), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1233), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 567), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4826), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 672), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4207), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3954), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4168), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1709), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2286), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1486), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4937), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1166), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3667), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2789), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4489), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175), }, }, },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3614), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2033), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2102), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2706), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2827), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1016), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3891), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2270), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2845), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1065), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 513), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 84), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4105), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1159), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3238), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3912), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3488), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 606), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3363), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1858), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1313), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1719), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 517), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 319), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3127), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1414), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3392), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 439), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4862), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2893), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3729), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2306), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 27), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 575), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4612), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4220), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3280), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3442), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4491), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3444), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3314), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3536), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1429), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3092), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2812), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2096), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3431), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1711), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4713), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4533), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2399), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3770), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3671), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3684), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3945), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2653), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4385), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3936), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1995), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1314), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1271), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2277), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2125), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4591), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4129), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 676), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4102), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 602), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2318), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 573), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 31), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 656), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3845), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1458), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 170), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4046), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3905), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4470), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4839), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4506), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3545), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3990), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 954), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3745), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1399), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1166), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2131), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2521), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 892), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4718), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2789), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 168), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1196), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1187), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4509), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4632), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1341), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1663), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2799), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1459), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4549), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3168), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 488), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3900), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3749), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3266), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4098), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1958), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2611), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3505), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 275), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4985), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4580), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 958), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4190), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 581), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1776), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1961), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 275), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1710), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2824), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2506), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2022), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3829), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4439), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4958), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4408), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3363), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2232), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2564), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2556), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3592), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1581), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3059), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4015), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2345), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1495), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4838), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2375), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3039), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2657), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3541), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 179), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3969), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4886), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4390), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4227), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4746), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 579), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 407), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4406), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2595), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 688), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 348), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 969), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3582), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2644), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3803), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3261), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 586), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1622), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3736), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1663), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3901), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 618), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4497), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3922), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3069), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4878), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4353), }, }, },
    ModelInner = new NpgsqlIntervalintervalMMArrayD3E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2721), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4386), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 938), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4638), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3003), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3626), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3174), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1445), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 559), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2059), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1710), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1020), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4465), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3196), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3439), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4934), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 95), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3518), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 242), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1331), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3541), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1065), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2320), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3001), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3684), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 361), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3734), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2783), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3922), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1989), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4925), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 876), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2138), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1278), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2260), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3421), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2470), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3693), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1256), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 626), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3379), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4912), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2156), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2715), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1736), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2398), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2057), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1662), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4751), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1891), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3274), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1785), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1335), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4486), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1542), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1409), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 141), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2545), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1260), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4430), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3492), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4642), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4793), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2306), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4794), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4006), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2583), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2911), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4896), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1172), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3173), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4971), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4065), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2795), }, }, },
},
            new NpgsqlIntervalintervalMMArrayD3E1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,,] { { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4272), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1903), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3825), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 561), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3998), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 653), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1670), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2924), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2060), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3640), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 210), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4228), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1201), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2865), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 988), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 262), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1345), }, }, { { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 655), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4056), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 186), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1186), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4622), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2188), }, { new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1265), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1205), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 964), }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd3e1mi(
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd3e1mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]), 
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

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd3e1mi_id
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalmmarrayd3e1mi_id", 
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
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd3e1mi_id
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
    npgsqlintervalintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd3e1mi_id
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
    npgsqlintervalintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalmmarrayd3e1mi_id", 
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
                List<NpgsqlIntervalintervalMMArrayD3E1M> models = null;

                models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalMMArrayD3E1M> models = null;

                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd3e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd3e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd3e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 149, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD3E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 169, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD3E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd3e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd3e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 53, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 89, 147))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD3E1MI),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD3E1M),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
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
FROM public.binary_npgsqlintervalintervalmmarrayd3e1m m
LEFT JOIN public.binary_npgsqlintervalintervalmmarrayd3e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
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
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
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
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
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
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
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
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MI), typeof(NpgsqlIntervalintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MI>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MI>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD3E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD3))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

