

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
    internal partial interface IInt64ListbigintListD1
    {
    }
    
    internal partial class Int64ListbigintListD1 : IInt64ListbigintListD1
    {


#region TestData

        private readonly Int64bigintListD1E2M[] _testData = new Int64bigintListD1E2M[]
        {
            new Int64bigintListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3483335626949075230L,

8727510454512350054L,

3866722180544601219L,

9009749977016896645L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7814026703737711977L,

534234176399165444L,

1565773705470707737L,

},
},
            new Int64bigintListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2047066942382048424L,

1300342051245762132L,

3439156349711983267L,

8326333975342316930L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
45356416338290051L,

2156268143656996147L,

3966442551995421376L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1547781006933053612L,

1893156060136972389L,

7207362850855586294L,

4833596679668281665L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2663664587335899608L,

89452053830108974L,

5017684884485074511L,

8179191503694084033L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
537172741094566710L,

1700241993704021494L,

5454357414223080025L,

},
},
            new Int64bigintListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5944447894268108739L,

554425859795770650L,

7077286064828684700L,

1924225919585746060L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3490226185864101646L,

3522153529935862453L,

6153653285830217461L,

5743421842635711629L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7269772519318390416L,

3674828032936822428L,

5582749305208117689L,

},
},
            new Int64bigintListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7118553859554887221L,

1978453258533113548L,

8616250161018452778L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4121515067644541005L,

2423761939782066530L,

272272916578065840L,

5565062322745100968L,

},
},
            new Int64bigintListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3912481745312343211L,

6603544158411323652L,

8402368522754092208L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3844929321714277324L,

8327626325507014453L,

3529747940165989519L,

2982601022213731730L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8533355701578479928L,

4639980141635137620L,

6593496501865579745L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6223812575455321401L,

6102704967899026488L,

412481868759397951L,

},
},
            new Int64bigintListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2186371903931635666L,

971483336384603254L,

7739136450351912110L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2921276200878761155L,

1995759972264283522L,

1519703526726257007L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8939633465473705567L,

8552028234077185673L,

2570569956233227723L,

},
},
            new Int64bigintListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8696864033539820119L,

7896389843923381400L,

2446977522662705009L,

3950799539652303673L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4467696777531533318L,

3580956242244693055L,

3517464703456186746L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8623868331056991005L,

8894924047351897172L,

3398909581793887822L,

6290749063329497604L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5453396069185855297L,

7233602254382442425L,

1816634079943389134L,

802220016490713201L,

},
},
            new Int64bigintListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
980146811040300086L,

549553370255224305L,

5516429325136439065L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3284288709041216416L,

7861519088424415359L,

3422450572602262271L,

4533242492891826464L,

},
},
            new Int64bigintListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8716617102635211855L,

5271819150006577669L,

7151968376434319229L,

5573190230087685877L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4197052947192176896L,

2681909070923608190L,

5105779037327005540L,

2934838318931226713L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4490940536057956925L,

6557513050282484689L,

2544286371337512321L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6018159658071494167L,

5340094681236213997L,

2065816393661010733L,

},
},
            new Int64bigintListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4597475345644335660L,

5480163891921786124L,

2535284476869798256L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8337487142760520143L,

8903384900409309704L,

5672052507679070624L,

2076076607352827994L,

},
},
            new Int64bigintListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8139238146831747422L,

2100074243924021387L,

2118515521055805493L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2295714263775108622L,

6107850413680674229L,

5009476532194912118L,

6096786105787838368L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6775516851334642257L,

3646078832884866723L,

9134560090857197279L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6547976919676877667L,

2876301386844883870L,

6146704246646003550L,

804106803432628717L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7073987769149508851L,

7307450279587403010L,

7550164615122541406L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3621874430431650249L,

927628512133896850L,

3882227750667979312L,

2105863103643204636L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3891405891437590425L,

2959419764606945050L,

6153944346927318598L,

77342776793104769L,

},
},
            new Int64bigintListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5047641298440519876L,

1779657940972591967L,

3344295764306622383L,

4676081697161482806L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2593486548457916141L,

9052034522319863262L,

3746818514268524281L,

8432785407685883761L,

},
},
            new Int64bigintListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
472361418169535912L,

3865276657402192823L,

5878633606814280175L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2413120402745418538L,

1800863852599074209L,

5560758921546939461L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8082675033761371394L,

3790594549536903384L,

2730020601426709644L,

4050685694699756592L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3320360879546791606L,

5265043248698148455L,

7618080737623580068L,

8296626230255397409L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
153373595226233733L,

726253777588257381L,

7612477880603107429L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2349716512110171779L,

8932638998233612803L,

4750453061532434566L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661201246828102119L,

2385761448818767557L,

3583445538998825068L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
425352727657475582L,

2789874820986573939L,

8681391439273177348L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5893850673723825209L,

8955147909608008260L,

6303898803027172599L,

3304068115038585524L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1900153154945085365L,

1023351197813860635L,

6953229795885776915L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8252912591590705958L,

5228607610165653735L,

5148632549596235250L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
958940363531903087L,

4606578225303097809L,

4135346117537637094L,

3092502109851837066L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5062968364677840108L,

4691066943517615092L,

6113792795301448976L,

5336529666154369783L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8420151497265734339L,

3222853941702002288L,

1145244736733788930L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
832577767565405174L,

4997577999759482729L,

7794214562578400132L,

7071666222598906696L,

},
},
            new Int64bigintListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1057764911720424775L,

3323108626420744350L,

7462943047528247774L,

4265686811962789570L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1022249032349919534L,

5683205400047731954L,

847749390238802853L,

4388879553970886915L,

},
},
            new Int64bigintListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8824126903665256350L,

3551670306906214859L,

846103147692123029L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8780476898676804089L,

3956930956174905595L,

2442918273227316271L,

6944428700374701149L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2235802804452845929L,

3645554182779268108L,

2699808819450748336L,

5949654545160519159L,

},
},
            new Int64bigintListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5084765273325819254L,

1054068563507548353L,

6996007721025936320L,

2025081097965479381L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2950550714639112039L,

7997681374359707616L,

497289181579846467L,

},
},
            new Int64bigintListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8088628773835713408L,

2067809781215410132L,

3426379653567918354L,

5573171758566324864L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5958027024086446570L,

7058643798070992650L,

3901392335425900969L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3177150393923405291L,

3293759970141565368L,

501122433650345L,

},
},
            new Int64bigintListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4301586365538695801L,

9144404810404632130L,

648428488278708015L,

4559321400434722874L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5866151104927191415L,

2885482592887172271L,

2415627346327100694L,

8284988210786147486L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3596714763284042027L,

2372905527207680014L,

7271818753844384521L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7163861027942629174L,

7879760155827790258L,

3401949717238139279L,

4615592893722019368L,

},
},
            new Int64bigintListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4441344847787163056L,

8567713207674604714L,

1035344470313606080L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1654473532067751739L,

9085677681574593039L,

463526441464854948L,

7405827043839757405L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1378850612877579891L,

1399366337629106732L,

6313996505278045984L,

5385194586965274002L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122493975485477998L,

4965929732355663269L,

1026387616665169306L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7254427708107972623L,

1185189646523697869L,

477749588277034227L,

4028220460185890133L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
982105349467442450L,

1633953933058865166L,

8126654934728735228L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 204,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1685477922433271696L,

1690878136054221261L,

7547243718444355642L,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2mi(
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2mi(
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
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
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

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
            asPartInterface: typeof(IInt64ListbigintListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd1e2m(
	id,
    value,
    nullablevalue,
    int64bigintlistd1e2mi_id
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
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintlistd1e2mi_id", 
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
                List<Int64bigintListD1E2M> models = null;

                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintListD1E2M> models = null;

                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr2.Value = 161;
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M), typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                await((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 150, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintListD1E2M>();
                var models2 = new List<FlatInt64bigintListD1E2M>();
                ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 141, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var firstItems2 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 121, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 161, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 91, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[33],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
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
FROM public.int64bigintlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems1 = new List<FlatInt64bigintListD1E2M>();
                var secondItems2 = new List<FlatInt64bigintListD1E2M>();
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.int64bigintlistd1e2m m
LEFT JOIN public.int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await((IInt64ListbigintListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 191, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt64ListbigintListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 179, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 179);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MI),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintListD1E2M),
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
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
FROM public.binary_int64bigintlistd1e2m m
LEFT JOIN public.binary_int64bigintlistd1e2mi mi ON mi.id = m.int64bigintlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintListD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models =  ((IInt64ListbigintListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintlistd1e2mi
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
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI), typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                await ((IInt64ListbigintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MI>();
                var models2 = new List<Int64bigintListD1E2MI>();
                ((IInt64ListbigintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1)),
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
                var models = await ((IInt64ListbigintListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA), typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                await ((IInt64ListbigintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD1E2MIWA>();
                var models2 = new List<Int64bigintListD1E2MIWA>();
                ((IInt64ListbigintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintListD1))]
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
                var models = await ((IInt64ListbigintListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

