

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1575960688240616887L,

851146455932746616L,

6272551661153224990L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4101959550796862630L,

8577109765147509481L,

6485832033811979736L,

7002074808305736353L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1736771786110911464L,

4084738936394758545L,

1161397655340922934L,

721667879351688590L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2511238665443426678L,

3484884083239725811L,

8501046726036136438L,

102739688101190286L,

},
},
            new Int64bigintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5662255691285639958L,

7874501831020838446L,

9044430757404527841L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4420883329592483240L,

7701470346653394595L,

3195136878016710349L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7537081203523798514L,

2853936164732869710L,

10717493968966671L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7521014295023271641L,

4959505944798688126L,

3796657385802589266L,

},
},
            new Int64bigintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8521595052763706837L,

7658359153158387330L,

7536343658491260769L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6944471067496208071L,

2565672783297876915L,

3873512481961232039L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1095309927211839537L,

975961591031016813L,

6963986334847470846L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8798258200724908365L,

4110220903039886049L,

4554972252256355131L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
250723305443181712L,

6176649251201467675L,

795233544011584953L,

3632092200998576588L,

},
},
            new Int64bigintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3655111895023693094L,

6172566392346486838L,

2458255603639793651L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7086732862093763134L,

1354527040763447935L,

7569939395089841926L,

1408442952094796539L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9115880191064221597L,

3505418886307490654L,

1959272941757070148L,

5501817891418598772L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
662921990262503319L,

2124299157858708356L,

4337750920633925301L,

},
},
            new Int64bigintArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1510962131523112487L,

2768883179215121553L,

7787288623102838336L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1776016999262451733L,

2292837234554390989L,

6985731499668651750L,

7350672997469098601L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7054289772116940963L,

9086586788040257163L,

395352024078823138L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2236794474507747777L,

6245300087665328198L,

8402541612308270609L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6970508666327165823L,

6594594944441039056L,

4587644080527101638L,

4750101546135007212L,

},
},
            new Int64bigintArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3593636475587811367L,

863665663878438138L,

6191675855945599042L,

2366604282533430091L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4764566245946625691L,

75217958121001936L,

1954157499885728388L,

},
},
            new Int64bigintArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1944697410226377111L,

910969720688304612L,

7974573141984474226L,

830076067229487455L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2101536979066945595L,

4045264918544552070L,

3876114553528906496L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5001225045645022477L,

8617760205328098334L,

3793947115126155393L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9069024443837424408L,

8446425982699747657L,

8879730930555374213L,

3914717416832918149L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9105421260295554035L,

2913249463188626539L,

104858552260496099L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
764766619043274424L,

1109580617252551156L,

5043344256257894511L,

2403003969416085628L,

},
},
            new Int64bigintArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3832426540596720581L,

3418639172242770843L,

8958924153645213576L,

9085379571819905811L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6089231338415507967L,

5407824142378378918L,

6172676273369183481L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
183162107116375135L,

4651983499182000241L,

7698978305203660902L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5003334969308316365L,

6482758380940085220L,

6838981728866364906L,

},
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2123493714352898234L,

6593010962654600975L,

8324555416606417079L,

7088538900785088394L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6514473092242190867L,

7143371141664986882L,

2241208140770526331L,

},
},
            new Int64bigintArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
154765931003560145L,

1805442640659941332L,

2593603669397800508L,

8729435619610192128L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4833061990720478399L,

1377944304429122728L,

120304945202293402L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8344827522792575423L,

5354254262944722106L,

5226378318033011412L,

8455983894685624704L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3827162458758273121L,

6608905465734784494L,

650176390238185147L,

3553386450316446805L,

},
},
            new Int64bigintArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
887332243994388866L,

2009992990232376733L,

7039544926664897167L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5116065698237491213L,

1941046457399497020L,

3183074830685217825L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1388810197187104282L,

6949155405214405218L,

564237519371598436L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8080692928733300511L,

3336821698903574117L,

2260493358221892339L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5485750454596678450L,

8400180550017687324L,

5787587309432012406L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8604802901703169083L,

2908104146513649490L,

949104015386144493L,

955484153736015312L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1913948558580157010L,

343936303601393420L,

7374992042158501563L,

7566236249369727218L,

},
},
            new Int64bigintArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3903075570188731036L,

2769200962558599429L,

4999568800966103405L,

6751297611814142935L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5337877211980470366L,

4702452145232744735L,

5866900086660464235L,

},
},
            new Int64bigintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5798543437659565165L,

948607396224006685L,

3669411249293810592L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
548689739992664409L,

6886211649326983822L,

3210216602611262706L,

7397344448882834729L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3619166539398605438L,

1335492564894022010L,

1880178415472301401L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4290572234309651610L,

2858826318047982293L,

5228858598810010644L,

5747171379213818371L,

},
},
            new Int64bigintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1547293217644410910L,

5577551958187141199L,

2371779330171896562L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8796214021507574299L,

3725429432030199518L,

340764175993291692L,

6445925607979988418L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1813916328333830955L,

7734012649388700284L,

3994823773181212234L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1136196272904545330L,

5514301525672970365L,

1188185562824464094L,

8141883141611834180L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6943446385457886871L,

2994422954605735081L,

4068203544626642916L,

8019356658262648568L,

},
},
            new Int64bigintArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9163902643389792604L,

5903105174164209750L,

7400351901449142649L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2918730491640767474L,

1663998553006911194L,

1807884122407028987L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
230414431936302132L,

7865500081843912822L,

3104325361128201183L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1473397963284636186L,

8738848406732052231L,

3836872611967192822L,

7212391715546058859L,

},
},
            new Int64bigintArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
504440854084515457L,

4701266203060129647L,

9174897704554907L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3243613065163448341L,

5934856537905502937L,

4445705472530368273L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8031486783098068990L,

6029432325370576120L,

1807376849386802864L,

8360297139208082853L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6054155442326517144L,

4578691129559269216L,

5087261772614680582L,

5295833799895894265L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3283883122604483607L,

3790300539076016131L,

9064784749569609498L,

897123826238971653L,

},
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[1], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[2], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[3], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[4], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[5], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[6], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[23],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[24],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[25],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[26],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[27],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[7], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[8], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[9], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[10], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[19],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[20],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[21],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
Int64bigintArray2M.AssertModel(models[0],_testData[25], false);Int64bigintArray2M.AssertModel(models[1],_testData[26], false);Int64bigintArray2M.AssertModel(models[2],_testData[27], false);Int64bigintArray2M.AssertModel(models[3],_testData[28], false);Int64bigintArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
Int64bigintArray2M.AssertModel(models[0],_testData[24], false);Int64bigintArray2M.AssertModel(models[1],_testData[25], false);Int64bigintArray2M.AssertModel(models[2],_testData[26], false);Int64bigintArray2M.AssertModel(models[3],_testData[27], false);Int64bigintArray2M.AssertModel(models[4],_testData[28], false);Int64bigintArray2M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Int64bigintArray2M.AssertModel(models[0],_testData[8], false);Int64bigintArray2M.AssertModel(models[1],_testData[9], false);Int64bigintArray2M.AssertModel(models[2],_testData[10], false);Int64bigintArray2M.AssertModel(models[3],_testData[11], false);Int64bigintArray2M.AssertModel(models[4],_testData[12], false);Int64bigintArray2M.AssertModel(models[5],_testData[13], false);Int64bigintArray2M.AssertModel(models[6],_testData[14], false);Int64bigintArray2M.AssertModel(models[7],_testData[15], false);Int64bigintArray2M.AssertModel(models[8],_testData[16], false);Int64bigintArray2M.AssertModel(models[9],_testData[17], false);Int64bigintArray2M.AssertModel(models[10],_testData[18], false);Int64bigintArray2M.AssertModel(models[11],_testData[19], false);Int64bigintArray2M.AssertModel(models[12],_testData[20], false);Int64bigintArray2M.AssertModel(models[13],_testData[21], false);Int64bigintArray2M.AssertModel(models[14],_testData[22], false);Int64bigintArray2M.AssertModel(models[15],_testData[23], false);Int64bigintArray2M.AssertModel(models[16],_testData[24], false);Int64bigintArray2M.AssertModel(models[17],_testData[25], false);Int64bigintArray2M.AssertModel(models[18],_testData[26], false);Int64bigintArray2M.AssertModel(models[19],_testData[27], false);Int64bigintArray2M.AssertModel(models[20],_testData[28], false);Int64bigintArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Int64bigintArray2M.AssertModel(models[0],_testData[9], false);Int64bigintArray2M.AssertModel(models[1],_testData[10], false);Int64bigintArray2M.AssertModel(models[2],_testData[11], false);Int64bigintArray2M.AssertModel(models[3],_testData[12], false);Int64bigintArray2M.AssertModel(models[4],_testData[13], false);Int64bigintArray2M.AssertModel(models[5],_testData[14], false);Int64bigintArray2M.AssertModel(models[6],_testData[15], false);Int64bigintArray2M.AssertModel(models[7],_testData[16], false);Int64bigintArray2M.AssertModel(models[8],_testData[17], false);Int64bigintArray2M.AssertModel(models[9],_testData[18], false);Int64bigintArray2M.AssertModel(models[10],_testData[19], false);Int64bigintArray2M.AssertModel(models[11],_testData[20], false);Int64bigintArray2M.AssertModel(models[12],_testData[21], false);Int64bigintArray2M.AssertModel(models[13],_testData[22], false);Int64bigintArray2M.AssertModel(models[14],_testData[23], false);Int64bigintArray2M.AssertModel(models[15],_testData[24], false);Int64bigintArray2M.AssertModel(models[16],_testData[25], false);Int64bigintArray2M.AssertModel(models[17],_testData[26], false);Int64bigintArray2M.AssertModel(models[18],_testData[27], false);Int64bigintArray2M.AssertModel(models[19],_testData[28], false);Int64bigintArray2M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 106, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[11], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[12], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[13], false);FlatInt64bigintArray2M.AssertModel(models[3],_testData[14], false);FlatInt64bigintArray2M.AssertModel(models[4],_testData[15], false);FlatInt64bigintArray2M.AssertModel(models[5],_testData[16], false);FlatInt64bigintArray2M.AssertModel(models[6],_testData[17], false);FlatInt64bigintArray2M.AssertModel(models[7],_testData[18], false);FlatInt64bigintArray2M.AssertModel(models[8],_testData[19], false);FlatInt64bigintArray2M.AssertModel(models[9],_testData[20], false);FlatInt64bigintArray2M.AssertModel(models[10],_testData[21], false);FlatInt64bigintArray2M.AssertModel(models[11],_testData[22], false);FlatInt64bigintArray2M.AssertModel(models[12],_testData[23], false);FlatInt64bigintArray2M.AssertModel(models[13],_testData[24], false);FlatInt64bigintArray2M.AssertModel(models[14],_testData[25], false);FlatInt64bigintArray2M.AssertModel(models[15],_testData[26], false);FlatInt64bigintArray2M.AssertModel(models[16],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[17],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatInt64bigintArray2M.AssertModel(models[0],_testData[27], false);FlatInt64bigintArray2M.AssertModel(models[1],_testData[28], false);FlatInt64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSelectModelBatchAsync(connection, 34, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Int64bigintArray2M.AssertModel(models[0],_testData[7], false);Int64bigintArray2M.AssertModel(models[1],_testData[8], false);Int64bigintArray2M.AssertModel(models[2],_testData[9], false);Int64bigintArray2M.AssertModel(models[3],_testData[10], false);Int64bigintArray2M.AssertModel(models[4],_testData[11], false);Int64bigintArray2M.AssertModel(models[5],_testData[12], false);Int64bigintArray2M.AssertModel(models[6],_testData[13], false);Int64bigintArray2M.AssertModel(models[7],_testData[14], false);Int64bigintArray2M.AssertModel(models[8],_testData[15], false);Int64bigintArray2M.AssertModel(models[9],_testData[16], false);Int64bigintArray2M.AssertModel(models[10],_testData[17], false);Int64bigintArray2M.AssertModel(models[11],_testData[18], false);Int64bigintArray2M.AssertModel(models[12],_testData[19], false);Int64bigintArray2M.AssertModel(models[13],_testData[20], false);Int64bigintArray2M.AssertModel(models[14],_testData[21], false);Int64bigintArray2M.AssertModel(models[15],_testData[22], false);Int64bigintArray2M.AssertModel(models[16],_testData[23], false);Int64bigintArray2M.AssertModel(models[17],_testData[24], false);Int64bigintArray2M.AssertModel(models[18],_testData[25], false);Int64bigintArray2M.AssertModel(models[19],_testData[26], false);Int64bigintArray2M.AssertModel(models[20],_testData[27], false);Int64bigintArray2M.AssertModel(models[21],_testData[28], false);Int64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Int64bigintArray2M.AssertModel(models[0],_testData[19], false);Int64bigintArray2M.AssertModel(models[1],_testData[20], false);Int64bigintArray2M.AssertModel(models[2],_testData[21], false);Int64bigintArray2M.AssertModel(models[3],_testData[22], false);Int64bigintArray2M.AssertModel(models[4],_testData[23], false);Int64bigintArray2M.AssertModel(models[5],_testData[24], false);Int64bigintArray2M.AssertModel(models[6],_testData[25], false);Int64bigintArray2M.AssertModel(models[7],_testData[26], false);Int64bigintArray2M.AssertModel(models[8],_testData[27], false);Int64bigintArray2M.AssertModel(models[9],_testData[28], false);Int64bigintArray2M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSelectModelBatch(connection, 100, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Int64bigintArray2M.AssertModel(models[0],_testData[20], false);Int64bigintArray2M.AssertModel(models[1],_testData[21], false);Int64bigintArray2M.AssertModel(models[2],_testData[22], false);Int64bigintArray2M.AssertModel(models[3],_testData[23], false);Int64bigintArray2M.AssertModel(models[4],_testData[24], false);Int64bigintArray2M.AssertModel(models[5],_testData[25], false);Int64bigintArray2M.AssertModel(models[6],_testData[26], false);Int64bigintArray2M.AssertModel(models[7],_testData[27], false);Int64bigintArray2M.AssertModel(models[8],_testData[28], false);Int64bigintArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Int64bigintArray2M.AssertModel(models[0],_testData[22], false);Int64bigintArray2M.AssertModel(models[1],_testData[23], false);Int64bigintArray2M.AssertModel(models[2],_testData[24], false);Int64bigintArray2M.AssertModel(models[3],_testData[25], false);Int64bigintArray2M.AssertModel(models[4],_testData[26], false);Int64bigintArray2M.AssertModel(models[5],_testData[27], false);Int64bigintArray2M.AssertModel(models[6],_testData[28], false);Int64bigintArray2M.AssertModel(models[7],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Int64bigintArray2M.AssertModel(models[0],_testData[28], false);Int64bigintArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Int64bigintArray2M.AssertModel(models[0],_testData[17], false);Int64bigintArray2M.AssertModel(models[1],_testData[18], false);Int64bigintArray2M.AssertModel(models[2],_testData[19], false);Int64bigintArray2M.AssertModel(models[3],_testData[20], false);Int64bigintArray2M.AssertModel(models[4],_testData[21], false);Int64bigintArray2M.AssertModel(models[5],_testData[22], false);Int64bigintArray2M.AssertModel(models[6],_testData[23], false);Int64bigintArray2M.AssertModel(models[7],_testData[24], false);Int64bigintArray2M.AssertModel(models[8],_testData[25], false);Int64bigintArray2M.AssertModel(models[9],_testData[26], false);Int64bigintArray2M.AssertModel(models[10],_testData[27], false);Int64bigintArray2M.AssertModel(models[11],_testData[28], false);Int64bigintArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray2M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray2M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

