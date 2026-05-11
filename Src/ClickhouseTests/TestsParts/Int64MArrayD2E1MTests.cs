

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
    internal partial interface IInt64MArrayMArrayD2
    {
    }
    
    internal partial class Int64MArrayMArrayD2 : IInt64MArrayMArrayD2
    {


#region TestData

        private readonly Int64MArrayD2E1M[] _testData = new Int64MArrayD2E1M[]
        {
            new Int64MArrayD2E1M
{
    Id = 3,
    Value = 
new System.Int64[,] { {
956600791630599621L,
3225199147476427349L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Int64[,] { {
6254973798452777325L,
6509808241456763877L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { {
6521617827035775527L,
8794809830761262989L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int64[,] { {
7472662165454273041L,
6890823677576526124L, } },
    NullableValue = 
new System.Int64[,] { {
2860360040179805959L,
5548664922271321342L, } },
},
    NullableValue = 
new System.Int64[,] { {
7610796391265904671L,
8422427538432241488L, } },
},
            new Int64MArrayD2E1M
{
    Id = 11,
    Value = 
new System.Int64[,] { {
8144311424518833723L,
7934084055473633811L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int64[,] { {
2325402803374182885L,
5507220195393434984L, } },
    NullableValue = 
new System.Int64[,] { {
5581581360217244111L,
3066874397079911023L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 20,
    Value = 
new System.Int64[,] { {
121994762096505577L,
5898652148272969835L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Int64[,] { {
192636193290870800L,
2392494912326803303L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
2163481793931092090L,
4549660979035828684L, } },
},
            new Int64MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Int64[,] { {
5853598980083489624L,
5742383060701569507L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int64[,] { {
8608249173122188752L,
5844759175118270959L, } },
    NullableValue = 
new System.Int64[,] { {
1660583199552159124L,
8892180803459475966L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int64[,] { {
9065443832426318446L,
3993356615227542271L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Int64[,] { {
7135679860417311960L,
2397914490976123305L, } },
    NullableValue = 
new System.Int64[,] { {
2892427259725059205L,
1298601672447095726L, } },
},
    NullableValue = 
new System.Int64[,] { {
602932691214743152L,
1902798615513095463L, } },
},
            new Int64MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int64[,] { {
7002939760078432687L,
789448890872903198L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int64[,] { {
6413998905881010053L,
2316326997187125521L, } },
    NullableValue = 
new System.Int64[,] { {
4370743029465616826L,
6028888032937996391L, } },
},
    NullableValue = 
new System.Int64[,] { {
8925697689555851683L,
1953674798848805934L, } },
},
            new Int64MArrayD2E1M
{
    Id = 46,
    Value = 
new System.Int64[,] { {
233251082583225504L,
6479322641034570182L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int64[,] { {
7147179422874098714L,
2418387638561475416L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
7489369908425234238L,
1983696230527592948L, } },
},
            new Int64MArrayD2E1M
{
    Id = 54,
    Value = 
new System.Int64[,] { {
944823293251744276L,
8534401161519092246L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int64[,] { {
525628916190056045L,
6350105463728436770L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int64[,] { {
8598484529771193313L,
3837609059671136649L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { {
2682140663640318619L,
4893576289658601939L, } },
    NullableValue = 
new System.Int64[,] { {
4541768407041850020L,
2518975717717325810L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int64[,] { {
5412292452686048235L,
6743280946822001089L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { {
4827640069570986545L,
3443773444271558115L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 68,
    Value = 
new System.Int64[,] { {
2022161240216569830L,
718004300167536499L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Int64[,] { {
6113350572919102987L,
9059627962408616079L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
5718246272932222763L,
1183863688383621952L, } },
},
            new Int64MArrayD2E1M
{
    Id = 75,
    Value = 
new System.Int64[,] { {
4153864318088381246L,
8834230174831283986L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int64[,] { {
244528849368064913L,
3039146973486972646L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 84,
    Value = 
new System.Int64[,] { {
7384890506484020666L,
6065438568963887139L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int64[,] { {
3600758525994205276L,
1057280821796886686L, } },
    NullableValue = 
new System.Int64[,] { {
7942229484856002426L,
2735595401992145639L, } },
},
    NullableValue = 
new System.Int64[,] { {
4198336231634101977L,
907367206645361576L, } },
},
            new Int64MArrayD2E1M
{
    Id = 89,
    Value = 
new System.Int64[,] { {
7635091616647339584L,
3072600616505773716L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Int64[,] { {
2024520546960700076L,
3820856159600795211L, } },
    NullableValue = 
new System.Int64[,] { {
9158358546521687155L,
5731086221285855864L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int64[,] { {
2263408503326266709L,
1402739641425221255L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Int64[,] { {
2433372486564904231L,
7659984502416222198L, } },
    NullableValue = 
new System.Int64[,] { {
9194302363015801175L,
377997467578701371L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 100,
    Value = 
new System.Int64[,] { {
2665179166252871675L,
7215427202047927549L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int64[,] { {
1963847717991094945L,
503689387185445433L, } },
    NullableValue = 
new System.Int64[,] { {
3375740403993964805L,
1976542914143443722L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int64[,] { {
2211255108709471081L,
9054008263896823074L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.Int64[,] { {
3293923475587218729L,
3913150223561727741L, } },
    NullableValue = 
new System.Int64[,] { {
4610085773447099620L,
6002289764264354492L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 115,
    Value = 
new System.Int64[,] { {
4783967242394813782L,
2523244241024884700L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Int64[,] { {
2649376656977865418L,
541588478333565909L, } },
    NullableValue = 
new System.Int64[,] { {
1096460820869128317L,
8416271447544027187L, } },
},
    NullableValue = 
new System.Int64[,] { {
2025164115855485740L,
2412584823486439465L, } },
},
            new Int64MArrayD2E1M
{
    Id = 123,
    Value = 
new System.Int64[,] { {
3222424813479851932L,
8392573443303067937L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Int64[,] { {
1166236972944843186L,
294199795142649048L, } },
    NullableValue = 
new System.Int64[,] { {
222913410573813962L,
6553031945165332964L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Int64[,] { {
4334653179405319966L,
3389627657535872890L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int64[,] { {
1571853273062447496L,
8339889388207951131L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { {
7494838387554866646L,
7163646945785148082L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Int64[,] { {
7578750718296668574L,
3294772793712344993L, } },
    NullableValue = 
new System.Int64[,] { {
2873350482943028011L,
7204856576011518262L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 133,
    Value = 
new System.Int64[,] { {
5381684393949131618L,
596164921187800039L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Int64[,] { {
2447668325680154004L,
5572135217994779031L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int64[,] { {
7678674247697856302L,
697756281766759378L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int64[,] { {
5592967982863938234L,
7728082900513943706L, } },
    NullableValue = 
new System.Int64[,] { {
2862999355149752233L,
4349276150971745386L, } },
},
    NullableValue = 
new System.Int64[,] { {
5805553046715156139L,
474490332645410298L, } },
},
            new Int64MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int64[,] { {
5908510891281221898L,
4456997829733710968L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Int64[,] { {
125077475135565715L,
3019896033223334751L, } },
    NullableValue = 
new System.Int64[,] { {
6647403553387051740L,
6078361987368309050L, } },
},
    NullableValue = 
new System.Int64[,] { {
5060409760542727132L,
7553634067347843915L, } },
},
            new Int64MArrayD2E1M
{
    Id = 157,
    Value = 
new System.Int64[,] { {
7846904986887549506L,
3489233968576773099L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int64[,] { {
4409602780911796472L,
6700083473864894924L, } },
    NullableValue = 
new System.Int64[,] { {
3297826422022202598L,
894561888414196630L, } },
},
    NullableValue = 
new System.Int64[,] { {
1287236893736980343L,
8801160399482518703L, } },
},
            new Int64MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int64[,] { {
7324347751403774426L,
3092927303803477185L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int64[,] { {
70084361871769064L,
3884708598096833737L, } },
    NullableValue = 
new System.Int64[,] { {
3340504796301919394L,
4380439777344380696L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int64[,] { {
1732786593198707723L,
573289406582695860L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Int64[,] { {
441879072925765990L,
6764300126260327573L, } },
    NullableValue = 
new System.Int64[,] { {
8415177373229526376L,
5331044495828944313L, } },
},
    NullableValue = 
new System.Int64[,] { {
2247510035045078828L,
4414368858561282505L, } },
},
            new Int64MArrayD2E1M
{
    Id = 171,
    Value = 
new System.Int64[,] { {
2507335896250626209L,
7747462071415821975L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int64[,] { {
977829231746664844L,
7667977000467652023L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 178,
    Value = 
new System.Int64[,] { {
6003913229552380830L,
1418421217073519303L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int64[,] { {
2514157178792008476L,
68056731275935501L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 182,
    Value = 
new System.Int64[,] { {
8303792744038504929L,
6804679927082087254L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int64[,] { {
372372202837296044L,
2743222237547989067L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 184,
    Value = 
new System.Int64[,] { {
1065759405389139075L,
3803924345801503779L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Int64[,] { {
3583898167013504491L,
5610705369812907468L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 189,
    Value = 
new System.Int64[,] { {
1824371392878495785L,
795938829342076519L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 185,
    Value = 
new System.Int64[,] { {
8545619103258074702L,
1622709528705949531L, } },
    NullableValue = 
new System.Int64[,] { {
644511684095583495L,
2851074762764576389L, } },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 197,
    Value = 
new System.Int64[,] { {
636892635649997044L,
3099616808467415796L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 186,
    Value = 
new System.Int64[,] { {
7528150373879068711L,
5992280506252738704L, } },
    NullableValue = 
new System.Int64[,] { {
6645585799859660632L,
8151451680442582791L, } },
},
    NullableValue = 
new System.Int64[,] { {
1885984719575099696L,
856773802306214203L, } },
},
            new Int64MArrayD2E1M
{
    Id = 201,
    Value = 
new System.Int64[,] { {
3624412293293300002L,
6294197771526833515L, } },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 189,
    Value = 
new System.Int64[,] { {
2792918807602434759L,
8932168417072834903L, } },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { {
6058067219487843446L,
6177789189666340393L, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
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
                    await ((IInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
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
                    var models = await ((IInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

