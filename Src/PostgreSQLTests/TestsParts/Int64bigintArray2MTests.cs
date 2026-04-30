

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
    internal partial interface IInt64ListbigintArray
    {
    }
    
    internal partial class Int64ListbigintArray : IInt64ListbigintArray
    {


#region TestData

        private readonly Int64bigintArray2M[] _testData = new Int64bigintArray2M[]
        {
            new Int64bigintArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5766506160422915388L,

1310292787760744454L,

1288428930418314472L,

1135679102195205567L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6422402632356922017L,

5902397674553700468L,

5436762749285181240L,

},
},
            new Int64bigintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4687196094232056300L,

8946921447434059028L,

1789213838418167009L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3804299751929774073L,

7545751524296650934L,

3263413158897127601L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4703105562053924008L,

2617812376404678591L,

7058542379595299804L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4002358908083232747L,

605842803095263549L,

5049274726372762792L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8862745214490775329L,

8777796779425887131L,

9164161518333948184L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8672329470452342323L,

3435011840287894345L,

7174923134366701490L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2275509434278871769L,

8573697737960202636L,

85906072389282515L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5775842990166171973L,

5017923754615558913L,

1724870939008824706L,

},
},
            new Int64bigintArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8277044849186177082L,

1420616826337028102L,

7189275572457621125L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4983706519008542665L,

8822222518660670155L,

698739260187023059L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7291099878695110463L,

7346506925625533317L,

1329907544332558496L,

3445378219474036762L,

},
},
            new Int64bigintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1748673689834814849L,

4365724512418174413L,

8273443477219937234L,

134541571417377019L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1229368896817405312L,

1017315744194830833L,

3433980626521700360L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4665265630684441369L,

2465562722684106025L,

3249691888662833299L,

1502060833591015652L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5920655119771484647L,

8874521015298791105L,

288999267166325838L,

7679233377130919034L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2923274919210361613L,

6947714725218226946L,

4195426080598467769L,

6101585957364246205L,

},
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5843681436914638345L,

1450629434343857942L,

9003595360157812471L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1753808289868866141L,

725854860428753097L,

726337854165427807L,

},
},
            new Int64bigintArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4706886945510433360L,

5423528385658662949L,

8485514755493935093L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4809208167159717333L,

8065436504349528907L,

5458230977059141314L,

683828444709024194L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1887961565159722259L,

7949075095066721141L,

5248050420076159685L,

7871011353501892036L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8298942320802457659L,

1551008264096935010L,

4110044397109416639L,

7236117977953734514L,

},
},
            new Int64bigintArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7851029390804714682L,

8167873930162804869L,

5201337183608364072L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3036803466514623720L,

6444663968431373604L,

1553099867776269756L,

744117430789820195L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7329452247953170186L,

8206652689871855701L,

1694678133179851556L,

3225120886915396675L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3785399490208880005L,

5087560028239953370L,

1406996437274691215L,

1729900642721403268L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7802387688311851875L,

1061601830604110208L,

6630259861536277230L,

7455281456906657380L,

},
},
            new Int64bigintArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5937591634087615902L,

1570810597173367706L,

7484285037801903737L,

5898035169315289369L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8245029524829379659L,

4583863870099122488L,

7150526047153992422L,

4748613017263993210L,

},
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7683918328290088226L,

2117382581701328840L,

2578736814640204180L,

7809756951312462942L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3257377096604320937L,

6025540715018839703L,

2676037441303580639L,

6630852894108585958L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3602423336297825674L,

8671609664362480931L,

3970525685671920907L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
831141487024230282L,

8027087582765479250L,

7231333286785107035L,

},
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3904180268803015366L,

5807854492174949596L,

1137612908776510734L,

1792520235357962186L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3997136151719410310L,

3809267744154455650L,

330661999538685481L,

7600522111955884428L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2804839633646223507L,

6640258770328273680L,

5049727970295162682L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7562096978558759831L,

3763957336725581891L,

8467010967377560437L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1113334486736783144L,

6047958482596171619L,

9158187252114654031L,

},
},
            new Int64bigintArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8488491794003278953L,

4449535225240212123L,

216668204646042547L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2661704434042759438L,

2157585475040381283L,

4249535544127084623L,

7174712927003675511L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2558097517256574777L,

6848605996110983456L,

1387288759645256780L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3238415097231561286L,

8031875532240969037L,

1518110406330776648L,

7283821275043254678L,

},
},
            new Int64bigintArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4655791514691004768L,

3806988950669315188L,

9008220165340861765L,

1707010839985235379L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7026965615007885565L,

7563897717716614985L,

1459545439128141243L,

3741255924940815184L,

},
},
            new Int64bigintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6014727943307281361L,

1945479770596280309L,

4989189404303796403L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
667666517006864865L,

4369839002347479647L,

1963123443987421443L,

5113519184392436364L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8705584650876828859L,

8606622201711049329L,

4380929737352381753L,

4866530623992442993L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6460208741924588425L,

6426753384386617955L,

510971532079818367L,

6766834284784800696L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
453400147957819259L,

6950564372065652233L,

5572202102569389361L,

},
},
            new Int64bigintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
207037925336083103L,

9065524691013871411L,

5432632524775546541L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5974248698834294447L,

3358386972264915638L,

5720677501265213431L,

1095328444840268471L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1952186579890790867L,

3237683846573211588L,

3494864784723439599L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2464105529558262457L,

4754161030127293110L,

8753606653709579758L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5228172604761040030L,

8676593792576319136L,

4555041665287960616L,

},
},
            new Int64bigintArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8097960996210242948L,

3431914179589603994L,

6578737509481741452L,

3411270973044556058L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5261043272744085286L,

980241745369943583L,

547848007452793064L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7964805957444932083L,

7770844480416338632L,

4044592220950811503L,

5862038131188341984L,

},
},
            new Int64bigintArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8020506628411421262L,

4305436418034141165L,

7769154270053856417L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9203804243058381427L,

2117430337811840145L,

3591776042672498489L,

},
},
            new Int64bigintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3059398930100351051L,

4722597705649641401L,

502115253136205706L,

6098387269849330190L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4389788735369209475L,

3119004834083745207L,

2519764663304734692L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6300968721788248300L,

6985822055752973741L,

461413930591247693L,

6291443613132570417L,

},
},
            new Int64bigintArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
525010292108247843L,

4760099340492627305L,

4710440521698467172L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8222299104181115400L,

7396681587689300230L,

3266785577537236119L,

2867713282977766440L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1764970379529290994L,

8872430177605035397L,

8786898848308316761L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6590529677018963480L,

1868897898326825173L,

4185679893577197349L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7692586845569242643L,

5309060276424039710L,

1750846286286698486L,

},
},
            new Int64bigintArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4323167556994755489L,

6085094479224063725L,

1423722753954298575L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6933312385170751158L,

6459755201640924783L,

993004366152363080L,

},
},
            new Int64bigintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7302590518569995197L,

533977624522701379L,

297108977552719521L,

4378792081744408251L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8909715669957909917L,

8983011836921376865L,

6333311010618042605L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4110413935022733126L,

6425574334026918228L,

5007529776826769589L,

},
},
            new Int64bigintArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
556144428187905388L,

316094374852239704L,

5021620047329109914L,

7226761441940740323L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3974856371200091958L,

7165922709453873887L,

317945810530137588L,

},
},
            new Int64bigintArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4532357540651512680L,

1708568712719429987L,

32095251474533032L,

1862931756456585383L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3794189765445027323L,

3457629863927521412L,

6733727139154118969L,

3606507986620365440L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2264848671368035568L,

7154903320368470317L,

3456676743416658461L,

},
},
            new Int64bigintArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8873818068756388345L,

6919381223797282541L,

8803590900452528879L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2385858913309250457L,

5739685803250101733L,

2990024560325793555L,

},
},
            new Int64bigintArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8109640995482602322L,

6592318536638041830L,

5899469799012226432L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9132834806400850943L,

7134196922911424140L,

2358399633548988385L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4154233820106366045L,

7804440425898961018L,

8905764271213567422L,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
INSERT INTO public.int64bigintarray2mi(
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
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
            asPartInterface: typeof(IInt64ListbigintArray)), 
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
                methodParametrName: "int64bigintarray2mi_id", 
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
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                methodParametrName: "int64bigintarray2mi_id", 
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
                List<Int64bigintArray2M> models = null;

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 87;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray2M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintArray2M.AssertModel(models[0],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintArray2M.AssertModel(models[0],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 144, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 128, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 159, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintArray2M.AssertModel(models[0],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray2M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 57, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintArray2M.AssertModel(models[0],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Int64bigintArray2M.AssertModel(models[0],_testData[15], false);Int64bigintArray2M.AssertModel(models[1],_testData[16], false);Int64bigintArray2M.AssertModel(models[2],_testData[17], false);Int64bigintArray2M.AssertModel(models[3],_testData[18], false);Int64bigintArray2M.AssertModel(models[4],_testData[19], false);Int64bigintArray2M.AssertModel(models[5],_testData[20], false);Int64bigintArray2M.AssertModel(models[6],_testData[21], false);Int64bigintArray2M.AssertModel(models[7],_testData[22], false);Int64bigintArray2M.AssertModel(models[8],_testData[23], false);Int64bigintArray2M.AssertModel(models[9],_testData[24], false);Int64bigintArray2M.AssertModel(models[10],_testData[25], false);Int64bigintArray2M.AssertModel(models[11],_testData[26], false);Int64bigintArray2M.AssertModel(models[12],_testData[27], false);Int64bigintArray2M.AssertModel(models[13],_testData[28], false);Int64bigintArray2M.AssertModel(models[14],_testData[29], false);Int64bigintArray2M.AssertModel(models[15],_testData[30], false);Int64bigintArray2M.AssertModel(models[16],_testData[31], false);Int64bigintArray2M.AssertModel(models[17],_testData[32], false);Int64bigintArray2M.AssertModel(models[18],_testData[33], false);Int64bigintArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int64bigintArray2M.AssertModel(models[0],_testData[19], false);Int64bigintArray2M.AssertModel(models[1],_testData[20], false);Int64bigintArray2M.AssertModel(models[2],_testData[21], false);Int64bigintArray2M.AssertModel(models[3],_testData[22], false);Int64bigintArray2M.AssertModel(models[4],_testData[23], false);Int64bigintArray2M.AssertModel(models[5],_testData[24], false);Int64bigintArray2M.AssertModel(models[6],_testData[25], false);Int64bigintArray2M.AssertModel(models[7],_testData[26], false);Int64bigintArray2M.AssertModel(models[8],_testData[27], false);Int64bigintArray2M.AssertModel(models[9],_testData[28], false);Int64bigintArray2M.AssertModel(models[10],_testData[29], false);Int64bigintArray2M.AssertModel(models[11],_testData[30], false);Int64bigintArray2M.AssertModel(models[12],_testData[31], false);Int64bigintArray2M.AssertModel(models[13],_testData[32], false);Int64bigintArray2M.AssertModel(models[14],_testData[33], false);Int64bigintArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray2M),
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
            asPartInterface: typeof(IInt64ListbigintArray))]
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
FROM public.binary_int64bigintarray2m m
LEFT JOIN public.binary_int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
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
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ListbigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI), typeof(Int64bigintArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                await ((IInt64ListbigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                ((IInt64ListbigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

