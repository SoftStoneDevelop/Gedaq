

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
393032119459811769L,

64123678687104732L,

6857596708812796442L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4768759707343023143L,

2864400501661651480L,

8680215973744104509L,

},
},
            new Int64bigintArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3105485177081775009L,

9035949281850602456L,

5769596592335261628L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8107449991293102889L,

7860909273595375623L,

527382557513662864L,

6415792534450019593L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7859020192691849338L,

6034181676477060962L,

5336119216757101404L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8403430593691827153L,

79278985046893368L,

4924349952969828557L,

},
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5815080757136655605L,

1486058454777135107L,

8580137244864000320L,

6637923781134380457L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4390684263527500388L,

5115281828311546088L,

2359483618047664718L,

},
},
            new Int64bigintArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3296168419588311924L,

613254141597531137L,

2156466946149968154L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
22439880064405980L,

6917831182252397099L,

6014031627107897399L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1643170575894807381L,

5842308468854298181L,

5181354505574903799L,

},
},
            new Int64bigintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
303245519382592685L,

8107991409056583855L,

2739193458534472848L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9149582597572684931L,

6653615686566625798L,

5966534875039338279L,

8710325919541220186L,

},
},
            new Int64bigintArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5232054348654069920L,

5773535261811113362L,

5273988503568525075L,

6548767127700756205L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3456382422660374495L,

3442022538466271991L,

1974890966912231600L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6217437808763530711L,

925940852697524200L,

8515961319833837948L,

5969575302136248958L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7325735070223383508L,

7961930296960622098L,

2765438908278153562L,

},
},
            new Int64bigintArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7977688101601286162L,

6495113606736503264L,

6434053831633936716L,

1297388688532505446L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3620275318090959825L,

357534562243604385L,

3499060401819548392L,

4799511684094023378L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3759644775604316757L,

1729336747484957534L,

4908248211651701620L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3366448735026821496L,

4337432830414997679L,

7157372189485317961L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3446036673464791250L,

807814253179197913L,

8224469632877967775L,

3655484259735321327L,

},
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7610063794632051509L,

1159727540877990424L,

5248602214773939673L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
782368541101776680L,

6620212532974295608L,

3619683873196972097L,

3509134817799622573L,

},
},
            new Int64bigintArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7754528641796931203L,

4588952511552130392L,

3813056881455877892L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7142979818619653427L,

4107487059416580583L,

8858455305236979839L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6949710597995762917L,

2319947738201765486L,

5568272885837255149L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5517205931468389921L,

6933026123257590891L,

8878424255427225566L,

},
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1775583756949735870L,

1618099858108254755L,

1778948694516955953L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8764571507956609249L,

8861821041007366457L,

6475868514500483994L,

7702341827413588188L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7062645096973853425L,

8543581066856336714L,

907431473324612983L,

9099719146799704106L,

},
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3340123633668551647L,

5506938596188640092L,

2294033090779246645L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7216765194469715661L,

1296428936419152931L,

8466799195741580379L,

},
},
            new Int64bigintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4148487343116740493L,

2620134874550918853L,

7831009676004890907L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6847007183169286591L,

2636987593743302505L,

5993626273447395666L,

9194548736185609891L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3981167572325850260L,

530694863276051833L,

2086367485697957255L,

},
},
            new Int64bigintArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8936069738666421566L,

8736896979027309608L,

4370174706051053506L,

219008367189053889L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7153173649036394151L,

7356231233302121939L,

1089090793818094735L,

4638609336948473487L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2642189584812273422L,

997841833369950113L,

6725407940513747683L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5051747564560136631L,

3442609631769834733L,

3255115953776292768L,

5751951961937502151L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4260342576680159310L,

8445963005763687579L,

3607785375850267517L,

2191894373518667765L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7361650346486575272L,

6404124692924059717L,

8424735702759717374L,

5792033359793482580L,

},
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5263223209407398502L,

1024307027391338147L,

5273747573877898403L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4413533962007265055L,

7532112526809214783L,

706171022471082348L,

6462419588565177586L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4567407097359799126L,

7298385551798779152L,

3302051034082398691L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7188284364970934472L,

1898642144872475656L,

7188148867073272864L,

4070995398559968606L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2347617137212861586L,

3274089751863627884L,

329776379537621671L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3166065478040950049L,

3731969764484247780L,

2351601009900701735L,

8057596309836071190L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7150797828147963325L,

8764039362455078976L,

3514479376033870762L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3442666690223917566L,

106642412604709169L,

8680271711629082951L,

},
},
            new Int64bigintArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7252297269238860067L,

5501465002411766204L,

7533312735695737804L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8931682598836054213L,

7202086505759972975L,

1490488422576378264L,

2483489881043438680L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4858564428598429258L,

1329753885806658663L,

6016151106836254977L,

4501341459440699039L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4332525162942520789L,

8138932398817980856L,

4934497308411245425L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2808370127654250660L,

8466543988244908834L,

4912928807075428966L,

},
},
            new Int64bigintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5107890808941453835L,

8246060618624826682L,

2511029415641255104L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7741577461268984540L,

1496665306240296195L,

2991083129926181565L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4926816000786238278L,

2720099563108976363L,

3141726269464273674L,

2195480925839532854L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1032667149102088280L,

6448210732482959077L,

1150121739630576760L,

1595410775976975678L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8992165831193239885L,

962253457833946391L,

7229129403585476545L,

2781270278991279214L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7723966729459385506L,

8622353304109677939L,

84883423278086924L,

3977225830362994434L,

},
},
            new Int64bigintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4111199657753776558L,

793497519852826026L,

5377049256679236926L,

5231036377426476961L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
844023268115832206L,

8040816714881304204L,

5354458547285936853L,

2994166515381806256L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
191883206254339913L,

5017189640959617587L,

5992364588001019337L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4542300442987472735L,

4536576833956071166L,

1933938018398493164L,

},
},
            new Int64bigintArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3501035476177703121L,

4807764702826414056L,

3126085732654622698L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3638763426544031887L,

2728069354248698926L,

5134123844699814203L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2792506253769819581L,

553445889284484047L,

8164764739702732350L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
332402080396856966L,

3043859644980690857L,

1035359588785709078L,

},
},
            new Int64bigintArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8356103363304095591L,

1192798278860904207L,

2355326058738762538L,

6814385658768603909L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6800277043565497645L,

6506172340619388961L,

7943457639564239043L,

5064034525887837419L,

},
},
            new Int64bigintArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1080974587598174993L,

7221072170195801029L,

1895822683401174327L,

1332492294339027226L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
593833017384575571L,

2049905125693444926L,

3599544417145879126L,

6474890062195265360L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1449739332037026713L,

3773287878752797551L,

7399870647193325431L,

8084704957893035628L,

},
},
            new Int64bigintArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1362795563779012162L,

3880090877017319372L,

8280616895031269520L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5016849705457029657L,

8793409652534915550L,

1529275767819010941L,

1829122031392683209L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6593048903204716489L,

4650078314301555361L,

3774017876615496288L,

5830450478371333956L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5331810585292667324L,

3455885794632902420L,

5124997856992745642L,

6189964320861530254L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3627748263964297355L,

916432747107990728L,

4796795296037717155L,

},
},
            new Int64bigintArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7347972116852527007L,

3548129509262225055L,

788203692284760186L,

5414867846454492202L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8873131404015242994L,

2618646652914296537L,

835060046762710004L,

2904905605006994364L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5640605462104132582L,

3970704881924693373L,

9007174753489629185L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2715704814763142228L,

2617117941209124471L,

4868603612971251091L,

7070093909811654876L,

},
},
            new Int64bigintArray2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4585846020218251400L,

6757024398027314992L,

6192384885481777707L,

1965863926728987396L,

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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintArray2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintArray2M.AssertModel(models[0],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray2M.AssertModel(models[0],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 151, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 127, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 185, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 175, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 163, query1, 176, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray2M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 72, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray2M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[31],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[32],_testData[34], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 185);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                Int64bigintArray2M.AssertModel(models[0],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 176);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Int64bigintArray2M.AssertModel(models[0],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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

