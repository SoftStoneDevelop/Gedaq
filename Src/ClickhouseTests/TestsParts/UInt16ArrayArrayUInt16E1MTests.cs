

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt16MArrayArrayArrayUInt16
    {
    }
    
    internal partial class UInt16MArrayArrayArrayUInt16 : IUInt16MArrayArrayArrayUInt16
    {


#region TestData

        private readonly UInt16ArrayArrayUInt16E1M[] _testData = new UInt16ArrayArrayUInt16E1M[]
        {
            new UInt16ArrayArrayUInt16E1M
{
    Id = 7,
    Value = 
new System.UInt16[,] { {
31498,
47695, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 6,
    Value = 
new System.UInt16[,] { {
38520,
54489, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 13,
    Value = 
new System.UInt16[,] { {
1350,
43740, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 8,
    Value = 
new System.UInt16[,] { {
20165,
50183, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
10535,
31295, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 18,
    Value = 
new System.UInt16[,] { {
52885,
18572, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 16,
    Value = 
new System.UInt16[,] { {
13082,
37368, } },
    NullableValue = 
new System.UInt16[,] { {
47039,
16204, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 24,
    Value = 
new System.UInt16[,] { {
38558,
8078, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 20,
    Value = 
new System.UInt16[,] { {
36006,
5348, } },
    NullableValue = 
new System.UInt16[,] { {
11322,
56882, } },
},
    NullableValue = 
new System.UInt16[,] { {
1899,
50716, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 25,
    Value = 
new System.UInt16[,] { {
9020,
3272, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 26,
    Value = 
new System.UInt16[,] { {
3468,
12397, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
21472,
28208, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 26,
    Value = 
new System.UInt16[,] { {
12381,
7994, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 34,
    Value = 
new System.UInt16[,] { {
63211,
41158, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
12515,
53800, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 35,
    Value = 
new System.UInt16[,] { {
45132,
3533, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 43,
    Value = 
new System.UInt16[,] { {
8914,
29082, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 43,
    Value = 
new System.UInt16[,] { {
10413,
20402, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 44,
    Value = 
new System.UInt16[,] { {
54162,
31736, } },
    NullableValue = 
new System.UInt16[,] { {
44460,
25756, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 52,
    Value = 
new System.UInt16[,] { {
6100,
28787, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 53,
    Value = 
new System.UInt16[,] { {
48531,
15117, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
26662,
47416, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 57,
    Value = 
new System.UInt16[,] { {
492,
62219, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 57,
    Value = 
new System.UInt16[,] { {
2000,
13979, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
53422,
61230, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 58,
    Value = 
new System.UInt16[,] { {
28537,
7181, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 61,
    Value = 
new System.UInt16[,] { {
40231,
18301, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
9289,
65342, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 60,
    Value = 
new System.UInt16[,] { {
17050,
65120, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 67,
    Value = 
new System.UInt16[,] { {
35122,
23332, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
17225,
5794, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 64,
    Value = 
new System.UInt16[,] { {
17507,
36723, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 69,
    Value = 
new System.UInt16[,] { {
36422,
51165, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 66,
    Value = 
new System.UInt16[,] { {
10322,
30572, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 70,
    Value = 
new System.UInt16[,] { {
616,
14703, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
35423,
8633, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 70,
    Value = 
new System.UInt16[,] { {
11051,
36414, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 76,
    Value = 
new System.UInt16[,] { {
17043,
23635, } },
    NullableValue = 
new System.UInt16[,] { {
63915,
9745, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 78,
    Value = 
new System.UInt16[,] { {
40140,
8261, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 80,
    Value = 
new System.UInt16[,] { {
12774,
17237, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 87,
    Value = 
new System.UInt16[,] { {
47863,
9180, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 86,
    Value = 
new System.UInt16[,] { {
23663,
38758, } },
    NullableValue = 
new System.UInt16[,] { {
51756,
31605, } },
},
    NullableValue = 
new System.UInt16[,] { {
543,
31767, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 93,
    Value = 
new System.UInt16[,] { {
50868,
23444, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 92,
    Value = 
new System.UInt16[,] { {
22581,
17703, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
16289,
46102, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 101,
    Value = 
new System.UInt16[,] { {
17442,
58633, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 93,
    Value = 
new System.UInt16[,] { {
53570,
36859, } },
    NullableValue = 
new System.UInt16[,] { {
35150,
21480, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 109,
    Value = 
new System.UInt16[,] { {
20950,
5315, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 102,
    Value = 
new System.UInt16[,] { {
34132,
32466, } },
    NullableValue = 
new System.UInt16[,] { {
21733,
44305, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 118,
    Value = 
new System.UInt16[,] { {
43212,
9884, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 105,
    Value = 
new System.UInt16[,] { {
39951,
21739, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
54957,
28866, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 124,
    Value = 
new System.UInt16[,] { {
58837,
53474, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 108,
    Value = 
new System.UInt16[,] { {
19483,
27098, } },
    NullableValue = 
new System.UInt16[,] { {
1538,
65064, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 125,
    Value = 
new System.UInt16[,] { {
58516,
431, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 110,
    Value = 
new System.UInt16[,] { {
12094,
57573, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 128,
    Value = 
new System.UInt16[,] { {
52713,
47026, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 114,
    Value = 
new System.UInt16[,] { {
50940,
37202, } },
    NullableValue = 
new System.UInt16[,] { {
12805,
62063, } },
},
    NullableValue = 
new System.UInt16[,] { {
8816,
45606, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 133,
    Value = 
new System.UInt16[,] { {
64876,
60606, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 116,
    Value = 
new System.UInt16[,] { {
33061,
41658, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
27848,
12102, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 142,
    Value = 
new System.UInt16[,] { {
56159,
29154, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 118,
    Value = 
new System.UInt16[,] { {
5880,
65180, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 150,
    Value = 
new System.UInt16[,] { {
46931,
38429, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 124,
    Value = 
new System.UInt16[,] { {
29524,
51156, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 152,
    Value = 
new System.UInt16[,] { {
29007,
38789, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 126,
    Value = 
new System.UInt16[,] { {
46804,
19161, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
61077,
32035, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 153,
    Value = 
new System.UInt16[,] { {
25550,
11348, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 133,
    Value = 
new System.UInt16[,] { {
42109,
14737, } },
    NullableValue = 
new System.UInt16[,] { {
51958,
1708, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 157,
    Value = 
new System.UInt16[,] { {
5284,
18185, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 136,
    Value = 
new System.UInt16[,] { {
65298,
24679, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
44887,
58350, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 159,
    Value = 
new System.UInt16[,] { {
13421,
48096, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 138,
    Value = 
new System.UInt16[,] { {
8908,
61, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 161,
    Value = 
new System.UInt16[,] { {
29517,
8957, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 139,
    Value = 
new System.UInt16[,] { {
3514,
33452, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { {
22850,
57865, } },
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 164,
    Value = 
new System.UInt16[,] { {
24610,
46401, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 148,
    Value = 
new System.UInt16[,] { {
35927,
62658, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 170,
    Value = 
new System.UInt16[,] { {
7292,
36773, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 153,
    Value = 
new System.UInt16[,] { {
3729,
8828, } },
    NullableValue = 
new System.UInt16[,] { {
22137,
50571, } },
},
    NullableValue = null,
},
            new UInt16ArrayArrayUInt16E1M
{
    Id = 172,
    Value = 
new System.UInt16[,] { {
47748,
18780, } },
    ModelInner = new UInt16ArrayArrayUInt161MI
{
    Id = 154,
    Value = 
new System.UInt16[,] { {
30632,
45346, } },
    NullableValue = 
new System.UInt16[,] { {
27565,
48710, } },
},
    NullableValue = 
new System.UInt16[,] { {
51015,
53053, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16arrayarrayuint16e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt16))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt16))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayArrayArrayUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt16MArrayArrayArrayUInt16)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt16MArrayArrayArrayUInt16)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint16arrayarrayuint16e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16ArrayArrayUInt16E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayArrayArrayUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt16MArrayArrayArrayUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayArrayUInt16E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt16MArrayArrayArrayUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16ArrayArrayUInt16E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

