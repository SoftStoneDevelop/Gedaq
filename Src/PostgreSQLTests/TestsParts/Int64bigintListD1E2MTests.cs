

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2259791899387554055L,

8734535084582684069L,

8577883334315173748L,

2889798244875804134L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7168299477809816799L,

4478981915473927089L,

7651831716799395092L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6192390823393437639L,

1063071792172680457L,

4819042480086988847L,

8403703263446009988L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1558409772431220136L,

6570705387810777675L,

1775937490249461697L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7502938390727035712L,

2157389013401876077L,

5730813905957268398L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5084619723595176162L,

4464892832221037325L,

2430643924347784097L,

5664274720385726345L,

},
},
            new Int64bigintListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7740779036896379820L,

5210981321058624197L,

8988628996823012035L,

4649253619311416100L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8214353211913387656L,

564393300113369796L,

8900061688503918722L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
400435417916968858L,

5093211235772962170L,

1118652535649820523L,

1374436849758811559L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6080220154360632685L,

5232007577151105557L,

5230559477432258239L,

},
},
            new Int64bigintListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5034271652533135283L,

9148048765832637017L,

7335907600825984773L,

8670204900162901792L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2762792318624605314L,

8754257906382835511L,

7948632532387722552L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9211449924706434161L,

8034733020996447728L,

5883492938099728392L,

4341357352239544023L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6080994453361459669L,

2722823299245797006L,

4271999016687965878L,

5476114052091223927L,

},
},
            new Int64bigintListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1640797772948028600L,

8216374762533543790L,

553235165137226405L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5505182195545180158L,

4732479179881425500L,

4113263798825625294L,

3535677993824901258L,

},
},
            new Int64bigintListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7905399580735441090L,

945434731025107184L,

8298301887445433284L,

2041990281713130724L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3717649908054450184L,

3361903887863250340L,

8833780465707253253L,

5377270197334111181L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9016832896998245252L,

7941701727114206207L,

6686003977382027146L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1518576657495698759L,

6725136278211630215L,

9089389929351199694L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1200118027412246397L,

8240600289253807721L,

4386032413715922121L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5632732106746820032L,

952470077930438460L,

6015421455278650815L,

2633575568978358371L,

},
},
            new Int64bigintListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
78637749209371306L,

3663193516005025987L,

8217785923030317345L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5710155456449675035L,

344096856253668788L,

7479394435673534625L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7260706881178735951L,

4214990784422156222L,

8189926095108479435L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8077577326474196583L,

7288331680087365683L,

4462415910562247541L,

484345643541674498L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1193840407697004574L,

8328428034024535087L,

1285922112511790485L,

2671906889854927860L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1333125841993036657L,

7441295964405428702L,

517987029732776338L,

14453255821022645L,

},
},
            new Int64bigintListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2167498563692379453L,

3123579425093865906L,

4490408628318608297L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3477285259259839577L,

5381825204683173602L,

5043553512456670760L,

740704683751374372L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4126442869045076699L,

5678114303263549733L,

8318390665223398918L,

7012028842997705420L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6293738006788430051L,

108709601250540389L,

2861937281530197636L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3777863515021658041L,

3685892023256891882L,

6467092522713740526L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3004444801787552733L,

8599673414692866439L,

2945946281757045379L,

6252623522757121840L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5849088782455109061L,

3558798178322614313L,

5514584939957218612L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6911772413797661916L,

9161375679901751762L,

7525821088040071322L,

4796355939127560243L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1899460383454278972L,

4264928356512904510L,

902469926467955445L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9085778393860232415L,

7001387386365227487L,

8810733315299215578L,

},
},
            new Int64bigintListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5038115449756137264L,

4336805418267667618L,

287267588388063960L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3219487408419855833L,

8575832188934988092L,

1820412270166848188L,

4772618938509663870L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6632201907410909127L,

2087553745137247365L,

1037970530565337715L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2341601110271575732L,

347247483361043689L,

7344462507584773449L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5085614685763544220L,

1416034009166763216L,

4992141492453320159L,

},
},
            new Int64bigintListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
418881162198995609L,

4628213395679682166L,

4020284431578197269L,

4852486927499982044L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4960918586908208881L,

8796130723467040718L,

5390556401151782695L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7174109719749238539L,

6530353437319479803L,

781212442629864136L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5741908430479455544L,

1153286091281127797L,

5939519541724463741L,

8960618412454716435L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4395149330478468687L,

8689238742321524407L,

3680131885623855750L,

7602186449155240663L,

},
},
            new Int64bigintListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7056655484779973824L,

8151725364828316428L,

8347530679302609781L,

3795958669891753869L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8683789288635272802L,

6159407473273829556L,

4071325959513065050L,

9164741181269251791L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1370249424966859400L,

4534105126071477389L,

3696443881730615721L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7641239098236373329L,

3701999569187222078L,

6646508145124259554L,

8414393338444661494L,

},
},
            new Int64bigintListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7147907951199548040L,

521853727257578318L,

7807832950621884022L,

6554096701330826907L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1751071652724712932L,

8427109903358978418L,

4358521439679304691L,

5848267751463884623L,

},
},
            new Int64bigintListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7236684320875866982L,

2689151875453848856L,

4241132420052145352L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4643016278785058018L,

4632957708368525566L,

125316060005712336L,

623748140904750863L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7306053217835302271L,

3840861088624410267L,

5496168065476774320L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6199865132582721982L,

7896044696857345937L,

3497511280181066173L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
873951891743763012L,

2208302193554490515L,

6144330125823906130L,

1737096872318135903L,

},
},
            new Int64bigintListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3863736002026773414L,

8181165123369081873L,

7184014274866631864L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1835331386726550478L,

656441983929909822L,

6104923960767877057L,

7573906656965780896L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2463275513741821059L,

4942172189699906001L,

1634490742697653259L,

},
},
            new Int64bigintListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3495304885677012557L,

7189538291316186878L,

4350812294642957471L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4106676237622126571L,

7873948485564940565L,

5387266267707890592L,

},
},
            new Int64bigintListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6234038915904053079L,

7809292262838458377L,

201860694969659612L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4378348288183620753L,

4374084697677823071L,

1283765007193021950L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5343193299955345791L,

5150685024593288806L,

1542086892253314940L,

},
},
            new Int64bigintListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3092691410403906649L,

5602935929782320329L,

8478997496721527185L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1594820520921598876L,

9127929709479322279L,

6080367725957593774L,

4217316258111614655L,

},
},
            new Int64bigintListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8879381599864464104L,

2407738947961933371L,

6216307745562179499L,

6883602950733804486L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3539546048163372967L,

634536161820853146L,

6525327684179941597L,

926690186454337430L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7829849855636140680L,

2241267243195176129L,

1275988034557041938L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
240929160614827136L,

1908802881569865819L,

3191862294181807540L,

7403034265093493837L,

},
},
            new Int64bigintListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5869954248155523649L,

6687485726464972866L,

7443783645235030475L,

8977475957948779229L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
75103731436211783L,

5768087582906690014L,

7774600998100356336L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6541459812347530115L,

5293217189157971521L,

4925987057266934917L,

1759134673330205772L,

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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 10;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 146, query1, 158, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 165, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 115, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[34], false);
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
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[8], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[9], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[10], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[11], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[12], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[13], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[14], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[15], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[19],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[20],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[21],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[22],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[23],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[24],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[25],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[4], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[5], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[6], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[7], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[8], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[9], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[10], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[11], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[12], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[13], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[14], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[15], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[19],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[20],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[21],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[22],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[23],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[24],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[25],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[26],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[27],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[28],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[29],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[30],_testData[34], false);
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

