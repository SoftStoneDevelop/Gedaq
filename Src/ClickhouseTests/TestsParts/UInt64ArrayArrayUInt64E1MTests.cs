

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
    internal partial interface IUInt64MArrayArrayArrayUInt64
    {
    }
    
    internal partial class UInt64MArrayArrayArrayUInt64 : IUInt64MArrayArrayArrayUInt64
    {


#region TestData

        private readonly UInt64ArrayArrayUInt64E1M[] _testData = new UInt64ArrayArrayUInt64E1M[]
        {
            new UInt64ArrayArrayUInt64E1M
{
    Id = 4,
    Value = 
new System.UInt64[,] { {
2878901103230781382L,
7019591453153528892L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 8,
    Value = 
new System.UInt64[,] { {
6848119435391845873L,
4670817864432475353L, } },
    NullableValue = 
new System.UInt64[,] { {
9034132443895349996L,
6471685897422196468L, } },
},
    NullableValue = 
new System.UInt64[,] { {
2971484157881779613L,
6268760341011331743L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 11,
    Value = 
new System.UInt64[,] { {
7445022828780467474L,
347474859225421237L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 16,
    Value = 
new System.UInt64[,] { {
3704972543146576752L,
955253706824053501L, } },
    NullableValue = 
new System.UInt64[,] { {
6742302902421840549L,
875110211501879752L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 12,
    Value = 
new System.UInt64[,] { {
3678370121754029395L,
8695721595411356016L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 17,
    Value = 
new System.UInt64[,] { {
2756800941744564481L,
3216940408332569152L, } },
    NullableValue = 
new System.UInt64[,] { {
5102924201329597272L,
6304615864164410829L, } },
},
    NullableValue = 
new System.UInt64[,] { {
1317788304469207603L,
5528838506924994145L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 18,
    Value = 
new System.UInt64[,] { {
7070296502234760194L,
3604618836541817090L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 19,
    Value = 
new System.UInt64[,] { {
1874217868899969982L,
3451165376251934228L, } },
    NullableValue = 
new System.UInt64[,] { {
1691215107971965846L,
7300762686404490903L, } },
},
    NullableValue = 
new System.UInt64[,] { {
3430651803842686654L,
6075738511608780032L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 21,
    Value = 
new System.UInt64[,] { {
8763596879908031455L,
291601586542731087L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 25,
    Value = 
new System.UInt64[,] { {
7581491689599428197L,
8471011218217623705L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 29,
    Value = 
new System.UInt64[,] { {
3938566248869095227L,
7164269229468416917L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 32,
    Value = 
new System.UInt64[,] { {
7895331286359853296L,
4652164468331608617L, } },
    NullableValue = 
new System.UInt64[,] { {
8009770549573000110L,
2716115617939058654L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 38,
    Value = 
new System.UInt64[,] { {
9192803670038508565L,
6692540873175760623L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 41,
    Value = 
new System.UInt64[,] { {
3351084551546220344L,
2542608677107847656L, } },
    NullableValue = 
new System.UInt64[,] { {
6749410576108141947L,
4812411589664059026L, } },
},
    NullableValue = 
new System.UInt64[,] { {
8263929617447870095L,
7458335491906558872L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 39,
    Value = 
new System.UInt64[,] { {
514560032765259004L,
8822715863219807544L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 47,
    Value = 
new System.UInt64[,] { {
9038005568412743025L,
4877607344310783030L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
9151839405367987845L,
7804925283133652816L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 46,
    Value = 
new System.UInt64[,] { {
3304277593626337840L,
7647656074980310363L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 56,
    Value = 
new System.UInt64[,] { {
8617850974978590979L,
1855063733313463039L, } },
    NullableValue = 
new System.UInt64[,] { {
2783777740051429508L,
1276587185411538878L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 47,
    Value = 
new System.UInt64[,] { {
5725631338962316230L,
8992691383955710826L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 63,
    Value = 
new System.UInt64[,] { {
908874246808716024L,
3617216299291787684L, } },
    NullableValue = 
new System.UInt64[,] { {
3534572088301201660L,
4338300028572243770L, } },
},
    NullableValue = 
new System.UInt64[,] { {
3696776917946371304L,
4696245417453892028L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 51,
    Value = 
new System.UInt64[,] { {
1367721054580550003L,
5315490970557581087L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 65,
    Value = 
new System.UInt64[,] { {
4748325676206008909L,
1046137518813241845L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 53,
    Value = 
new System.UInt64[,] { {
5153738903242683173L,
8632692800153248734L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 68,
    Value = 
new System.UInt64[,] { {
4225867571643856777L,
5319226792652223861L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 62,
    Value = 
new System.UInt64[,] { {
3731224721408255949L,
6674170510014801382L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 76,
    Value = 
new System.UInt64[,] { {
5438465494628148422L,
6114688296078537702L, } },
    NullableValue = 
new System.UInt64[,] { {
6165085270491092401L,
7280851314134063454L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 65,
    Value = 
new System.UInt64[,] { {
5743716551235071699L,
4213249120487136287L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 85,
    Value = 
new System.UInt64[,] { {
7599026340624317905L,
1196488383310967178L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
6064556825358191902L,
4090970096142925192L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 73,
    Value = 
new System.UInt64[,] { {
6188705190007169847L,
243769014028512869L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 94,
    Value = 
new System.UInt64[,] { {
3450575335156078844L,
4644064768628772223L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 74,
    Value = 
new System.UInt64[,] { {
1808111581878926339L,
7589758785155738825L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 102,
    Value = 
new System.UInt64[,] { {
7445071084221573725L,
3451006916387940848L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 83,
    Value = 
new System.UInt64[,] { {
25191743745833215L,
7490577961130994359L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 106,
    Value = 
new System.UInt64[,] { {
8326846713137897431L,
1443612498309616825L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
891609434710138205L,
7231474010959693813L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 90,
    Value = 
new System.UInt64[,] { {
8265050894211985081L,
7053758761437953619L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 107,
    Value = 
new System.UInt64[,] { {
4091687828441750593L,
8862711669896179042L, } },
    NullableValue = 
new System.UInt64[,] { {
248387992295493341L,
4150398939527935597L, } },
},
    NullableValue = 
new System.UInt64[,] { {
5136876511482295823L,
1690027265972963022L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 93,
    Value = 
new System.UInt64[,] { {
3218727291013852848L,
5187274314650740907L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 111,
    Value = 
new System.UInt64[,] { {
6710199303526824888L,
7416073243196129494L, } },
    NullableValue = 
new System.UInt64[,] { {
8960124836629765349L,
1512385064264671643L, } },
},
    NullableValue = 
new System.UInt64[,] { {
6403489373036338514L,
6699749724550660747L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 95,
    Value = 
new System.UInt64[,] { {
77610061661042178L,
2612021634357418596L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 119,
    Value = 
new System.UInt64[,] { {
3058874234860627329L,
1979851054937771723L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 98,
    Value = 
new System.UInt64[,] { {
5258854909803244481L,
8134480938599781861L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 123,
    Value = 
new System.UInt64[,] { {
6338904188810176959L,
1617403262060574039L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
7715648058510371566L,
792040511683244044L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 107,
    Value = 
new System.UInt64[,] { {
5253458925992194721L,
626818787754678029L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 131,
    Value = 
new System.UInt64[,] { {
252608112111978764L,
4111598795668279600L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
2989454334951477970L,
8599276349077736939L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 112,
    Value = 
new System.UInt64[,] { {
7138336937428294847L,
4424608095259208727L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 135,
    Value = 
new System.UInt64[,] { {
4963364707623983307L,
7256308489326263785L, } },
    NullableValue = 
new System.UInt64[,] { {
7011797964795658015L,
434477305700402418L, } },
},
    NullableValue = 
new System.UInt64[,] { {
5213748593323234119L,
1783611064464773885L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 117,
    Value = 
new System.UInt64[,] { {
1127761169141062011L,
9000251804349582123L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 140,
    Value = 
new System.UInt64[,] { {
8194286118355202253L,
2703733879960991528L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 123,
    Value = 
new System.UInt64[,] { {
4525291598272889782L,
7533008463789149172L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 149,
    Value = 
new System.UInt64[,] { {
4433160041274824737L,
3393700692352957463L, } },
    NullableValue = 
new System.UInt64[,] { {
626160013854445563L,
5187400153502645906L, } },
},
    NullableValue = 
new System.UInt64[,] { {
1975713212453846400L,
1110349502252310397L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 131,
    Value = 
new System.UInt64[,] { {
1349535250603725536L,
4394520715431269104L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 155,
    Value = 
new System.UInt64[,] { {
2832655387545065373L,
2437710464939070412L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
4565622065965217691L,
4166685107161075841L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 132,
    Value = 
new System.UInt64[,] { {
8863248539642609777L,
7367491111453757414L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 162,
    Value = 
new System.UInt64[,] { {
1963516250419375017L,
7488563433665807581L, } },
    NullableValue = 
new System.UInt64[,] { {
1735225705070576015L,
7190920179464436549L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 134,
    Value = 
new System.UInt64[,] { {
3271436208684323229L,
3558558853791716881L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 166,
    Value = 
new System.UInt64[,] { {
5138665548784152949L,
7453625114272400956L, } },
    NullableValue = 
new System.UInt64[,] { {
6886350607204753943L,
2737600593900059351L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 135,
    Value = 
new System.UInt64[,] { {
154787999631373827L,
8164058607580838134L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 172,
    Value = 
new System.UInt64[,] { {
3924342927298067767L,
5148729060893703822L, } },
    NullableValue = 
new System.UInt64[,] { {
531335206574038518L,
6868031847117506378L, } },
},
    NullableValue = 
new System.UInt64[,] { {
6954648613952012125L,
4069684295841404553L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 139,
    Value = 
new System.UInt64[,] { {
1187515711685100839L,
6445105069328384058L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 180,
    Value = 
new System.UInt64[,] { {
7847950056737418578L,
471490806085835477L, } },
    NullableValue = 
new System.UInt64[,] { {
4201359036078091709L,
4884677760418178530L, } },
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 144,
    Value = 
new System.UInt64[,] { {
1648788189904911458L,
8226050648573121277L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 184,
    Value = 
new System.UInt64[,] { {
8159723161522942783L,
5885410455294210323L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
5370784472737481765L,
1091121834913043500L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 152,
    Value = 
new System.UInt64[,] { {
5391201334441877682L,
4954692170741942355L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 185,
    Value = 
new System.UInt64[,] { {
4374777051119954181L,
2252495697064105601L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 153,
    Value = 
new System.UInt64[,] { {
6226571273643400358L,
6600609411135226859L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 189,
    Value = 
new System.UInt64[,] { {
1382021992848880580L,
3575272133031548842L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
302134600338887380L,
7208721450859154233L, } },
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 162,
    Value = 
new System.UInt64[,] { {
8339999203842535785L,
3381664633718399864L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 197,
    Value = 
new System.UInt64[,] { {
5440631260444772001L,
726823688504087684L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64ArrayArrayUInt64E1M
{
    Id = 168,
    Value = 
new System.UInt64[,] { {
8046267373538830972L,
7537846615774350887L, } },
    ModelInner = new UInt64ArrayArrayUInt641MI
{
    Id = 198,
    Value = 
new System.UInt64[,] { {
3569851555497804637L,
2676870041928266807L, } },
    NullableValue = 
new System.UInt64[,] { {
2397889465513226369L,
3153650206003039446L, } },
},
    NullableValue = 
new System.UInt64[,] { {
1541526737671176885L,
2785783065572584289L, } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64arrayarrayuint64e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayArrayArrayUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
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
                    await ((IUInt64MArrayArrayArrayUInt64)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayArrayArrayUInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64arrayarrayuint64e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64ArrayArrayUInt64E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayArrayArrayUInt64)),
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
                    var models = await ((IUInt64MArrayArrayArrayUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayArrayUInt64E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayArrayArrayUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64ArrayArrayUInt64E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

