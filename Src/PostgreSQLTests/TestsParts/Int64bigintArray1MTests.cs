

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 7,
    Value = 
new System.Int64[4]
{
3626517334357162147L,
8506210860080742904L,
1578214351708564687L,
7399892891278656483L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[3]
{
2093673718073915813L,
950368773290803272L,
4939436593295854872L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 9,
    Value = 
new System.Int64[4]
{
7559505224916479404L,
6232062314814675051L,
1511351415255288591L,
2090572397556543800L,
},
    NullableValue = 
new System.Int64[3]
{
1816946280310980750L,
8752822818654274625L,
3147247731209288291L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 23,
    Value = 
new System.Int64[3]
{
4624404590689946209L,
5873959776269511952L,
1614017355390166564L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3241441908343337125L,
7658036026465387206L,
4581483033322653670L,
7332379295864843995L,
},
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[4]
{
8641552691843037777L,
5153952506155153185L,
2293243578331950487L,
5310665627645460042L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 12,
    Value = 
new System.Int64[4]
{
7178897461305199102L,
6461908875105021927L,
2088240898789368091L,
1050803633840954986L,
},
    NullableValue = 
new System.Int64[4]
{
4243863916917228713L,
3219759655950430198L,
2535223198473182715L,
1731395959230575793L,
},
},
    NullableValue = 
new System.Int64[3]
{
151822671488518111L,
7022522681238249074L,
2992856714979784844L,
},
},
            new Int64bigintArray1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
3574017604537834194L,
1193532445393532355L,
2512843772121214469L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8307929793127573639L,
4010964375965717038L,
1895555350785875714L,
8657454411170653730L,
},
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[4]
{
5417762478457031644L,
2395687620243447767L,
4111518633578518052L,
824795220082398788L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 18,
    Value = 
new System.Int64[3]
{
5411064639327405132L,
5701645848999535427L,
7267204873733710599L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 46,
    Value = 
new System.Int64[3]
{
6444203302549430202L,
2768501301118765260L,
2414002969681746758L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 53,
    Value = 
new System.Int64[4]
{
7231913543658422285L,
8324646246776703148L,
2963691558890395191L,
8749313482300632520L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
3253951574925720151L,
8315230019582981092L,
4707183308358494499L,
4560106864206281033L,
},
    NullableValue = 
new System.Int64[4]
{
3144602186487258596L,
6291846020951452287L,
6963915297111542895L,
4980203660523608212L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 58,
    Value = 
new System.Int64[4]
{
2766766350859248146L,
1833641992672502895L,
3371561463511581230L,
2267244482743993539L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
5517987636120517424L,
8976602778532710282L,
2811070662486205963L,
5429364152079062026L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
5060778640105628770L,
6453544123003651549L,
1386778477733615192L,
6851987226274631112L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[4]
{
8508598284066269597L,
7519821512131304236L,
4756787540138831011L,
4372513619279323403L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5747725890550627573L,
1281297241888779363L,
1725459963390409271L,
3373133414557083961L,
},
},
            new Int64bigintArray1M
{
    Id = 78,
    Value = 
new System.Int64[3]
{
1663855267168333102L,
990604594669738813L,
418076455210016909L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
3600875437351572290L,
7559069878136962148L,
626034798175215967L,
5961058695994127916L,
},
    NullableValue = 
new System.Int64[4]
{
6257690485676935960L,
6523553175933868316L,
5168877318789002327L,
5509201257185523642L,
},
},
    NullableValue = 
new System.Int64[3]
{
5175887637896094516L,
2302293293510647332L,
32605149038062246L,
},
},
            new Int64bigintArray1M
{
    Id = 79,
    Value = 
new System.Int64[3]
{
361997619914026212L,
4144058719205640322L,
3107686671709671073L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5940865550828016923L,
5267956408063618442L,
3977087818047850372L,
},
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[3]
{
366807196290974108L,
5615368850389926441L,
7041025974044459884L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
1760011769232015412L,
3074209781302994692L,
1097932160897717702L,
8777028967614486013L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 86,
    Value = 
new System.Int64[3]
{
2188745237148817048L,
6075865425699724775L,
1816880160998611677L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4449238911398294571L,
5423946830758810262L,
769799260790650623L,
},
},
            new Int64bigintArray1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
782646101189238259L,
7491557289132322657L,
3332716195796485256L,
2826149242984228760L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 34,
    Value = 
new System.Int64[4]
{
7811025296777421084L,
5494666169582680549L,
8829823680092535128L,
3561868759772866920L,
},
    NullableValue = 
new System.Int64[3]
{
4169469251321115804L,
7536516270742045047L,
1498434857961132386L,
},
},
    NullableValue = 
new System.Int64[3]
{
6332250669655774653L,
8890850639370747734L,
7525795025173313315L,
},
},
            new Int64bigintArray1M
{
    Id = 93,
    Value = 
new System.Int64[3]
{
5710682138141723684L,
8786499168176338190L,
577550379943360892L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3232379347806746587L,
680000868513694725L,
6395162791909259051L,
3010493594358544841L,
},
},
            new Int64bigintArray1M
{
    Id = 100,
    Value = 
new System.Int64[4]
{
5767185955853392102L,
7100918329998363761L,
1686371348690686945L,
8323028813407059792L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 43,
    Value = 
new System.Int64[3]
{
290464646458040695L,
4173279585929163407L,
5716590463347234243L,
},
    NullableValue = 
new System.Int64[4]
{
1736355186137031918L,
7184572610427190079L,
3012443121980969755L,
6116616052439583624L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
2826739409201496020L,
2499263379512035362L,
7082393102229504514L,
8120496425996957970L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1907239392300808156L,
4952250487990187872L,
2308935204127135060L,
6866841953414584522L,
},
},
            new Int64bigintArray1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
5182075902906066879L,
8229055160339638228L,
169568881588652228L,
8531548457602906603L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 49,
    Value = 
new System.Int64[4]
{
6546286645632139906L,
2988919025382066544L,
439962337470102096L,
3913685628743358098L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
8434927890757052100L,
5805395334550388156L,
1140066937740552087L,
5016783453935715231L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 122,
    Value = 
new System.Int64[3]
{
2709557802587994451L,
8894723678831431898L,
6360899529877999898L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
621441308475695138L,
8793176678921733186L,
995558322331009822L,
8542017570249087907L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[3]
{
5399985037533783081L,
467358724234635727L,
8818798814608199814L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3330213625154603751L,
6885272240906659851L,
8100697119419047248L,
8554177247601544301L,
},
},
            new Int64bigintArray1M
{
    Id = 125,
    Value = 
new System.Int64[4]
{
3058029517232152682L,
6987038528959247575L,
1790891291730836133L,
2841560573986395914L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 53,
    Value = 
new System.Int64[4]
{
5768391476718558670L,
483136389686452844L,
3502481347061283097L,
7623265037731635772L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2359153592482258749L,
2211479897376766294L,
1502477583993461101L,
},
},
            new Int64bigintArray1M
{
    Id = 128,
    Value = 
new System.Int64[3]
{
4457158716946311174L,
858514016574307974L,
9221632100847034907L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 130,
    Value = 
new System.Int64[4]
{
3624137776151576844L,
4467555618285274248L,
4058588496090873305L,
8295811142969091747L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 62,
    Value = 
new System.Int64[4]
{
8042901612859223353L,
626290698136143410L,
1611637418147560371L,
1640984702143098469L,
},
    NullableValue = 
new System.Int64[3]
{
1312035187908354894L,
2206417828285164990L,
3358348049953684436L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 136,
    Value = 
new System.Int64[3]
{
6538296940615252134L,
1987820980501219457L,
8011126241136797102L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4425156012329495318L,
6804219920939865065L,
5063009980639037750L,
},
},
            new Int64bigintArray1M
{
    Id = 138,
    Value = 
new System.Int64[4]
{
7178587623012128970L,
1036875812070597826L,
3478307186124102997L,
5067785635299333346L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 69,
    Value = 
new System.Int64[3]
{
5001048563268859120L,
8633759221127781198L,
3811924560862703811L,
},
    NullableValue = 
new System.Int64[4]
{
5093262212083247970L,
3297124987998816978L,
7930233675443780199L,
8614227382073623058L,
},
},
    NullableValue = 
new System.Int64[3]
{
2127990624289100886L,
7838191756335881074L,
1004867519530784992L,
},
},
            new Int64bigintArray1M
{
    Id = 147,
    Value = 
new System.Int64[4]
{
8896225669508139760L,
7900092407665329408L,
2717133822581717151L,
7651681335899474084L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
2715010537703582714L,
1260385461512881516L,
889797746557827145L,
6849551430804888163L,
},
},
            new Int64bigintArray1M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
2791050997000631810L,
245973764115380555L,
1033458899228626046L,
8388074353116490068L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 78,
    Value = 
new System.Int64[4]
{
5325538702004337301L,
8135023042691197412L,
7454900729358288333L,
3893360543668263258L,
},
    NullableValue = 
new System.Int64[4]
{
6867044738470048260L,
1348405195357208049L,
1917881550282993451L,
5245816560771914836L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 164,
    Value = 
new System.Int64[3]
{
7401864940421565053L,
513790718718509382L,
4741333824649519463L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 167,
    Value = 
new System.Int64[3]
{
308623335160653538L,
585657505519397731L,
5272349529855777633L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 85,
    Value = 
new System.Int64[4]
{
2310487099557996809L,
1937912078364290179L,
978409968377087811L,
3749456618524063579L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 175,
    Value = 
new System.Int64[3]
{
9126052097558288062L,
4365986125991888310L,
5253918944902575094L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 182,
    Value = 
new System.Int64[3]
{
8484048828372840668L,
7259604333932993965L,
3078808751663442540L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 86,
    Value = 
new System.Int64[4]
{
7985629226257911396L,
2305085680963177519L,
4628835914967942615L,
5374343680854025684L,
},
    NullableValue = 
new System.Int64[3]
{
8945333365318913407L,
1832834154794328055L,
6678753869186435753L,
},
},
    NullableValue = 
new System.Int64[4]
{
5184249329339526018L,
8016930410843258915L,
443542926979472979L,
886898341460151735L,
},
},
            new Int64bigintArray1M
{
    Id = 188,
    Value = 
new System.Int64[4]
{
8789477837455129527L,
4783496675962414844L,
2875792312501150322L,
5252795909902085883L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
8307929793127573639L,
4010964375965717038L,
1895555350785875714L,
8657454411170653730L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
5747725890550627573L,
1281297241888779363L,
1725459963390409271L,
3373133414557083961L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5175887637896094516L,
2302293293510647332L,
32605149038062246L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 82;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 124, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 147, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 147, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 35, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Int64bigintArray1M.AssertModel(models[0],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

