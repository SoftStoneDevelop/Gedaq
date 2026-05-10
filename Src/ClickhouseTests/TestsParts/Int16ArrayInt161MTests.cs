

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
    internal partial interface IInt16ArrayArrayInt16
    {
    }
    
    internal partial class Int16ArrayArrayInt16 : IInt16ArrayArrayInt16
    {


#region TestData

        private readonly Int16ArrayInt161M[] _testData = new Int16ArrayInt161M[]
        {
            new Int16ArrayInt161M
{
    Id = 6,
    Value = 
new System.Int16[3]
{
20478,
3336,
32068,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 6,
    Value = 
new System.Int16[4]
{
2576,
21863,
21933,
21337,
},
    NullableValue = 
new System.Int16[3]
{
31737,
1215,
29132,
},
},
    NullableValue = 
new System.Int16[4]
{
4405,
10140,
27214,
2865,
},
},
            new Int16ArrayInt161M
{
    Id = 15,
    Value = 
new System.Int16[3]
{
1665,
14442,
15794,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 11,
    Value = 
new System.Int16[3]
{
26024,
23695,
4535,
},
    NullableValue = 
new System.Int16[4]
{
4605,
856,
1406,
13674,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 19,
    Value = 
new System.Int16[3]
{
27312,
2766,
32296,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 14,
    Value = 
new System.Int16[4]
{
25735,
27859,
31219,
32660,
},
    NullableValue = 
new System.Int16[4]
{
8810,
5920,
13896,
30060,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 20,
    Value = 
new System.Int16[4]
{
4740,
18000,
20972,
10398,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 17,
    Value = 
new System.Int16[4]
{
4277,
19898,
22307,
25581,
},
    NullableValue = 
new System.Int16[3]
{
1422,
11949,
17052,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 27,
    Value = 
new System.Int16[3]
{
26670,
26783,
3976,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 24,
    Value = 
new System.Int16[4]
{
6892,
10970,
28976,
23823,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 31,
    Value = 
new System.Int16[4]
{
13989,
10372,
7503,
32657,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 29,
    Value = 
new System.Int16[4]
{
19742,
23837,
23270,
10382,
},
    NullableValue = 
new System.Int16[4]
{
6571,
5924,
3967,
23626,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 35,
    Value = 
new System.Int16[3]
{
8804,
5001,
25099,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 38,
    Value = 
new System.Int16[4]
{
15656,
4899,
11794,
22744,
},
    NullableValue = 
new System.Int16[3]
{
8307,
14575,
7172,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 44,
    Value = 
new System.Int16[4]
{
1284,
27463,
15119,
15931,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 43,
    Value = 
new System.Int16[4]
{
2121,
22759,
5407,
9056,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 50,
    Value = 
new System.Int16[3]
{
5811,
2584,
2566,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 45,
    Value = 
new System.Int16[4]
{
303,
18939,
28201,
5353,
},
    NullableValue = 
new System.Int16[4]
{
26230,
29073,
1915,
3140,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 54,
    Value = 
new System.Int16[4]
{
18678,
10614,
12723,
1773,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 54,
    Value = 
new System.Int16[3]
{
9678,
25483,
18052,
},
    NullableValue = 
new System.Int16[3]
{
14798,
22775,
8940,
},
},
    NullableValue = 
new System.Int16[4]
{
29163,
31620,
7668,
6535,
},
},
            new Int16ArrayInt161M
{
    Id = 59,
    Value = 
new System.Int16[4]
{
16850,
27767,
23417,
7051,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 60,
    Value = 
new System.Int16[3]
{
24315,
9726,
628,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
29782,
11005,
2756,
16215,
},
},
            new Int16ArrayInt161M
{
    Id = 66,
    Value = 
new System.Int16[4]
{
8519,
32759,
10948,
3055,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 64,
    Value = 
new System.Int16[4]
{
24414,
20994,
24108,
31375,
},
    NullableValue = 
new System.Int16[4]
{
7436,
22089,
23836,
17483,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 70,
    Value = 
new System.Int16[3]
{
27450,
9057,
4319,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 71,
    Value = 
new System.Int16[3]
{
11399,
12617,
190,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 71,
    Value = 
new System.Int16[4]
{
24799,
8873,
20097,
7259,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 77,
    Value = 
new System.Int16[3]
{
6549,
8642,
13394,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 80,
    Value = 
new System.Int16[3]
{
15737,
20976,
24247,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 82,
    Value = 
new System.Int16[3]
{
31918,
4734,
18508,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
3055,
26460,
643,
},
},
            new Int16ArrayInt161M
{
    Id = 85,
    Value = 
new System.Int16[3]
{
28204,
28027,
16000,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 90,
    Value = 
new System.Int16[3]
{
9352,
5321,
28038,
},
    NullableValue = 
new System.Int16[3]
{
21381,
24072,
26424,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 88,
    Value = 
new System.Int16[4]
{
15084,
1474,
32487,
5102,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 93,
    Value = 
new System.Int16[4]
{
17612,
860,
32563,
2602,
},
    NullableValue = 
new System.Int16[3]
{
10554,
18260,
21431,
},
},
    NullableValue = 
new System.Int16[3]
{
15556,
27903,
20074,
},
},
            new Int16ArrayInt161M
{
    Id = 93,
    Value = 
new System.Int16[3]
{
11700,
20200,
10095,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 94,
    Value = 
new System.Int16[3]
{
28336,
32702,
2807,
},
    NullableValue = 
new System.Int16[4]
{
21214,
8219,
10993,
14763,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 96,
    Value = 
new System.Int16[3]
{
17840,
31770,
10758,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 98,
    Value = 
new System.Int16[3]
{
23948,
17546,
917,
},
    NullableValue = 
new System.Int16[4]
{
17499,
23942,
15604,
18707,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 104,
    Value = 
new System.Int16[4]
{
16999,
6512,
25622,
7930,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 103,
    Value = 
new System.Int16[4]
{
5574,
22240,
22857,
11332,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 105,
    Value = 
new System.Int16[3]
{
18095,
30403,
7572,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 105,
    Value = 
new System.Int16[3]
{
8022,
22698,
14814,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 111,
    Value = 
new System.Int16[4]
{
18558,
10431,
6402,
10761,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 112,
    Value = 
new System.Int16[4]
{
5232,
9553,
4724,
6790,
},
    NullableValue = 
new System.Int16[4]
{
12957,
2910,
21688,
12685,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 116,
    Value = 
new System.Int16[4]
{
20590,
3290,
10906,
11321,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 117,
    Value = 
new System.Int16[4]
{
20208,
12661,
15667,
18005,
},
    NullableValue = 
new System.Int16[3]
{
2977,
27546,
1896,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 121,
    Value = 
new System.Int16[3]
{
27761,
7656,
9785,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 124,
    Value = 
new System.Int16[3]
{
18910,
18335,
14144,
},
    NullableValue = 
new System.Int16[4]
{
29269,
28153,
10033,
28167,
},
},
    NullableValue = 
new System.Int16[3]
{
4671,
26110,
21408,
},
},
            new Int16ArrayInt161M
{
    Id = 128,
    Value = 
new System.Int16[4]
{
32196,
15634,
12026,
21700,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 128,
    Value = 
new System.Int16[4]
{
32441,
27613,
17473,
28704,
},
    NullableValue = 
new System.Int16[4]
{
3700,
3709,
22296,
28006,
},
},
    NullableValue = 
new System.Int16[4]
{
14439,
14968,
13758,
16797,
},
},
            new Int16ArrayInt161M
{
    Id = 135,
    Value = 
new System.Int16[3]
{
22235,
26609,
8738,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 132,
    Value = 
new System.Int16[4]
{
26270,
26283,
11926,
20428,
},
    NullableValue = 
new System.Int16[4]
{
21290,
15650,
19645,
6765,
},
},
    NullableValue = 
new System.Int16[4]
{
14347,
15519,
8443,
9584,
},
},
            new Int16ArrayInt161M
{
    Id = 142,
    Value = 
new System.Int16[4]
{
20,
17651,
6545,
13487,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 136,
    Value = 
new System.Int16[4]
{
29708,
25664,
761,
31756,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 151,
    Value = 
new System.Int16[4]
{
28047,
18170,
30630,
16292,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 137,
    Value = 
new System.Int16[3]
{
31569,
7262,
29139,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
11351,
6238,
22427,
},
},
            new Int16ArrayInt161M
{
    Id = 160,
    Value = 
new System.Int16[3]
{
9096,
29575,
25246,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 146,
    Value = 
new System.Int16[3]
{
23684,
30846,
19199,
},
    NullableValue = 
new System.Int16[3]
{
13329,
17134,
16640,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 168,
    Value = 
new System.Int16[3]
{
1037,
31576,
22373,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 149,
    Value = 
new System.Int16[3]
{
18060,
13855,
7642,
},
    NullableValue = 
new System.Int16[3]
{
6819,
7842,
21311,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 177,
    Value = 
new System.Int16[3]
{
25033,
32643,
23218,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 154,
    Value = 
new System.Int16[4]
{
25856,
6657,
30012,
29357,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[4]
{
22318,
16989,
31141,
27974,
},
},
            new Int16ArrayInt161M
{
    Id = 178,
    Value = 
new System.Int16[4]
{
2615,
7777,
1410,
16037,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 160,
    Value = 
new System.Int16[4]
{
31143,
29368,
32175,
20507,
},
    NullableValue = 
new System.Int16[3]
{
19345,
3562,
23881,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 181,
    Value = 
new System.Int16[3]
{
24758,
29843,
32028,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 166,
    Value = 
new System.Int16[4]
{
27477,
18274,
14711,
20400,
},
    NullableValue = 
new System.Int16[4]
{
6588,
9658,
703,
11125,
},
},
    NullableValue = null,
},
            new Int16ArrayInt161M
{
    Id = 186,
    Value = 
new System.Int16[4]
{
30722,
14284,
20062,
15830,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 170,
    Value = 
new System.Int16[4]
{
24937,
12755,
3670,
18407,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int16[3]
{
31053,
2678,
22316,
},
},
            new Int16ArrayInt161M
{
    Id = 188,
    Value = 
new System.Int16[3]
{
4427,
7939,
11847,
},
    ModelInner = new Int16ArrayInt161MI
{
    Id = 174,
    Value = 
new System.Int16[4]
{
30341,
11829,
14264,
9111,
},
    NullableValue = 
new System.Int16[4]
{
16727,
7735,
11732,
29455,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16arrayint161m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int16)}, 
    {mi_id:Int32},
    {mi_value:Array(Int16)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArrayArrayInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[]), 
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
                    await ((IInt16ArrayArrayInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16ArrayArrayInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16arrayint161m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16ArrayInt161M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16ArrayArrayInt16)),
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
                    var models = await ((IInt16ArrayArrayInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayInt161M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16ArrayArrayInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16ArrayInt161M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

