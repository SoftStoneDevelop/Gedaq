

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
    internal partial interface INpgsqlIntervalMArrayintervalMArrayD2
    {
    }
    
    internal partial class NpgsqlIntervalMArrayintervalMArrayD2 : INpgsqlIntervalMArrayintervalMArrayD2
    {


#region TestData

        private readonly NpgsqlIntervalintervalMArrayD2E1M[] _testData = new NpgsqlIntervalintervalMArrayD2E1M[]
        {
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 507), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4131),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4820),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1674), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2455),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 998), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2016),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 72), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4869), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2295),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1388), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1357),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1768), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1978),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4982),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3471), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4812),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1141), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4757),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 328), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2884),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2127), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1253),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1333), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2270),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4212), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1257),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3991), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3802),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 94), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4269),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2425), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1783),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3595), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2243),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1417), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 787),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 683), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3294),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2807), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2047),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2705), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2807),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4926), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3800),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2699), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4977),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 442), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1217),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 855), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 753),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 377), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2876),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4488), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 450), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1992),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3315),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3647), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1979),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 144), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4266),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 223), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2468),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3982), } },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3005),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 440), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2511),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2591), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2480),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3064), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2109), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4167), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2707),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 88), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4133),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4485), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4064),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2805), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3949),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 843), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3147),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4237), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 102),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 144),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2791), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2280), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2031),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1471), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3793),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 920), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3056),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2542), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1610),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2620),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1519), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 901),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4266), } },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 496),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2433), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 21),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2989), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1334),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3044), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 835),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4244), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1237),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1667),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3054), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1313),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 355), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 141),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1101), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1542),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2776), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2777),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1885), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3495), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 862),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4663), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1028),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3888), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1338),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3603), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1403),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1694), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 98),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4906), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4158),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1467), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4660),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2167), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4603),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3747), } },
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3932), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3052),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067), } },
    ModelInner = new NpgsqlIntervalintervalMArrayD21MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2148),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1193), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1153),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 973), } },
},
            new NpgsqlIntervalintervalMArrayD2E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlInterval[,] { {
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3747),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4619), } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd21mi(
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
INSERT INTO public.npgsqlintervalintervalmarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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

                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)), 
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
                methodParametrName: "npgsqlintervalintervalmarrayd21mi_id", 
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
                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd21mi_id
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
    npgsqlintervalintervalmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd21mi_id
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
    npgsqlintervalintervalmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                methodParametrName: "npgsqlintervalintervalmarrayd21mi_id", 
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
                List<NpgsqlIntervalintervalMArrayD2E1M> models = null;

                models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalMArrayD2E1M> models = null;

                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd21mi mi ON mi.id = m.npgsqlintervalintervalmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd21mi mi ON mi.id = m.npgsqlintervalintervalmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd21mi mi ON mi.id = m.npgsqlintervalintervalmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M), typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 49, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 152, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD2E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 170, query1, 176, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd2e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd21mi mi ON mi.id = m.npgsqlintervalintervalmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 128, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                NpgsqlIntervalintervalMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
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
FROM public.binary_npgsqlintervalintervalmarrayd2e1m m
LEFT JOIN public.binary_npgsqlintervalintervalmarrayd21mi mi ON mi.id = m.npgsqlintervalintervalmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models =  ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA), typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
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
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
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
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA), typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
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
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
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
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MI), typeof(NpgsqlIntervalintervalMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MI>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MI>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MI>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MI>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA), typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD21MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD2))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

