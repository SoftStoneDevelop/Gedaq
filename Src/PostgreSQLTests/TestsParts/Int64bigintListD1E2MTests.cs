

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4879769867197220682L,

7960414928922848235L,

2559544112522216981L,

7064354475223192941L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4957847104351125277L,

8207264516358648633L,

8091361420179499368L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4543011831754447259L,

8602263687175329075L,

5297658773052218082L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7803032073686740344L,

3961114001494031314L,

1815050862605734685L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1163279528589394957L,

164877807040614624L,

4977045418214221531L,

3343020025714365367L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5354706032683992140L,

8153551267001377254L,

2488976631343768529L,

},
},
            new Int64bigintListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3061169932192724274L,

1972978855888591663L,

7391215830473144942L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6327838170136415063L,

8254416552447785532L,

5694662984585323843L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8419552134723217392L,

5156231978982031170L,

5492205834018631020L,

3291609162084621975L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3598476909973589191L,

748110957650990471L,

219637552620279299L,

5799357742374565017L,

},
},
            new Int64bigintListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5315927742562636669L,

5999064821730012457L,

5216003329097402176L,

5777177918946662779L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
738374157951087273L,

8287193452124554104L,

2248292342537307559L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8094346773356498602L,

338835929312511973L,

8950952930067335504L,

3502157565542043293L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8701412239017486104L,

869017925119374120L,

8546822131619696717L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7973109126861858623L,

1628823607137015599L,

8430605509989073168L,

5815983535306198111L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3289909180590719521L,

4167962377175346169L,

6261539795099292988L,

5297212645717146331L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
627639417044615084L,

7114024727633590725L,

4065083676060684804L,

7420452308625349188L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8976749694795501828L,

3402902686962281009L,

347496916261049993L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2724133017341511556L,

8302817078660431542L,

1911193924783540038L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8308386716393038282L,

9202208392609793088L,

5680017648081752442L,

4225241201134185344L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8901532369938206716L,

3498441787237809565L,

1622333581467797053L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2679436838920361409L,

2027334515971117785L,

5558351512488908056L,

668116236642171523L,

},
},
            new Int64bigintListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8412660852611987317L,

5567656525295934157L,

4239959206728523461L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3925782634016486896L,

226450672583543051L,

3336227180838399L,

},
},
            new Int64bigintListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
707710086695979521L,

6068042233469022007L,

2551037311877436176L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2068948403903579916L,

5196256542415754987L,

8427346336813829576L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1117965817276735404L,

1568857663636647858L,

6783684732082485945L,

4115528061129219855L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5629892037437030250L,

570261428940891423L,

3949231384910275544L,

},
},
            new Int64bigintListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1917633394734442112L,

5516327466578493039L,

226932215710379366L,

4772315992554509988L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6373332643788938680L,

9146482586947483871L,

4900002636914561643L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7230416638917770553L,

1536460918553851449L,

8919038090286629732L,

},
},
            new Int64bigintListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6506770245113991449L,

6629075500112747070L,

6128305499793971260L,

3503497152148609941L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6568148039549990601L,

7553295156645113747L,

5652671616521508073L,

7672289332543693342L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1117942623659195169L,

2999623465883470608L,

2283110657897073611L,

8856519994374470677L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3042985617935662084L,

8284324622169280762L,

5057513654900237711L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2228381692867155190L,

5646557843351925838L,

3386024645477523555L,

2666770749949294845L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
764145575272494492L,

405538017001264228L,

8590392792185258062L,

6183943865890276943L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8174331718202197044L,

7784039353429275897L,

7413840380868329033L,

7619511816367015289L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6757199398953496640L,

8091809317977772263L,

8493609519170135657L,

},
},
            new Int64bigintListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1596569341706867208L,

5707214443970638619L,

1317500300999117479L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6382104065201943586L,

1228078948408874087L,

785072089065655118L,

},
},
            new Int64bigintListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
511323761315538794L,

2528481366802311815L,

3478625937327861438L,

3896710597329832946L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4139624877283169739L,

1638711871122818089L,

6885901478102756119L,

1954065984716824169L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5324845324768111288L,

7502622366347384556L,

984620837817697692L,

},
},
            new Int64bigintListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2787181086668775701L,

1415162592827548521L,

414832838153543864L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7814813973722464365L,

5062954899773716714L,

5979034133957393784L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8251715512422589027L,

8480333954336641877L,

1802079919263462513L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
855690223096531194L,

2877969114318204520L,

6440032286167802627L,

4634284957833522897L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2029050506213880874L,

4735930309911282425L,

4879297169326983087L,

2518606740164254644L,

},
},
            new Int64bigintListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1782276729054021520L,

783602175622327810L,

4825426524366228625L,

4460590176880416608L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
845190374703826240L,

8631046650106189519L,

9087373870748382027L,

},
},
            new Int64bigintListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3916233113338638229L,

601385941322147576L,

4142305396476431075L,

4003344233194843580L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7401552107990453040L,

5736166202904707115L,

6872947585228020950L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8608674564333397200L,

3087182110220493091L,

5239494251861209095L,

2720660257115316720L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
50689759250366340L,

1028049107805720990L,

5354145631264694888L,

3179545736101075720L,

},
},
            new Int64bigintListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
536144853384585173L,

5541024044024486451L,

7585629536528995114L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7713312577911713209L,

1177497442325400647L,

2032349098456863917L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7500708912721714372L,

8610741835924192191L,

3665884852596173725L,

7086460371068745657L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2004613239877015899L,

7983823410221104446L,

8741605894798325190L,

},
},
            new Int64bigintListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3894806406751681454L,

5283672547173589054L,

5652054995176217587L,

7095839796576689646L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5542538932429012326L,

1948681973186201704L,

6333237650437339902L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
479393066703095193L,

6775950919251433297L,

8360853879727472723L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9045288642815536736L,

718259303119914421L,

8197996102155999678L,

},
},
            new Int64bigintListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1146992948887605705L,

8000341409634945271L,

8160434674222710105L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3932287930309049936L,

324287501922322777L,

2201392561104343764L,

3037625748788933763L,

},
},
            new Int64bigintListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8916379456603348528L,

2624460917442873536L,

5674048680069399631L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1436262543822454693L,

3854713455361297064L,

5558121674531044375L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3995355419987664239L,

1688542485735345095L,

3902410154044295361L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5127326090312518825L,

961980821035860479L,

7203617082455056281L,

},
},
            new Int64bigintListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6746116998951472917L,

4011478617594396278L,

5887292395881496974L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7277196761961094285L,

6361530358851274903L,

4584156654814310543L,

5692163301853108446L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4955767006404399239L,

4078307599952230261L,

8408976481304011015L,

312665080436470734L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3768970948285641226L,

364023486485774565L,

2493651958477982839L,

1580246014851494338L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6092475134771000211L,

6977415442910013272L,

8765802020488415202L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9006401917286110537L,

1775213155902970087L,

3137809246920945540L,

2648552782466860719L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
108566672072319852L,

6078706316394269235L,

3943987108797384098L,

2557354315625258353L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4553126109997653979L,

8894407935545418767L,

121997695771042802L,

7290117758231191761L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1150732742871561882L,

1119077938505307447L,

9181710939113649863L,

4960945507373193332L,

},
},
            new Int64bigintListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3753545780195388989L,

8111051743902919380L,

7976535253474212243L,

7064751149959808700L,

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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 75, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 162, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 160, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 81, query1, 161, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 9, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 99))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 95, 46))
                {
                    if(++resultIndex == 1)
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
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[34], false);
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

