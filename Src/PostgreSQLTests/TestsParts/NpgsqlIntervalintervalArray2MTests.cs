

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
    internal partial interface INpgsqlIntervalListintervalArray
    {
    }
    
    internal partial class NpgsqlIntervalListintervalArray : INpgsqlIntervalListintervalArray
    {


#region TestData

        private readonly NpgsqlIntervalintervalArray2M[] _testData = new NpgsqlIntervalintervalArray2M[]
        {
            new NpgsqlIntervalintervalArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3560),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4678),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1905),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3657),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2168),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4599),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 777),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3851),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 800),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1737),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2439),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2904),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4401),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 660),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2875),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3094),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1825),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 789),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 95),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2317),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 818),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 937),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3979),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3086),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4888),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 218),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 907),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3196),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 722),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3017),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4722),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3334),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2809),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3085),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 606),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 128),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4839),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4674),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3184),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2147),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2827),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2532),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3373),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1317),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2733),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 488),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4952),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4346),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3207),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1679),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2819),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1249),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 235),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3459),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2015),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 933),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2617),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1523),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 676),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4768),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 457),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3727),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4753),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1290),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1429),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1402),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2423),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 7),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2650),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1691),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3320),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 745),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1357),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2525),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1217),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4505),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2404),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 379),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 33),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3676),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 43),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4958),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3583),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4112),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1931),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1034),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 621),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4983),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 278),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4236),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2928),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1691),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 317),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2379),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1191),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4113),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3974),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3028),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2360),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3950),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2681),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 767),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 86),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1927),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3333),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 910),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3820),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3021),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4042),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1331),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4836),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 761),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4964),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1089),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4137),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 245),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3294),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1327),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4520),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2754),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3724),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 780),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3177),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3567),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4107),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1325),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3516),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3227),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3209),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 826),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4372),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1249),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 627),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4937),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1040),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1640),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1910),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 103),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3732),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3478),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2196),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4289),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4742),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2169),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1658),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4993),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3824),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4526),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3927),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 317),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2913),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2901),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4967),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1583),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4272),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2224),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2240),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3989),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4614),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4181),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 430),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1664),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1099),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3612),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4260),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4551),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2605),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4858),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2534),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1527),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 174),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 760),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1840),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1758),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1339),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2264),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2949),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 670),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1681),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3075),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3523),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4886),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2956),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2mi(
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
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

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
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
                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
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
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
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
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
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
                List<NpgsqlIntervalintervalArray2M> models = null;

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray2M> models = null;

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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

                var models = await ((INpgsqlIntervalListintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlIntervalListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
                var models = await ((INpgsqlIntervalListintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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

                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 24, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 86, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
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
                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatch(connection, 68, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
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
                await using var cmd = await ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlIntervalListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlIntervalListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
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
FROM public.binary_npgsqlintervalintervalarray2m m
LEFT JOIN public.binary_npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray2M>(15);

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
                ((INpgsqlIntervalListintervalArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlIntervalListintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

